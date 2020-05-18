using Application.UseCase.Aluno;
using Application.UseCase.Disciplina;
using Application.UseCase.DisciplinaMatricula.CancelamentoMatricula;
using Application.UseCase.Matricula;
using Domain.Repository;
using Domain.Service.Aluno;
using Domain.Service.Disciplina;
using Domain.Service.Matricula;
using Domain.Service.TurmaDisciplina;
using Infrastructure.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using AutoMapper;
using Presentation;
using Application.UseCase.Matricula.EspelhoMatricula;

namespace WebApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #region Repository
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IMatriculaRepository, MatriculaRepository>();
            services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
            services.AddScoped<IDisciplinaMatriculaRepository, DisciplinaMatriculaRepository>();
            #endregion

            #region UseCases
            services.AddScoped<ICadastroMatricula, CadastroMatricula>();
            services.AddScoped<ICadastroAluno, CadastroAluno>();
            services.AddScoped<IListarDisciplinas, ListarDisciplinas>();
            services.AddScoped<ICancelamentoMatricula, CancelamentoMatricula>();
            services.AddScoped<IEspelhoMatricula, EspelhoMatricula>();
            #endregion

            #region Services
            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IDisciplinaService, DisciplinaService>();
            services.AddScoped<IMatriculaService, MatriculaService>();
            services.AddScoped<ITurmaDisciplinaService, TurmaDisciplinaService>();
            #endregion

            services.AddAutoMapper(typeof(PresentationProfile));

            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Gestão Matrícula", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gestão Matrícula");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
