using Microsoft.AspNetCore.Mvc;

namespace GHLearning.EasyNLog.AppElasticsearch.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoggersController(ILogger<LoggersController> logger) : ControllerBase
{
	[HttpGet("Error")]
	public Task LogErrorAsync()
	{
		logger.LogError("This is an error message");
		return Task.CompletedTask;
	}

	[HttpGet("Info")]
	public Task LogInformationAsync()
	{
		logger.LogInformation("This is an info message");
		return Task.CompletedTask;
	}

	[HttpGet("Warning")]
	public Task LogWarningAsync()
	{
		logger.LogWarning("This is a warning message");
		return Task.CompletedTask;
	}

	[HttpGet("Debug")]
	public Task LogDebugAsync()
	{
		logger.LogDebug("This is a debug message");
		return Task.CompletedTask;
	}

	[HttpGet]
	public Task LogAsync()
	{
		logger.LogTrace("This is a trace message");
		try
		{
			logger.LogWarning("This is a warning message");

			throw new Exception("An error occurred while logging");
		}
		catch (Exception ex)
		{
			logger.LogError(ex, "An error occurred while logging");
		}
		finally
		{
			logger.LogInformation("Logging completed");
		}

		return Task.CompletedTask;
	}
}
