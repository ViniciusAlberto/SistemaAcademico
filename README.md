# Sistema de gestão de matrículas<h1> 

## Resumo  Aplicação
Prova arquitetural para um sistema de acadêmico. A prova de conceito irá simular um processo de matrícula em disciplinas. 

## Tecnologias e abordagens utilizadas

- <b>.Net core 3.0</b> como framework de desenvolvimento;

- <b>xUnit</b> para desenvolvimento de testes unitários,
- <b> Modelo arquitetural: Clean Architecture </b>

## Desenvolvimento
Seguindo os principios do Clean Architeture o projeto foi divido em 4 camadas: Application, Domain, Infrastructure.Repository, e WebApi

<b><h3>Domain:</h3></b> Encontra as classes domínio da aplicação. Os dominios que foram implementados para prova de conceito foram:

- Aluno
- Matricula
- Disciplina
- Turma
- DisciplinaMatricula
- TurmaDisciplina


 <b><h3> Application:</h3></b> Encontra os casos de uso da aplicação, que foram divididos em pasta de acordo com o dominio utilizado:
<i>
<b>Aluno</b>

- Cadastro de Aluno

<b>Disciplina</b>

- Listar Disciplinas 

<b>DisciplinaMatricula</b>

- Cancelamento de uma disciplina da matricula

<b>Matricula</b>

- Cadastro de Matricula
- Espelho de Matricula
</i>


<b><h3>Infrastructure.Repository:</h3></b>

Camada responsavel por conexão com o banco de dados. Para está prova de conceito criamos um classe DataFake onde existe uma lista de dados de cada dominio.


<b><h3>WebApi:</h3></b>

Camada de interface onde é exposto uma API para consumir os casos de Uso.