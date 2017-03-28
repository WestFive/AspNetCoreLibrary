
SimpleCURD
---------------
```
It's very SimpleDemo to Use SinglaR
```
[LearnMore](https://github.com/aspnet/SignalR)

Step
---------------
```
step1:
cmd
>dotnet new mvc

```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/SimpleSignalRCore/StepImages/step1.png)
```
step2:
NuGet=>
Add AspNetSinglRCore.Server&Messaging two packges
append to the proj.
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/SimpleSignalRCore/StepImages/step2.png)

```
step3:
edit the Startup.cs
Methold=> ConfigureServices
{
services.AddSignalR();
}
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/SimpleSignalRCore/StepImages/step3.png)

```
step4:
edit the Startup.cs
Methold=> Cofigure
{
 app.UseSignalR();
}
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/SimpleSignalRCore/StepImages/step4.png)

```
step5: Create a floder
SignlR => 
Add a Class MessageHub or ExampleHub (whatever you want)
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/SimpleSignalRCore/StepImages/step5.png)

```
step6: Edit a Simple HubClass(Server Hubs)
3 Methods.
SendMessage;
Connected;
DisConnected;
```
![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/SimpleSignalRCore/StepImages/step6.png)

```
step 7: Edit a Simple Clinet
need two  Js .
Jquery;
Jquery.SignalR.
```
[JQuery](http://oigpc85pe.bkt.clouddn.com/jquery-1.6.4.js)

[JQuery.SignalR](http://oigpc85pe.bkt.clouddn.com/jquery.signalR-2.2.1.js)

![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/SimpleSignalRCore/StepImages/step7.png)

```
end:
run
```

![image](https://github.com/WestFive/AspNetCoreLibrary/blob/master/SimpleSignalRCore/StepImages/step8.png)

enjoy it .





