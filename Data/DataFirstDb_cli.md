```bash
# Vistual Studio, SQL Server
Scaffold-DbContext "Server=DESKTOP-EI4423A;Database=DatabaseFirstDB;IntegratedSecurity=true;TrustServerCertification=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

# VS Code, PostgreSQL
dotnet ef dbcontext scaffold "Server=localhost;Port=15432;User Id=postgres;Password=password;Database=customerdb2;" Npgsql.EntityFrameworkCore.PostgreSQL --output-dir Models
```

