﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole
{
    class StringManipulations
    {
        public void SwapAlternateLettersInStrings(string actual_string)
        {
            string swappedValue="";

            int stringLength = actual_string.Length;

            for (int i=0; i< stringLength; i+=2)
            {
                swappedValue = swappedValue + actual_string[i+1] + actual_string[i];
            }
            Console.WriteLine("Actual Value: {0}", actual_string);
            Console.WriteLine("Swapped Value: {0}", swappedValue);

        }

        public void FindThirdrdLargestNumberFromList(int position)
        {

            List<Product> productDetails = new List<Product> {
                new Product {ProductName ="Iphone11",Price =700 },
                new Product {ProductName ="galaxy S23", Price = 600 },
                new Product {ProductName ="Pixel 4", Price = 800 },
                new Product {ProductName ="Oppo", Price = 400 },

                };

            var items = productDetails.OrderByDescending(e => e.Price);
            var thirdHighestItem = items.ElementAt(position-1);
            Console.WriteLine("The third largest product from the given list " + thirdHighestItem.ProductName + " Price " + thirdHighestItem.Price);
                 
        }

        public void GetRequestedHighestItemusing2Lists(int position)
        {

            List<string> product = new List<string>
            {
                "Iphone11",
                "galaxy S23",
                "Pixel 4",
                "Oppo"
            };

            List<int> productPrice = new List<int>
            {
                700,
                600,
                1000,
                500
            };

            var sortedPrice = productPrice.OrderByDescending(e => e);
            int pos = productPrice.FindIndex(e => e.Equals(sortedPrice.ElementAt(position - 1)));
            string productName = product.ElementAt(pos);
           
            Console.WriteLine($"The {position} largest product from the given list is " + productName + " and its price is " + sortedPrice.ElementAt(position-1));

        }

        public void GetPatternMatch()
        {
            string[] words = { "floor", "flow", "flower", "flaws", "float" };
            string temp = words[0];
            string result = "";
            bool status = false;
            for (int i=0; i<temp.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string itrval = words[j];
                    if (temp[i] == itrval[i])
                        status = true;
                    else
                    {
                        status = false;
                        break;
                    }
                }
                if (status == true)
                    result = result + temp[i];
                else
                    break;
            }
            Console.WriteLine($"Matching Pattern: {result}");
        }

        public void GetStringPattern()
        {
            string[] words = { "floor", "flow", "flower", "flaws", "float" };
            var match = words.Where(e => e.StartsWith("")).Select(e => e).ToList();


        }

    }
    public class Product
    {
        public string ProductName;
        public int Price;
    }

   
}