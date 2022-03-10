using FluentBuilder.Models;

namespace FluentBuilder.Interfaces
{
    public interface IBuyerRepository : IRepository<Buyer>
    {
        public Buyer GetByAddress(string adress);
    }
}