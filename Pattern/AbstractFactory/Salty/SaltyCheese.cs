using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Salty {
    public class SaltyCheese : Cheese {
        public SaltyCheese(string color, string cheeseState) : base(color, cheeseState) {
            Console.WriteLine("creating a salty cheese !");
        }
    }
}
