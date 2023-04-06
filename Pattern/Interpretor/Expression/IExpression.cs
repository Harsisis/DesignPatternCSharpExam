using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.Interpretor.Expression {
    public interface IExpression {

        public List<string> Interpret(Context ctx);
    }
}
