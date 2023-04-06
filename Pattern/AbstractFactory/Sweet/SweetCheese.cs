using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Sweet {
    public class SweetCheese : Cheese {
        public SweetCheese(string color, string cheeseState) : base(color, cheeseState) {
            Console.WriteLine("creating a sweet cheese with jam");
        }
    }
}
