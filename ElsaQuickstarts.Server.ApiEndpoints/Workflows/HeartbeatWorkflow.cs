using Elsa.Activities.Console;
using Elsa.Activities.Temporal;
using Elsa.Builders;
using NodaTime;

namespace ElsaQuickstarts.Server.ApiEndpoints.Workflows;

public class HeartbeatWorkflow : IWorkflow
{
    private readonly IClock _clock;
    public HeartbeatWorkflow(IClock clock) => _clock = clock;

    public void Build(IWorkflowBuilder builder) =>
        builder
            .Timer(Duration.FromSeconds(120))//The first activity Timer will cause this workflow to execute every 10 seconds. 
            //This overload takes a delegate instead of a string literal that allows you to provide property values at runtime that are dynamic.
            .WriteLine(context => $"Heartbeat at {_clock.GetCurrentInstant()}");//The second activity WriteLine writes the current time to standard out. 
}