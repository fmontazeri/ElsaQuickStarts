using Elsa.Activities.Console;
using Elsa.Builders;

namespace ElsaQuickstarts.ConsoleApp.HelloWorld.Workflows;

public class HelloWorld : IWorkflow
{
    //The below workflow has only one step (a.k.a. activity): WriteLine
    public void Build(IWorkflowBuilder builder) => builder.WriteLine("Hello World!");
}
    