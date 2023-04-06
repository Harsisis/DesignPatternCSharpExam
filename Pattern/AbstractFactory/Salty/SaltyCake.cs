using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Salty {
    public class SaltyCake : Cake {
        public SaltyCake(string color, string toppings) : base(color, toppings) {
            Console.WriteLine("creating salty cake");
        }
    }
}
