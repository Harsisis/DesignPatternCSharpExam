using DesignPatterns.Exam.Pattern.Interpretor.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.Interpretor.Expression {
    public class Select : IExpression {

        public SelectTypeEnum SelectType { get; set; }
        public From From { get; set; }
        public Select(SelectTypeEnum selectType, From from) { 
            SelectType = selectType;
            From = from;
        }
        public List<string> Interpret(Context ctx) {
            ctx.Column = SelectType;
            return From.Interpret(ctx);
        }
    }
}
