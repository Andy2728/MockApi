using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    private readonly RequestStorage _requestStorage;

    public LoginController(RequestStorage requestStorage)
    {
        _requestStorage = requestStorage;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromQuery] string UserName, [FromQuery] string Password, [FromQuery] string ApplicationName, [FromQuery] string ApplicationKey)
    {
        var requestData = $"UserName: {UserName}, Password: {Password}, ApplicationName: {ApplicationName}, ApplicationKey: {ApplicationKey}";
        await _requestStorage.AddRequestAsync(requestData);

        // Mock token
        var token = "8E+6t+Mp8mPRRN4RoKE7BI+2NsukhRSp1km3nEdefHyvoNv5x433cHDqVrEFymt93E6YvwWzV8R49wpAcJ9S5Yn+Q+PffnOwwLDYYbvMFNBqJayKI49uIW1uUTiMkCczV29MtbRdNB4eDyvWmoHA8Va0wUtnQ5KBXTcvMAkjt+Bz3lkx7LUxmOa97VD0IpDrtm0atABPB+koCUBIMykTsYnUPYr1rN/SqBCf8ZguRyqfMcnQ2/JEc68L0FjRQOaqNckeCguPiSX0SWfk/cfU6YjvWsxXRPc4G4EdA3YIbXbdvPKYUiZpN0bhyutXy5szFx7vYwJMfvbBj7wZoz737gBGlIHbfLPp305GtW+Jxtszp0JifGeVJ4mtB+vrsK7Cm59dNs1I6HFWmSvPkGP0pf/jgCTZoOjfI+upK/BQW7RACKVJ14S0I/a36+FdckZ/MmC6ZizHuMHcYru9Tn2GYOYecVYpQbFz2omDu9vTgyKspFhUAQSwVUExB1kZXryPFuoj5RCQXawv2BYqPxu6bIKnpq+ybkKXYEnNLWznpgBVEVX9S8JP7snPfpFMGsSiNcxq1x9DytWaFPrWmxEMDt0zjjuoFHPHxRyo/5dLBEW0VKgqOepjg6aKr+FhRL9hp8KjkGz4DwifZVxKFC/EAAkJIo+tLZpqq5ctXbFeq3yEl7zheH8Kk5gw1r59iQ3J7wXWpFSX/o+DQ1gQ1bpcU0lVFvAjoXIhQTxNNS0jP4tQcmtyo0QILZgjD27gM2INkyB6qM3n1vkejgmn4EXHLyi0LcQvcOoa4UyfhBCbmHxbKjq0CKzUzoI4GVcWjorKoThkOAawKj16MbRkLEcUy7qZM3MAM5396qCH1AldRqrm/tvieIfu1heC6X6/KXdExVDiVH/UImDcjqFF6t2pL+YOCmSY74ViwklooVtIiOq/tdGfMKlIdiSyzv/GIyBAF1T7o/8VGHqp8mViV9khasdasduaY4tsxdjVEc2kCgUYhTPUEE+ELPMQVimYXpGAVgT5OegQNKH+l0Raochh3OceWRM9tKzPT7YgR8Jp7Sl8zTPK13+kXgDb96q/E7R7v2hAGcdLZGxMDsBu4D4/vMkOEzoTFu4foIcFEHXOS/t/PC56dapypLTl5XuLZthxo0nhM4pGWp0k8ql38xSeyuYnSsHxhmXqcHEbrjxmPZe3Rvzhadt+APb3RHFRiBxU+tXF6yllT5Kuip9G+EgZ9jko+109eHkjl5WdZ/LTAlgNJJs7E5mwlfGkNXkW1u02k/K3IymtOZsvC3SXIIRK+wzB1Rzam49agAY9fmauhu6+t1cUwspBxcuZ+L3bebfb+pQGgMiV3GkRL7VeBhzHyxgkXGivSFRPwdvia50r7ltdatnPilBPDcyzQheUaR0C4DgaReEoFq1rk5OpcEwFBgYyJ1kWY=";
        return Ok(token);
    }
}
