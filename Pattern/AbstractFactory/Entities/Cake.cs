using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Entities {
    public class Cake : Food {

        public string Toppings { get; set; }
        public Cake(string color, string toppings) : base(color) {
            Toppings = toppings;
        }
    }
}
