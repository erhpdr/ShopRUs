****************************************************
*** ShopRUsApi:class properties and dependencies.***
*** This api calculates discounts and returns    ***
*** calculated amounts of invoices.              ***
*** İt an ASP.NET Core Project			 ***
****************************************************

1.) Controllers (Layer)
   a.) InvoiceController.cs (Main Class)
	- GetInvoiceAmont(int invoiceId) ([HttpGet])
	  This Function returns result of calculateInvoiceAmont(int invoiceID) function with double generic format.
	  calculateInvoiceAmont function belongs to AmountCalculater class int BusinessLayer folder.

2.) BusinessLayer (Layer)
   a.) AmountCalculater.cs (operator Class)
	- CalculateInvoiceAmount(int invoiceId) (operator function)
	  This Function returns calculated amount of invoice using by informations from DataRepository class

3.) Data (Layer)
   a.) DataRepository.cs (data access class)
	- LoadDataListsManuelly() (data access function)
	  This function should have accessed a database. But for this case it loades data manuelly in two object Lists. these are;
          * InvoiceList (Templated by MInvoice Model Class)
          * CustomerList (Templated by MCustomer Model Class)

4.) Models (Layer)
   a.) MCutomer.cs (Model Class) (This class modelling Customer data)
	- CustomerId : int
	- CustomerName : string
	- CustomerSurname : string
	- CustomerInsertDate : datetime
	- CustomerType : string (Customer type can be Standard, Affiliate or Employee)
   b.) MInvoice.cs (Model Class) (This class modelling Invoice data)
	- InvoiceId : int
	- CustomerId : int
	- Amount : double
	- ShopingProductType : string (Shoping product type can be grocery or etc.)

Explanation Note: The Project first accesses constructer InvoiceController and loades invoiceList and customerList data. 
After, it Post default HttpGet function GetInvoiceAmont in InvoiceController class. 
GetInvoiceAmont function calls calculateInvoiceAmount function by invoiceId.
calculateInvoiceAmount calculates amount of invoice by invoiceId, by accessing DataRepository Class for taking invoice and customer data.

****************************************************
*** Test:9 invoice samples are tested in this    ***
*** function. İt a xUnit Test Project		 ***
****************************************************

1.) calculateInvoiceAmount_Test.cs (This function tests the calculated invoice amount)
  a.) Invoice1() - invoiceId = 1 : CustomerType : Affiliate, Amount with discount : 45$
  b.) Invoice2() - invoiceId = 2 : ShopingProductType : grocery dosn't make discount, result : 150$
  c.) Invoice3() - invoiceId = 3 : For over 2 years standard customer : Amount with discount : 237.5$
  d.) Invoice4() - invoiceId = 4 : For over 2 years standard customer : Amount with discount : 332.5$
  e.) Invoice5() - invoiceId = 5 : CustomerType : Employee, Amount with discount : 315$
  f.) Invoice6() - invoiceId = 6 : CustomerType : Employee, Amount with discount : 385$
  g.) Invoice7() - invoiceId = 7 : ShopingProductType : grocery dosn't make discount, result : 650$
  h.) Invoice8() - invoiceId = 8 : CustomerType : Affiliate, Amount with discount : 675$
  i.) Invoice9() - invoiceId = 9 : CustomerType : Affiliate, Amount with discount : 765$
