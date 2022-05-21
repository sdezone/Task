using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServerAspNetCoreWebApplicationMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QoniacController : ControllerBase
    {
        [HttpGet]
        public string CurrencyToWords(string currency)
        {
            QoniacBussinesLayer.QoniacTask qoniac = new();
            return qoniac.CurrencyToWords(currency);
        }
    }
}
