 1-) EntityFramework ile classlarımızın oluşturulması.

 Install-Package Microsoft.EntityFrameworkCore
 Install-Package Microsoft.EntityFrameworkCore.SqlServer
 Install-Package Microsoft.EntityFrameworkCore.Tools
 
 EntityFramework Database First Modeli Kullanmak için :
 Scaffold-DbContext "Data Source=TEKERM;Initial Catalog=SehriWanBelgeselDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" 
                    Microsoft.EntityFrameworkCore.SqlServer -OutputDir Domain
 
 