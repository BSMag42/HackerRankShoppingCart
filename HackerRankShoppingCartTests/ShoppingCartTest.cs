using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRankShoppingCartTests
{
    public class FindLowestPriceTest
    {
        private List<List<string>> products = new List<List<string>>();
        private List<List<string>> discounts = new List<List<string>>();
        private List<string> productWithNoDiscounts = new List<string>()
        {
            "10",
            "EMPTY",
            "EMPTY"
        };
        private List<string> productWithPercentageAndFixedPriceDiscount = new List<string>()
        {
            "10",
            "sale",
            "january-sale"
        };

        private List<string> productWithFixedPriceDiscount = new List<string>()
        {
            "200",
            "sale",
            "EMPTY"
        };

        private List<string> productWithFixedAmountDiscount = new List<string>()
        {
            "200",
            "fixedAmount",
            "EMPTY"
        };

        private List<string> fixedPriceDiscount = new List<string>()
        {
            "sale",
            "0",
            "10"
        };
        private List<string> percentageDiscount = new List<string>()
        {
            "january-sale",
            "1",
            "10"
        };
        private List<string> fixedAmountDiscount = new List<string>()
        {
            "fixedAmount",
            "2",
            "100"
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
            products.Add(productWithNoDiscounts);
            int cartprice = Result.findLowestPrice(products, discounts);
            Assert.Equal(10, cartprice);
        }

        [Fact]
        public void twoItemsNoDiscountReturnsTotal()
        {
            products.Add(productWithNoDiscounts);
            products.Add(productWithNoDiscounts);
            int cartprice = Result.findLowestPrice(products, discounts);
            Assert.Equal(20, cartprice);
        }

        [Fact]
        public void itemWithFixedDiscountApplied()
        {
            products.Add(productWithFixedAmountDiscount);
            discounts.Add(fixedAmountDiscount);
            int cartprice = Result.findLowestPrice(products, discounts);
            Assert.Equal(100, cartprice);

        }

        [Fact]
        public void givenTwoDiscountsApplyLowest()
        {
            products.Add(productWithPercentageAndFixedPriceDiscount);
            products.Add(productWithFixedPriceDiscount);
            discounts.Add(fixedPriceDiscount);
            discounts.Add(percentageDiscount);

            int cartprice = Result.findLowestPrice(products, discounts);
            Assert.Equal(19, cartprice);
        }
    }

}
