using System;

namespace CoffeeMachineLIB // Note: actual namespace depends on the project name.
{
    public class CoffeeMachine
    {
        private List<int> _coins = new List<int>();
        public CoffeeMachine(List<int> coins)
        {
            _coins = coins;
        }
        public string GetInfoCoins()
        {
            Console.WriteLine("Such coins were inserted:");
            string str = String.Format("Total sum: {0}", _coins.Sum());
            return str;


        }

        public IDictionary<string, int> ListOfProducts = new Dictionary<string, int>();

        public string GetInfoProducts()
        {
            string output = "";
            foreach (KeyValuePair<string, int> kvp in ListOfProducts)
                output+= String.Format("Product: {0}, Price: {1}; ", kvp.Key, kvp.Value);
            return output;
        }

        public string GetProduct(string product)
        {
            if (ListOfProducts.ContainsKey(product) )
            {
                if (_coins.Sum() >= ListOfProducts[product])
                {
                    string output = String.Format("Bought \nHere is your change: {0}", _coins.Sum() - ListOfProducts[product]);                   return output;
                }else { return "Insufficient funds"; }
            }
            else return "Such product does not exist";
        }



    }
}