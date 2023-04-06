using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Sweet {
    public class SweetAvocado : Avocado {
        public SweetAvocado(string color) : base(color) {
            Console.WriteLine("creating a sweet avocado, idk maybe with honey ?");
        }
    }
}
