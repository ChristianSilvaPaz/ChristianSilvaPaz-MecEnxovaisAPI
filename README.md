# Mec Enxovais API

Backend do software desenvolvido com o propósito de facilitar o controle de estoque e vendas de uma pequena loja de enxovais.

# :rocket: Começando

Essas instruções permitirão que você obtenha uma cópia do projeto em operação na sua máquina local para fins de desenvolvimento e teste. a

:clipboard: Pré-requisitos

<ul>
  <li> <a href="https://dotnet.microsoft.com/pt-br/download/dotnet/7.0"> .NET 7 ou superior </li>
  <li> <a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads" SQL Server 12 ou superior> </li>
</ul>

# :wrench: Clonar, configurar e executar

## 1. Obtendo uma cópia e configurando
Abra um terminal e clone este repositório em qualquer diretório da sua máquina (recomendado c:\ no Windows) utilizando o comando: git clone https://github.com/ChristianSilvaPaz/ChristianSilvaPaz-MecEnxovaisApi.git

Acesse o diretório do projeto em: MecEnxovaisApi/MecEnxovais.API

Localize e abra o arquivo de configuração: appsettings.Development.json

Altere a seção ConnectionStrings com as informações de conexão com o SqlServer:

"ConnectionStrings": {
"DefaultConnection": "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;"
}

## 2. Subindo o Backend
Observação: os passos abaixo foram realizados utilizando um ambiente de desenvolvimento integrado como o <a href="https://visualstudio.microsoft.com/pt-br/" Microsoft Visual Studio>, basta abrir a solução MecEnxovais.sln que está na pasta src e executar o projeto MecEnxaovais.API
  
Após isto, a Web API estará em pleno funcionamento. É possível visualizar a documentação e testar API, essa tela deverá aparecer na aba do seu navegador:
 
![image](https://github.com/ChristianSilvaPaz/ChristianSilvaPaz-MecEnxovaisApi/assets/62564760/443d920e-ff54-4653-be0d-bdaa05c1d84f)
  
# :hammer_and_wrench: Construído com:
Ferramentas/tecnologias utilizadas para construção deste projeto

  <ul>
    <li> <a href="https://dotnet.microsoft.com/pt-br/download/dotnet/7.0" .NET 7 - Backend e Web API></li>
    <li> <a href="https://learn.microsoft.com/pt-br/ef/core/" Entity Framework Core - Mapeamento objeto-relacionalI</li>
    <li> <a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads" SQL Server - Banco de dados relacional</li>
    <li> <a href="https://learn.microsoft.com/pt-br/ef/ef6/modeling/code-first/fluent/types-and-properties" Fluent API - Configuração e o mapeamento no EF</li>
    <li> <a href="https://visualstudio.microsoft.com/pt-br/vs/" Visual Studio 2022 - IDE C# / .NET</li>
    <li> <a href="https://swagger.io/" Swagger - Documentação e teste da API</li>
  </ul>

# :books: Arquitetura
Arquitetura limpa refere-se à **organização do projeto** de forma que ele seja fácil de **entender**, fácil de **testar**, fácil de **manter** e fácil de **mudar** conforme o projeto cresce.
**A Regra de Dependência** afirma que a dependência do código-fonte só pode apontar para o **interior do aplicativo**.
Dessa forma o **domínio** é independente e não faz referência a recursos externos.
![image](https://github.com/ChristianSilvaPaz/ChristianSilvaPaz-MecEnxovaisApi/assets/62564760/41abc3a3-adc4-4d01-9e4c-9d1d7a618569)

  



  



