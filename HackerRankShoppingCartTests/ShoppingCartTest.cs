using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRankShoppingCartTests
{
    public class FindLowestPriceTest
    {
        private List<List<string>> products = new List<List<string>>();
        private List<List<string>> discounts = new List<List<string>>();
        private List<string> product1 = new List<string>()
        {
                "10",
                "EMPTY",
                "EMPTY"
        };
        private List<string> product2 = new List<string>()
        {
            "20",
            "EMPTY",
            "EMPTY"
        };

        [Fact]
        public void emptyCartReturnsZero()
        {
            int cartprice = Result.findLowestPrice(products, discounts);
            Assert.Equal(0, cartprice);
        }

        [Fact]
        public void singleItemNoDiscountReturnsValue()
        {
            products.Add(product1);
            int cartprice = Result.findLowestPrice(products, discounts);
            Assert.Equal(10, cartprice);
        }

        [Fact]
        public void twoItemsNoDiscountReturnsTotal()
        {
            products.Add(product1);
            products.Add( product2);
            int cartprice = Result.findLowestPrice(products, discounts);
            Assert.Equal(30, cartprice);
        }
    }

}
