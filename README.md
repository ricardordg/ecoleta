# Ecoleta  
Plataforma para cadastrar pontos de coleta de resíduos descartáveis.

## Descrição  
Projeto construído na Next Level Week #01 mais servidor alternativo em .NET Core Framework

## Estrutura  
L *ecoleta*  
&nbsp;&nbsp;L *web*  
&nbsp;&nbsp;&nbsp;&nbsp;L Implementação do front-end web para criar pontos de coleta  
&nbsp;&nbsp;&nbsp;&nbsp;L Desenvolvido em **React.js**  

&nbsp;&nbsp;L *server*  
&nbsp;&nbsp;&nbsp;&nbsp;L Implementação do back-end   
&nbsp;&nbsp;&nbsp;&nbsp;L Desenvolvido em **node**  

&nbsp;&nbsp;L *webapiserver*  
&nbsp;&nbsp;&nbsp;&nbsp;L Implementação alternativa do backend  
&nbsp;&nbsp;&nbsp;&nbsp;L Desenvolvido em **.NET Core Framework**:  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;L Repository Pattern  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;L Modularização  


## Comandos

**run web**: *yarn start*  
  
**run server**: *yarn dev*

**run webapiserver**: *dotnet run*

## Configurações
 
 **webapiserver: configurar banco usando migrations**  
  1. criar um banco de dados postgres  
  2. renomear o arquivo "appsettings.json.example" para "appsettings.json"  
  3. alterar as informações do campo "webapiConnection" com as informações do seu banco de dados  
  4. rodar o comando: "dotnet ef migration add NomeDaMigration" -o Data/Migrations"  
  5. rodar o comando: "dotnet ef database update"  




