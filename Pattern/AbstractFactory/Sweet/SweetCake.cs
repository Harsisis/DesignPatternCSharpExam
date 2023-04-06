using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Sweet {
    public class SweetCake : Cake {
        public SweetCake(string color, string toppings) : base(color, toppings) {
            Console.WriteLine("creating superb a pear and chocolate cake");
        }
    }
}
