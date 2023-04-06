using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.AbstractFactory.Entities {
    public class Melon : Food {

        public bool Peeled { get; set; }
        public Melon(string color, bool peeled) : base(color) {
            Peeled = peeled;
        }
    }
}
