$PSScriptRoot = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition
CD $PSScriptRoot
dotnet ef dbcontext scaffold "Server=ServerName;Database=DEV_TestTemp;Uid=tmp_user;Pwd='NotHardPassword1!';MultipleActiveResultSets=true;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --context "TempDataContext" --data-annotations --force --no-onconfiguring
