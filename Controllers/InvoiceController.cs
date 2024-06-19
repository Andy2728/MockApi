using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]
public class InvoiceController : ControllerBase
{
    private readonly RequestStorage _requestStorage;

    public InvoiceController(RequestStorage requestStorage)
    {
        _requestStorage = requestStorage;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] object request)
    {
        var requestData = request.ToString();
        await _requestStorage.AddRequestAsync(requestData);
        return Ok();
    }
}