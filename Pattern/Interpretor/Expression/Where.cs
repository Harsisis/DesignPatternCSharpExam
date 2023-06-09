﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.Interpretor.Expression {
    public class Where : IExpression {
        public Predicate<string> Filter { get; set; }
        public Where(Predicate<string> filter) {
            Filter = filter;
        }
        public List<string> Interpret(Context ctx) {
            ctx.Filter = Filter;
            return ctx.Search();
        }
    }
}
