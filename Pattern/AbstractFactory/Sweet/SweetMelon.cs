using DesignPatterns.Exam.Pattern.AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Sweet {
    public class SweetMelon : Melon {
        public SweetMelon(string color, bool peeled) : base(color, peeled) {
            Console.WriteLine("creating sweet melon");
        }
    }
}
