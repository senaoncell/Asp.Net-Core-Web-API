<h3>StoreApp Project Scheme</h3>

<img src=".\assets\AspNetCoreWebApi.png" alt="" width="640" height="320">
<br/>

<b>Technologies Used</b>

<ul>
<li>Visual Studio</li>
<li>Swagger</li>
<li>Postman</li>
</ul>

<b>Solution -> Add new project -> ASP.NET Core Web API</b>

<ul>
<li> WebApi</li>
</ul>

<b>Solution -> Add new project -> Class Library</b>

<ul>
<li>Entities</li>
<li>Repositories</li>
<li>Services</li>
<li>Presentation</li>
</ul>

<b>Tools -> NuGet Package Manager -> Package Manager Console</b>

<h3> WEB API</h3>

<b>Package References</b>

<ul>
<li>Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.0 -ProjectName WebApi</li>
<li>Install-Package Microsoft.EntityFrameworkCore.Design -Version 8.0.0 -ProjectName WebApi</li>
<li>Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.0 -ProjectName WebApi</li>
<li>Install-Package Microsoft.AspNetCore.Mvc.NewtonsoftJson -Version 8.0.0 -ProjectName WebApi</li>
<li>Install-Package AspNetCoreRateLimit -ProjectName WebApi</li>
<li>Install-Package Microsoft.AspNetCore.Authentication.JwtBearer -Version 8.0.0 -ProjectName WebApi</li>
</ul>

<b>Project References</b> -> Entities, Repositories, Services, Presentation

<h3>REPOSITORIES</h3>

<b>Package References</b>

<ul>
<li>Install-Package Microsoft.EntityFrameworkCore -Version 8.0.0 -ProjectName Repositories</li>
<li>Install-Package System.Linq.Dynamic.Core -ProjectName Repositories</li>
</ul>

<b>Project References</b> -> Entities

<h3>ENTITIES</h3>

<b>Package References</b>

<ul>
<li>Install-Package Microsoft.AspNetCore.Mvc.Abstractions -ProjectName Entities</li>
<li>Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -Version 8.0.0 -ProjectName Entities</li>
</ul>

<h3>PRESENTATION</h3>

<b>Package References</b>

<ul>
<li>Install-Package Microsoft.AspNetCore.JsonPatch -Version 8.0.0 -ProjectName Presentation</li>
<li>Install-Package Microsoft.AspNetCore.Mvc.Core -ProjectName Presentation</li>
<li>Install-Package Microsoft.AspNetCore.Mvc.NewtonsoftJson -Version 8.0.0 -ProjectName Presentation</li>
<li>Install-Package Microsoft.AspNetCore.Mvc.Versioning -ProjectName Presentation</li>
<li>Install-Package Marvin.Cache.Headers -ProjectName Presentation</li>
</ul>

<b>Project References</b> -> Services

<h3>SERVICES</h3>

<b>Package References</b>

<ul>
<li>Install-Package NLog.Extensions.Logging -ProjectName Services</li>
<li>Install-Package automapper.Extensions.Microsoft.DependencyInjection -ProjectName Services</li>
<li>Install-Package System.IdentityModel.Tokens.Jwt -Version 8.0.0 -ProjectName Services</li>
</ul>

<b>Project References</b> -> Entities,Repositories

