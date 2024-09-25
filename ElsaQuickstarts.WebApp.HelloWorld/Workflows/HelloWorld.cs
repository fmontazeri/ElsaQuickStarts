using System.Net;
using Elsa.Activities.Http;
using Elsa.Builders;

namespace ElsaQuickstarts.WebApp.HelloWorld.Workflows;

public class HelloWorld : IWorkflow
{
    public void Build(IWorkflowBuilder builder)
    {
        //Create more complicated workflows using the Workflow Builder API.
        builder
            .HttpEndpoint("/hello-world")
            .WriteHttpResponse(HttpStatusCode.OK, "<h1>Hello World!</h1>", "text/html");
    }
}