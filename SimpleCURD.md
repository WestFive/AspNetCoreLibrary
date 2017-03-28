SimpleCURD
---------------
```
Fork in docs.microsoft.com
```
Step
---------------
```
step1:
cmd
>dotnet new mvc

```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/AspNetCore.Simple/Example.Image/step1.png)
```
step2:
oepn the csproj.(use vs2017)

create a floder=>
create a class User
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/AspNetCore.Simple/Example.Image/step2.png)

```
step3:
add a Controller
> MVC Controllser with views, using Entity Framework
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/AspNetCore.Simple/Example.Image/step3.png)

```
step4:
set the Controller
> choose the Model class that your in step2 write class 
>Data content class click + (whatever you want)
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/AspNetCore.Simple/Example.Image/step4.png)

```
cmd 
> dotnet run 
open the localhost:5000

```
If you see this Exception
```
An unhandled exception occurred while processing the request.
SqlException: Cannot open database "MvcMovieContext-<GUID removed>" 
requested by the login. The login failed.
Login failed for user Rick
```
then we should continue
```
step5: Add EF tooling
In Solution Explorer, right click the simpleCURD project > Edit SimpleCURD.csproj.
you can also use  NuGet to add the EF tooling
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/AspNetCore.Simple/Example.Image/step5.png)

```
step6: Update the database
cmd
>dotnet restore
>dotnet ef migrations add Initial
>dotnet ef database update
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/AspNetCore.Simple/Example.Image/step6.png)

```
last step:
build the proj and run
cmd
>dotnet run
open the http://localhost:5000
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/AspNetCore.Simple/Example.Image/step7.png)
enjoy it .





