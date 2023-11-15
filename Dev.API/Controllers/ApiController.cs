using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class MyApiController : ControllerBase
{
    [HttpGet("hello")]
    public IActionResult GetHello([FromQuery] string message)
    {
        Console
            .WriteLine($"Hello World from GET was called, received message: {
                message}");
        return Ok($"Hello World from GET, received message: {message}");
    }

    [HttpPost("heartbeat")]
    public IActionResult PostHeartbeat([FromQuery] string message)
    {
        // Your logic for handling the heartbeat
        return Ok($"Heartbeat received: {message}");
    }

    // Add other routes as needed
}
