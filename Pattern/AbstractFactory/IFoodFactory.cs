using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System.Collections.Generic;

namespace DesignPatterns.Exam.Pattern.AbstractFactory {
    public interface IFoodFactory {
        public List<Food> Foods { get; set; }
        public Cake Bake(string color, string toppings);
        public Avocado CookAvocado(string color);
        public Melon CookMelon(string color, bool peeled);
        public Cheese CookCheese(string color, string cheeseState);
    }
}
