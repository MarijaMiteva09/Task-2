using Xunit;
using ReverseTextApi.Controllers;
using ReverseTextApi.Models;
using Microsoft.AspNetCore.Mvc;

public class ReverseLogicTests
{
    [Fact]
    public void ReversesTextCorrectly()
    {
        var controller = new ReverseController();

        var input = new ReverseRequest { Text = "hello" };
        var result = controller.Post(input) as OkObjectResult;

        Assert.NotNull(result);
        var response = result.Value as ReverseResponse;
        Assert.Equal("olleh", response.ReversedText);
    }

    [Fact]
    public void ReturnsBadRequestForEmptyText()
    {
        var controller = new ReverseController();

        var input = new ReverseRequest { Text = "" };
        var result = controller.Post(input) as BadRequestObjectResult;

        Assert.NotNull(result);
        Assert.Equal(400, result.StatusCode);
    }
}
