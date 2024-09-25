using ElsaQuickstarts.WebApp.HelloWorld.Workflows;

//https://localhost:7211/hello-world

//In this guide, we've seen how to setup a workflow that is triggered when an HTTP request comes in.
//Implementing HTTP workflows is a great way to easily implement logic in response to HTTP requests quickly.

var builder = WebApplication.CreateBuilder(args);
//Unhandled exception. System.InvalidOperationException: The service collection cannot be modified because it is read-only.
//app.UseHttpActivities();

builder.Services
    .AddAuthorization()
    .AddElsa(options => options
        .AddHttpActivities()
        .AddWorkflow<HelloWorld>());

var app = builder.Build();
app.UseRouting(); // Routing middleware
app.UseHttpActivities();
app.Run();