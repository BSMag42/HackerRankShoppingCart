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



class Result
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

