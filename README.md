# Way2Commerce

## OpenAPI
https://localhost:7168/swagger/index.html

## Migration (EF Core)
`dotnet ef migrations  add [NameOfYourMigration] --startup-project src/Way2Commerce.API/Way2Commerce.API.csproj --project src/Way2Commerce.Data.PostgreSQL/Way2Commerce.Data.PostgreSQL.csproj`

`dotnet ef database update  --startup-project src/Way2Commerce.API/Way2Commerce.API.csproj --project src/Way2Commerce.Data.PostgreSQL/Way2Commerce.Data.PostgreSQL.csproj`