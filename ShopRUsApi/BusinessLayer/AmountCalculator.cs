using ShopRUsApi.Data;
using ShopRUsApi.Models;

namespace ShopRUsApi.Bussines
{
    public class AmountCalculator
    {
        public double calculateInvoiceAmount(int invoiceId)
        {
            var drInvoice = DataRepository.invoiceList.FirstOrDefault(i => i.InvoiceId == invoiceId);

            if(drInvoice == null)   
                return -1;

            var drCustomer = DataRepository.customerList.FirstOrDefault(i => i.CustomerId == drInvoice.CustomerId);

            if(drCustomer == null)
                return -1;

            //(Case No : 5)
            // if invoice items are grocery products dosen't makes discount
            if (drInvoice.ShoppingProductType == "grocery")
            {
                return drInvoice.Amount;
            }

            //(Case No : 2)
            // if customer works for an affiliate company makes %10 discount 
            if (drCustomer.CustomerType == "Affiliate")
            {
                 return Math.Round(drInvoice.Amount * 0.9, 2);
            }

            //(Case No: 1)
            // if custemor is an employee  makes %30 discount 
            if (drCustomer.CustomerType == "Employee" )
            {
                return Math.Round(drInvoice.Amount * 0.7, 2);
            }

            //(Case No : 3)
            // if customer is standard customer for over 2 years makes %5 discount
            if (drCustomer.CustomerType == "Standard" && drCustomer.CustomerInsertDate <= DateTime.Now.AddYears(-2))
            {
                return Math.Round(drInvoice.Amount * 0.95, 2);
            }

            //(Case No : 4)
            // if invoice Amount greater than or equal to 100$ makes %5 discount fom every 100$
            if (drInvoice.Amount >= 100)
            {
                return Math.Round((drInvoice.Amount - (drInvoice.Amount % 100)) * 0.95 + (drInvoice.Amount % 100), 2);
            }

            return drInvoice.Amount;
        }
    
    }
}
