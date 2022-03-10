namespace FluentBuilder.Models
{
    public class Order
    {
        public Buyer Buyer { get; set; }

        public Seller Seller { get; set; }

        public Product Product { get; set; }

        public double Price { get; set; }

     }
}