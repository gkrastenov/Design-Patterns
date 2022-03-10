using FluentBuilder.Models;

namespace FluentBuilder.Builders
{
    public class BurgerBuilder
    {
        private Burger _burger = new Burger();
        public Burger Build() => _burger;
        public BurgerBuilder WithPatties(int num)
        {
            _burger.NumPatties = num;
            return this;
        }
        public BurgerBuilder WithCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        public BurgerBuilder WithBacon()
        {
            _burger.Bacon = true;
            return this;
        }

        public BurgerBuilder WithPickles()
        {
            _burger.Pickles = true;
            return this;
        }

        public BurgerBuilder WithLetuce()
        {
            _burger.Letuce = true;
            return this;
        }

        public BurgerBuilder WithTomato()
        {
            _burger.Tomato = true;
            return this;
        }
    }
}