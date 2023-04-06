using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Salty {
    public class SaltyFactory : IFoodFactory {
        public List<Food> Foods { get; set; } = new List<Food>();

        public Cake Bake(string color, string toppings) {
            Cake food = new SaltyCake(color, toppings);
            Foods.Add(food);
            return food;
        }
        public Avocado CookAvocado(string color) {
            Avocado food = new SaltyAvocado(color);
            Foods.Add(food);
            return food;
        }
        public Cheese CookCheese(string color, string cheeseState) {
            Cheese food = new SaltyCheese(color, cheeseState);
            Foods.Add(food);
            return food;
        }
        public Melon CookMelon(string color, bool peeled) {
            Melon food = new SaltyMelon(color, peeled);
            Foods.Add(food);
            return food;
        }
    }
}
