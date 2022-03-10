namespace FluentBuilder
{
    class Program
    {
        static void Main()
        {

            /*  Usage without builder        
            Buyer buyer = _buyerRepository.GetById(buyerId);
            Seller seller = _sellerRepository.GetById(sellerId);
            Product product = _productRepository.GetById(productId);

            Order order = new Order(buyer, seller, product, price);
            */



            /* Usage with the builder with static initiation
            Order order = OrderBuilder.Init(_buyerRepository, _sellerRepository)
                          .SetBuyer(buyerId)
                          .SetSeller(sellerId)
                          .Build();



            /* Usage with the builder with a public constructor
            OrderBuilder orderBuilder = new OrderBuilder(buyerRepository,
                                                        sellerRepository);

            Order order = orderBuilder.SetBuyer(buyerId)
                          .SetSeller(sellerId)
                          .Build();
            */



            /*  In those cases, we can create a builder class with multiple methods that are easy to understand their 
             *  function once they are fluent.
            BurgerBuilder burgerBuilder = new BurgerBuilder();
            Burger awesomeburger = burgerBuilder.WithCheese()
                                                .WithBacon()
                                                .Build();
            */
        }
    }
}