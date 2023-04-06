using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Entities {
    public abstract class Food {
        public string Color { get; set; }

        public Food(string color) {
            Color = color;
        }
    }
}
