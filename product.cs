using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBChallenge
{
    public class product 
    {
        public string name;
        public int price;
        public int weight;

        public product() { }
        public product(string n,int p,int w)
        {
            this.name = n;
            this.price = p;
            this.weight = w;
        }

        public bool inputValidator(string[] name, int[] price, int[] weight)
        {
            if (name == null || price == null || weight == null)
                return false;
            if (name.Length == 0 || price.Length == 0 || weight.Length == 0)
                return false;
            if (price.Length != name.Length || weight.Length != name.Length)
                return false;
            if (name.Length < 1 || name.Length > Math.Pow(10, 5))
                return false;
            else
            { 
                foreach (string s in name)
                {
                    if (string.IsNullOrEmpty(s) || s.Length > 10 || s.Any(char.IsUpper))
                        return false;
                }
                for(int i=0;i<price.Length;i++)
                {
                    if (price[i] < 1 || price[i] > 1000)
                        return false;
                }

                for (int j = 0; j < weight.Length; j++)
                {
                    if (weight[j] < 1 || weight[j] > 1000)
                        return false;
                }
            }
            return true;
            
        }

        public List<product> getproducts(string[] name,int[] price,int[] weight)
        {
            if(inputValidator(name,price, weight))
            { 
                    List<product> productsList = new List<product>();

                    for (int i = 0; i < name.Length; i++)
                    {
                        productsList.Add(new product(name[i], price[i], weight[i]));
                    }
                    return productsList;
            }
           
            return null;
        }

        public int numDuplicates(string[] name, int[] price, int[] weight)
        {
            if (inputValidator(name, price, weight))
            {
                List<product> productsList = getproducts(name, price, weight);
                productComparer pc = new productComparer();

                HashSet<product> uniqueProducts = new HashSet<product>(pc);
                int countOfDuplicateProducts = 0;

              
                for (int i = 0; i < productsList.Count; i++)
                {
                    if (uniqueProducts.Contains(productsList[i]))
                        continue;
                    else
                    {
                        uniqueProducts.Add(productsList[i]);
                        for (int j = i + 1; j < productsList.Count; j++)
                        {

                            if (pc.Equals(productsList[i], productsList[j]))
                            {
                                countOfDuplicateProducts++;
                            }

                        }
                    }

                }

                return countOfDuplicateProducts;
            }
            else
                return -1;

        }

            
    }
}
