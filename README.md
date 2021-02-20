# HackerRankShoppingCart
Shopping Cart billing from hankerrank - created own copy to practise TDD

#Kata
A company is having a sale there are 3 types of discount tags:
  * Type 0 : discounted price, the item is sold for given price.
  * Type 1 : percentage discount, the customer is given a fixed percentage discount
  * Type 2 : fixed discount, the customer is given a fixed amount off
  
  #Example
  products =[['10', 'd0', 'd1'], ['15', 'EMPTY', 'EMPTY'], ['20', 'd1', 'EMPTY']]
  discounts = [['d0', '1', '27'], ['d1', '2', '5']]
  
  first product 
    under discount of d0 of type 1 the discounted price = 10 - (10 * 0.27) = 7.3 = round to int = 7
    under discount of d1 type 2 discounted price is 10 - 5 = 5
    discounted price = 5
  second product 
    no discounts available
    discounted price = 15
  third product 
    is priced 20 using discount d1 of type 2 
    discounted price is 20 - 5 = 15
  
  Total cost is 5 + 15 + 15 = 35
