using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Entities {
    public class Cheese : Food {

        public string CheeseState { get; set; }
        public Cheese(string color, string cheeseState) : base(color) {
            CheeseState = cheeseState;
        }
    }
}
