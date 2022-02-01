using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopRUsApi.Bussines;
using ShopRUsApi.Data;

namespace ShopRUsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        public InvoiceController()
        {
            DataRepository dr = new DataRepository();
            dr.LoadDataListsManually();
        }

        [HttpGet]
        [Route("GetInvoiceAmount")]

        public IActionResult GetInvoiceAmount(int invoiceId)
        {
            var _invoice = DataRepository.invoiceList.FirstOrDefault(i => i.InvoiceId == invoiceId);

            if(_invoice == null)
                return NotFound();

            AmountCalculator amountCalculator = new AmountCalculator();

            return Ok(amountCalculator.calculateInvoiceAmount(invoiceId));
        }
    }
}
