
# Escola.Api

Esse projeto apresenta uma solução WEB que possibilita realizar o CRUD de Escolas, Turmas e Alunos.






## Como rodar o projeto:

- Clone o repositório

- Abra o projeto com sua IDE de preferência (foi usado o JetBrains Rider durante o desenvolvimento)

- Vá até o arquivo `appsettings.json` e `appsettings.Development.json`.

  No campo `password`, adicione a senha do seu banco de dados SQL Server

  No campo `Id` adicione o seu usuário do banco de dados SQL Server

  No campo `Data Source` adicione a URL de conexão com o seu banco de dados SQL Server



- Após a configuração do appsettings, abra o terminal na pasta do projeto e digite o seguinte comando: `dotnet ef database update --project .\Escola.Api\`


