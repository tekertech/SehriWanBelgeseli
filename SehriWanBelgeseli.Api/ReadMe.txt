 1-) Creating our classes with EntityFramework.

 Install-Package Microsoft.EntityFrameworkCore
 Install-Package Microsoft.EntityFrameworkCore.SqlServer
 Install-Package Microsoft.EntityFrameworkCore.Tools
 
To Use Entity Framework Database First Model:

 Scaffold-DbContext "Data Source=?;Initial Catalog=SehriWanBelgeselDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" 
                    Microsoft.EntityFrameworkCore.SqlServer -OutputDir Domain
 
2-) How to using AutoMapper on ASP.NET Core 3.0 via Dependency Injection

Source : https://www.codementor.io/@zedotech/how-to-using-automapper-on-asp-net-core-3-0-via-dependencyinjection-zq497lzsq

Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection -Version 7.0.0

3-) Addition of CORS (Cross-Origin Resource Sharing) middleware and service. SOP (Same Origin Policy) demolition

Source : https://medium.com/@gokhansengun/cors-nedir-ve-ne-i%C5%9Fe-yarar-27006d85bf54