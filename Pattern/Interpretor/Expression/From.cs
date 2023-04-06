using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.Interpretor.Expression {
    public class From : IExpression {
        public string Table { get; set; }
        public Where Where { get; set; }
        public From(string table, Where where) { 
            Table = table;
            Where = where;
        }
        public From(string table) { 
            Table = table;
        }
        public List<string> Interpret(Context ctx) {
            ctx.Table = Table;
            if (Where == null) {
                ctx.Search();
            }
            return Where.Interpret(ctx);
        }
    }
}
