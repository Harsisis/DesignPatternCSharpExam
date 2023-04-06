using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Salty {
    public class SaltyMelon : Melon {
        public SaltyMelon(string color, bool peeled) : base(color, peeled) {
            Console.WriteLine("creating salty melon with ham");
        }
    }
}
