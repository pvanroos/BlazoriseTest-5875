namespace BlazorWasmBlazoriseTest.Pages;

public partial class Home
{
    private readonly ILogger<Home> _logger;

    public Home(ILogger<Home> logger)
    {
        _logger = logger;
    }

    protected override void OnInitialized()
    {
        _logger.LogInformation("Testing the injectable ILogger from Microsoft.Extensions.Logging");
        base.OnInitialized();
    }
}
