using FluentBuilder.Models;

namespace FluentBuilder.Interfaces
{
    public interface ISellerRepository : IRepository<Seller>
    {
        public bool HaveMoreOneHundredSales();
    }
}