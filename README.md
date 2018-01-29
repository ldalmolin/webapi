# webapi

dotnet ef dbcontext scaffold "Server=localhost;User Id=root;Password=root;Database=webapi" "Pomelo.EntityFrameworkCore.MySql" --force


Code First

dotnet ef migrations add initial

dotnet ef database update
