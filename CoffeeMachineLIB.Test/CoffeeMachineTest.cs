using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CoffeeMachineLIB.Test
{
    [TestClass]
    public class CoffeeMachineTest
    {
        [TestMethod]
        public void GetInfoCoins_CorrectSum_45()
        {
            CoffeeMachine machine = new CoffeeMachine(new List<int> { 5, 10, 10, 20 });
            string result = machine.GetInfoCoins();
            string expectedRes = "Total sum: 45";
            Assert.AreEqual(expectedRes, result);

        }

        [TestMethod]
        public void GetInfoProducts_CorrectProducts_SnickersANDJuiceANDCarrots()
        {
            CoffeeMachine machine = new CoffeeMachine(new List<int> { 5, 10, 10, 20 });
            machine.ListOfProducts.Add("Late", 30);
            machine.ListOfProducts.Add("Americano", 50);
            machine.ListOfProducts.Add("Expresso", 40);
            string result = machine.GetInfoProducts();
            string expectedRes = "Product: Late, Price: 30; Product: Americano, Price: 50; Product: Expresso, Price: 40; ";
            Assert.AreEqual(expectedRes, result);

        }
        [TestMethod]
        public void GetProduct_ProductExistsANDSufficientFunds_change5()
        {
            CoffeeMachine machine = new CoffeeMachine(new List<int> { 15, 10, 10, 20 });
            machine.ListOfProducts.Add("Late", 30);
            machine.ListOfProducts.Add("Americano", 50);
            machine.ListOfProducts.Add("Expresso", 40);
            string expectedRes = "Bought \nHere is your change: 5";
            string result = machine.GetProduct("Americano");
            Assert.AreEqual(expectedRes, result);

        }
        [TestMethod]
        public void GetProduct_ProductDoesNotExistsANDSufficientFunds_DoesNotExist()
        {
            CoffeeMachine machine = new CoffeeMachine(new List<int> { 15, 10, 10, 20 });
            machine.ListOfProducts.Add("Late", 30);
            machine.ListOfProducts.Add("Americano", 50);
            machine.ListOfProducts.Add("Expresso", 40);
            string expectedRes = "Such product does not exist";
            string result = machine.GetProduct("PeperCoffee");
            Assert.AreEqual(expectedRes, result);
        }

        [TestMethod]
        public void GetProduct_ProductExistsANDInsufficientFunds_InsufficientFunds()
        {
            CoffeeMachine machine = new CoffeeMachine(new List<int> {10, 20 });
            machine.ListOfProducts.Add("Late", 30);
            machine.ListOfProducts.Add("Americano", 50);
            machine.ListOfProducts.Add("Expresso", 40);
            string expectedRes = "Insufficient funds";
            string result = machine.GetProduct("Expresso");
            Assert.AreEqual(expectedRes, result);
        }


        //machine.GetProduct("Snickers");
    }
}