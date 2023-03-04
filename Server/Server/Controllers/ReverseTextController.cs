using Microsoft.AspNetCore.Mvc;
using Common; // Required library with implementation.
using Server.Models;

namespace Server.Controllers;

/// <summary>
/// Controller with required endpoints.
/// </summary>
[ApiController]
[Route("[controller]")]
public class ReverseTextController : ControllerBase
{
    /// <summary>
    /// Class that contains the main logic with text processing.
    /// </summary>
    private readonly TaskHelper _taskHelper;

    /// <summary>
    /// Controller logger.
    /// </summary>
    private readonly ILogger<ReverseTextController> _logger;

    /// <summary>
    /// Creates a new instance of <see cref="ReverseTextController"/>.
    /// </summary>
    /// <param name="taskHelper">Injected task helper class.</param>
    /// <param name="logger">The logger.</param>
    public ReverseTextController(TaskHelper taskHelper, ILogger<ReverseTextController> logger)
    {
        _logger = logger;
        _taskHelper = taskHelper;
    }

    /// <summary>
    /// Endpoint that is used to recieve the reversed text.
    /// Endpoint example: http://192.168.0.204:5286/ReverseText
    /// Launch URL is defined in launchSettings.json file.
    /// </summary>
    /// <param name="textDto">DTO that contains text to reverse.</param>
    /// <returns><see cref="ReverseTextDto"/> with reversed text.</returns>
    [HttpPost(Name = "ReverseText")]
    public IActionResult ReverseText([FromBody] ReverseTextDto textDto)
    {
        // If text to reverse is null, returning 400 error.
        if (textDto.Text == null)
        {
            return BadRequest("text cannot be null");
        }

        // Reverse the incoming text.
        var result = _taskHelper.ReverseText(textDto.Text);

        // Returning the new DTO with reversed text.
        return Ok(new ReverseTextDto { Text = result });
    }
}