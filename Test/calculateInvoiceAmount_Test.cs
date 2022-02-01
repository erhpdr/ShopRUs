using ShopRUsApi.Bussines;
using ShopRUsApi.Data;
using Xunit;

namespace Test
{
    public class calculateInvoiceAmount_Test
    {
        DataRepository dataRepository = new DataRepository();
        
        [Fact]
        public void Invoice1()
        {
            dataRepository.LoadDataListsManually();
            AmountCalculator amountCalculator = new AmountCalculator();
            double result = amountCalculator.calculateInvoiceAmount(1);
            Assert.Equal(45, result);
        }

        [Fact]
        public void Invoice2()
        {
            dataRepository.LoadDataListsManually();
            AmountCalculator amountCalculator = new AmountCalculator();
            double result = amountCalculator.calculateInvoiceAmount(2);
            Assert.Equal(150, result);
        }

        [Fact]
        public void Invoice3()
        {
            dataRepository.LoadDataListsManually();
            AmountCalculator amountCalculator = new AmountCalculator();
            double result = amountCalculator.calculateInvoiceAmount(3);
            Assert.Equal(237.5, result);
        }

        [Fact]
        public void Invoice4()
        {
            dataRepository.LoadDataListsManually();
            AmountCalculator amountCalculator = new AmountCalculator();
            double result = amountCalculator.calculateInvoiceAmount(4);
            Assert.Equal(332.5, result);
        }

        [Fact]
        public void Invoice5()
        {
            dataRepository.LoadDataListsManually();
            AmountCalculator amountCalculator = new AmountCalculator();
            double result = amountCalculator.calculateInvoiceAmount(5);
            Assert.Equal(315, result);
        }

        [Fact]
        public void Invoice6()
        {
            dataRepository.LoadDataListsManually();
            AmountCalculator amountCalculator = new AmountCalculator();
            double result = amountCalculator.calculateInvoiceAmount(6);
            Assert.Equal(385, result);
        }

        [Fact]
        public void Invoice7()
        {
            dataRepository.LoadDataListsManually();
            AmountCalculator amountCalculator = new AmountCalculator();
            double result = amountCalculator.calculateInvoiceAmount(7);
            Assert.Equal(650, result);
        }

        [Fact]
        public void Invoice8()
        {
            dataRepository.LoadDataListsManually();
            AmountCalculator amountCalculator = new AmountCalculator();
            double result = amountCalculator.calculateInvoiceAmount(8);
            Assert.Equal(675, result);
        }

        [Fact]
        public void Invoice9()
        {
            dataRepository.LoadDataListsManually();
            AmountCalculator amountCalculator = new AmountCalculator();
            double result = amountCalculator.calculateInvoiceAmount(9);
            Assert.Equal(765, result);
        }
    }
}