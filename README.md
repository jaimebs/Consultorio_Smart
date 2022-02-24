# Consultorio Smart 🖥️
Projeto para estudos em .NET Core 5, utilizando as melhores práticas e organização.

### Organização do projeto
O projeto esta separado por outros projetos e pastas:
- 01.WebApi
- 02.Manager
- 03.Data
- 04.Core
- 05.Tests

### Pacotes instalados
- Microsoft.EntityFrameworkCore (5.0.14) - Biblioteca para mapeado relacional de objeto (ORM).
- Microsoft.EntityFrameworkCore.Design (5.0.14) - Biblioteca que habilita as migrations e outras ferramentas.
- Microsoft.EntityFrameworkCore.Tools (5.0.14) - Biblioteca que habilita comandos no console para a geração das migrations.
- Microsoft.EntityFrameworkCore.SqlServer (5.0.14) - Biblioteca para ter acesso e manipular o banco de dados SQL SERVER.
- FluentValidation.AspNetCore (10.3.6) - Biblioteca de validação para .NET que usa uma interface fluente e expressões lambdas para criar regras de validação distribuída.
- AutoMapper (11.0.1) - Biblioteca construída para resolver o mapeamento de um objeto para outro (DTO).
- AutoMapper.Extensions.Microsoft.DependencyInjection (11.0.0) - Biblioteca para efetuar a injeção de dependência do AutoMapper.

### Conexão com banco de dados
No projeto WebApi no arquivo appsettings.json, incluir a string de conexão conforme exemplo abaixo:
> "ConnectionStrings": {
    "dbConnection": "Data Source=COMPUTER\\SQLEXPRESS;Initial Catalog=nomeDoBanco;Integrated Security=True"
  }

 Depois incluir em Startup no método *ConfigureServices*:
> services.AddDbContext<CsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("dbConnection")));

### Explicação de como gerar as migrations
Para gerar as migrations e logo criar/atualizar a tabela no banco de dados, segue os comandos abaixo:
- add-migration **nome_da_migration** (Gera a migration)
- update-database (Gera a tabela no banco de dados)

### Instruções para a injeção de dependência
Para efetuar a injeção de dependência no projeto, depois de criado as interfaces e os respositories, devem ser incluídas no Startup do projeto WebApi, no método *ConfigureServices*.
> Ex: services.AddScoped<IClienteRepository, ClienteRepository>();

------------

*Feito por Jaime Barbosa - [Linkedin](https://www.linkedin.com/in/jaimebs/ "Linkedin")*
