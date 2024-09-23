##Requirements
### .net8

https://dotnet.microsoft.com/en-us/download


### Entity framework
Install using `dotnet tool install --global dotnet-ef`


### Packages
Packages will be installed automatically when you run `dotnet build`
You can also manually install them using `dotnet restore`

## Migrations

If you make any changes to the DB, you will need to create new migrations.
. This can be done using the dotnet ef command

`dotnet ef migrations add <migration name> --context <context name>`

To apply the migration run 

`dotnet ef database update --context <context name>`

