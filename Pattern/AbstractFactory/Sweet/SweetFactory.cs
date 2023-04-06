using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System.Collections.Generic;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Sweet
{
    public class SweetFactory : IFoodFactory {
        public List<Food> Foods { get; set; } = new List<Food>();
        public Cake Bake(string color, string toppings) {
            Cake food = new SweetCake(color, toppings);
            Foods.Add(food);
            return food;
        }
        public Avocado CookAvocado(string color) {
            Avocado food = new SweetAvocado(color);
            Foods.Add(food);
            return food;
        }
        public Cheese CookCheese(string color, string cheeseState) {
            Cheese food = new SweetCheese(color, cheeseState);
            Foods.Add(food);
            return food;
        }
        public Melon CookMelon(string color, bool peeled) {
            Melon food = new SweetMelon(color, peeled);
            Foods.Add(food);
            return food;
        }
    }
}
