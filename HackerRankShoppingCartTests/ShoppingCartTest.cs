using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRankShoppingCartTests
{
    public class FindLowestPriceTest
    {
        private List<List<string>> products = new List<List<string>>();
        private List<List<string>> discounts = new List<List<string>>();

        [Fact]
        public void emptyCartReturnsZero()
        {
            int cartprice = Result.findLowestPrice(products, discounts);
            Assert.Equal(0, cartprice);
        }

        [Fact]
        public void singleItemNoDiscountReturnsValue()
        {
            List<string> product = new List<string>()
            {
                "10",
                "EMPTY",
                "EMPTY"
            };

            products.Add(product);
            int cartprice = Result.findLowestPrice(products, discounts);
            Assert.Equal(10, cartprice);
        }

        [Fact]
        public void twoItemsNoDiscountReturnsTotal()
        {
            List<string> product1 = new List<string>()
            {
                "10",
                "EMPTY",
                "EMPTY"
            };
            List<string> product2 = new List<string>()
            {
                "20",
                "EMPTY",
                "EMPTY"
            };

            products.Add(product1);
            products.Add( product2);
            int cartprice = Result.findLowestPrice(products, discounts);
            Assert.Equal(30, cartprice);

        }





    }

}
