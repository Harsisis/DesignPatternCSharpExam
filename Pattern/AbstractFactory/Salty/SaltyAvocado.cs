using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Salty {
    public class SaltyAvocado : Avocado {
        public SaltyAvocado(string color) : base(color) {
            Console.WriteLine("creating salty avocado with olive oil, salt and pepper");
        }
    }
}
