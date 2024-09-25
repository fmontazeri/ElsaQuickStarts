// See https://aka.ms/new-console-template for more information

using Elsa.Services;
using ElsaQuickstarts.ConsoleApp.HelloWorld.Workflows;
using Microsoft.Extensions.DependencyInjection;


// Create a service container with Elsa services.
var services = new ServiceCollection()
    .AddElsa(options => options
        .AddConsoleActivities()
        .AddWorkflow<HelloWorld>())
    .BuildServiceProvider();
            
// Get a workflow runner.
var workflowRunner = services.GetRequiredService<IBuildsAndStartsWorkflow>();

// Run the workflow.
await workflowRunner.BuildAndStartWorkflowAsync<HelloWorld>();