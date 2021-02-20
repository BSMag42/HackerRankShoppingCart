using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



public class Result
{

    /*
     * Complete the 'findLowestPrice' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. 2D_STRING_ARRAY products
     *  2. 2D_STRING_ARRAY discounts
     */

    public static int findLowestPrice(List<List<string>> products, List<List<string>> discounts)
    {
        var result = 0;
        
        foreach (var product in products)
        {
            var price = Convert.ToInt32(product[0]);

            List<int> possiblePrices = new List<int>();
            possiblePrices.Add(price);

            foreach( var discount in discounts)
            {
                var productDiscountCodes = product.GetRange(1, product.Count - 1);
                foreach (var productDiscountCode in productDiscountCodes) 
                {
                    if (productDiscountCode == discount[0])
                    {
                        possiblePrices.Add(GetDiscountAmount(product, discount));
                    }
                }
            }

            result += possiblePrices.Min();

        }
        return result;
    }


    //discount type 0 means sale price in array
    // type 1 means % discount applied to sale price
    //type 2 means discount amount in array from price

    private static int GetDiscountAmount(List<string> product, List<string> discount)
    {
        int discountprice = 0;
        var pricetag = Convert.ToInt32(product[0]);

      
                if(discount[1] == "0")
                {
                    //apply price is sold for price given in discount
                    discountprice = Convert.ToInt32(discount[2]);
                }
                else if (discount[1] == "1")
                {
                    //getpercent
                    var dispercent = Convert.ToInt32(discount[2]);
                    double percentamt = pricetag - (pricetag * dispercent / 100);
                    discountprice = Convert.ToInt32(Math.Round(percentamt));
                }
                else if (discount[1] == "2")
                {
                    //price is less amount noted
                    var discountAmount = Convert.ToInt32(discount[2]);
                    discountprice = pricetag - discountAmount;
                }
           
        return discountprice;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int productsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int productsColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> products = new List<List<string>>();

        for (int i = 0; i < productsRows; i++)
        {
            products.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        int discountsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int discountsColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> discounts = new List<List<string>>();

        for (int i = 0; i < discountsRows; i++)
        {
            discounts.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        int result = Result.findLowestPrice(products, discounts);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


