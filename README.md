# webapi

dotnet ef dbcontext scaffold "Server=localhost;User Id=root;Password=root;Database=webapi" "Pomelo.EntityFrameworkCore.MySql" --force


Code First

dotnet ef migrations add initial

dotnet ef database update

curl -X GET \
  http://localhost:5000/Account/Protected
  -H 'authorization: Bearer Token
  -H 'cache-control: no-cache' \
  -H 'content-type: application/json'
  
  dotnet add package Dapper
