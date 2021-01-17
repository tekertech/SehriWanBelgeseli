 1-) Creating our classes with EntityFramework.

 Install-Package Microsoft.EntityFrameworkCore
 Install-Package Microsoft.EntityFrameworkCore.SqlServer
 Install-Package Microsoft.EntityFrameworkCore.Tools
 
To Use Entity Framework Database First Model:

 Scaffold-DbContext "Data Source=?;Initial Catalog=SehriWanBelgeselDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" 
                    Microsoft.EntityFrameworkCore.SqlServer -OutputDir Domain
 
 
