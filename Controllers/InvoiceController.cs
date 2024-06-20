using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MockApi.Models;
[ApiController]
[Route("api/[controller]")]
public class InvoiceController : ControllerBase
{
    private readonly RequestStorage _requestStorage;

    public InvoiceController(RequestStorage requestStorage)
    {
        _requestStorage = requestStorage;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromQuery] string LoginToken, [FromBody] object request)
    {
        var requestData = $"LoginToken: {LoginToken}, RequestBody: {request.ToString()}";
        await _requestStorage.AddRequestAsync(requestData);

        // Create the response object
        var response = new InvoiceResponse
        {
            Invoice = "IV00000"
        };

        // Return the response as JSON
        return Ok(response);
    }
}