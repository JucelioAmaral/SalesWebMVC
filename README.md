# Sistema de Vendedores

Aplicação Web, Asp Net Core MVC, feita em .Net core 2.1, usando Entity framework para persistencia e acesso ao banco de dados MySql, como SGBD.

## Pré requisitos

1. [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/vs/)
2. [Node.js](https://nodejs.org/en/download/)
3. [ASP.NET Core 2.1+](https://dotnet.microsoft.com/download/dotnet-core/2.1)
4. [MySql](https://dev.mysql.com/downloads/mysql/), clicar em "Go to Download Page";
4.1. Clicar no botão "Download" da maior instalação "Windows (x86, 32-bit), MSI Installer";
4.2. Clicar em "No thanks, just start my download." para baixar a instalação e realizar a instalação.

## Como baixar o código

git clone https://github.com/JucelioAmaral/SalesWebMVC.git

## Como configurar?

1. Abrir a solution;
2. Configurar o arquivo "appsettings.json" com a connectionString, apontando para o banco MySql server;
3. Abrir o Console do Visual Studio;
4. Executar o comando: Add-Migration InitialCreate;
5. Executar o comando: Update-Database;
6. Alterar o debug para SalesWebMVC;
7. Executar o app (SalesWebMVC).

**O APP roda na porta https://localhost:5001**

## Como executar a aplicação?

1. Abrir a solution;
2. Alterar o debug para SalesWebMVC;
3. Executar o app (SalesWebMVC).
