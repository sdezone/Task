using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServerAspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QoniacController : ControllerBase
    {
        [HttpGet(Name = "GetCurrencyToWords")]
        public string CurrencyToWords(string currency)
        {
            QoniacBussinesLayer.QoniacTask qoniac = new();
            return qoniac.CurrencyToWords(currency);
        }
    }
}
