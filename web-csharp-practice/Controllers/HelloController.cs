using Microsoft.AspNetCore.Mvc;
namespace ProjectName.Controllers;
public class HelloController : Controller
{
    // Route declaration Option A
    // This will go to "localhost:5XXX"
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "Hello from the index";
    }

    // Route declaration Option B
    // This will go to "localhost:5XXX/user/more"
    [HttpGet("user/more")]
    public string User()
    {
        return "Hello user";
    }

    // Post request example
    // This will go to "localhost:5XXX/submission"
    [HttpPost]
    [Route("submission")]
    // Don't worry about what the form is doing for now. We'll get to those soon!
    // Note: You will not be able to navigate to this route! This is for demonstration only!
    public string FormSubmission(string formInput)
    {
        // Logic for post request here
        return "I handled a request!";
    }

    [HttpGet("greet/{name}")]
    public string Greet(string name)
    {
        return $"Hello {name}!";
    }

    [HttpGet("greet/{name}/{time}")]
    // When testing the time input, use only whole numbers
    public string GreetTime(string name, int time)
    {
        return $"Hello {name}! It is currently {time} o'clock!";
    }
}
