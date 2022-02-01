using ShopRUsApi.Models;

namespace ShopRUsApi.Data
{
    public class DataRepository
    {

        public static List<MCustomer> customerList = new List<MCustomer>();
        public static List<MInvoice> invoiceList = new List<MInvoice>();

        public void LoadDataListsManually()
        {
            customerList.Add(new MCustomer { CustomerId = 1, CustomerName = "ERHAN", CustomerSurname = "PADİR",  CustomerType = "Affiliate", CustomerInsertDate = Convert.ToDateTime("2020-01-01 00:00:00.000") });
            customerList.Add(new MCustomer { CustomerId = 2, CustomerName = "AHMET", CustomerSurname = "KARAL",  CustomerType = "Standard",  CustomerInsertDate = Convert.ToDateTime("2017-02-03 00:00:00.000") });
            customerList.Add(new MCustomer { CustomerId = 3, CustomerName = "VELİ",  CustomerSurname = "CENGİZ", CustomerType = "Standard",  CustomerInsertDate = Convert.ToDateTime("2018-03-04 00:00:00.000") });
            customerList.Add(new MCustomer { CustomerId = 4, CustomerName = "KAZIM", CustomerSurname = "ÜNALAN", CustomerType = "Standard",  CustomerInsertDate = Convert.ToDateTime("2019-04-05 00:00:00.000") });
            customerList.Add(new MCustomer { CustomerId = 5, CustomerName = "NİMET", CustomerSurname = "DEMİR",  CustomerType = "Employee",  CustomerInsertDate = Convert.ToDateTime("2016-01-06 00:00:00.000") });
            customerList.Add(new MCustomer { CustomerId = 6, CustomerName = "HATİCE",CustomerSurname = "ÖĞÜT",   CustomerType = "Employee",  CustomerInsertDate = Convert.ToDateTime("2015-02-08 00:00:00.000") });
            customerList.Add(new MCustomer { CustomerId = 7, CustomerName = "ERDİNÇ",CustomerSurname = "ÜSTÜN",  CustomerType = "Standard",  CustomerInsertDate = Convert.ToDateTime("2018-03-01 00:00:00.000") });
            customerList.Add(new MCustomer { CustomerId = 8, CustomerName = "EMRE",  CustomerSurname = "PADİR",  CustomerType = "Affiliate", CustomerInsertDate = Convert.ToDateTime("2022-01-02 00:00:00.000") });
            customerList.Add(new MCustomer { CustomerId = 9, CustomerName = "KÜBRA", CustomerSurname = "PADİR",  CustomerType = "Affiliate", CustomerInsertDate = Convert.ToDateTime("2021-02-03 00:00:00.000") });

            invoiceList.Add(new MInvoice { InvoiceId = 1, CustomerId = 1, Amount = 50,  ShoppingProductType = "textile"    }); // CustomerType : Affiliate, Amount with discount : 45$
            invoiceList.Add(new MInvoice { InvoiceId = 2, CustomerId = 2, Amount = 150, ShoppingProductType = "grocery"    }); // ShopingProductType : grocery dosn't make discount, result : 150$
            invoiceList.Add(new MInvoice { InvoiceId = 3, CustomerId = 3, Amount = 250, ShoppingProductType = "technology" }); // For over 2 years standard customer : Amount with discount : 237.5$
            invoiceList.Add(new MInvoice { InvoiceId = 4, CustomerId = 4, Amount = 350, ShoppingProductType = "technology" }); // For over 2 years standard customer : Amount with discount : 332.5$
            invoiceList.Add(new MInvoice { InvoiceId = 5, CustomerId = 5, Amount = 450, ShoppingProductType = "textile"    }); // CustomerType : Employee, Amount with discount : 315$
            invoiceList.Add(new MInvoice { InvoiceId = 6, CustomerId = 6, Amount = 550, ShoppingProductType = "textile"    }); // CustomerType : Employee, Amount with discount : 385$
            invoiceList.Add(new MInvoice { InvoiceId = 7, CustomerId = 7, Amount = 650, ShoppingProductType = "grocery"    }); // ShopingProductType : grocery dosn't make discount, result : 650$
            invoiceList.Add(new MInvoice { InvoiceId = 8, CustomerId = 8, Amount = 750, ShoppingProductType = "textile"    }); // CustomerType : Affiliate, Amount with discount : 675$
            invoiceList.Add(new MInvoice { InvoiceId = 9, CustomerId = 9, Amount = 850, ShoppingProductType = "technology" }); // CustomerType : Affiliate, Amount with discount : 765$

        }


    }
}
