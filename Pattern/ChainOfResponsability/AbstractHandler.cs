using DesignPatterns.Exam.Pattern.ChainOfResponsability.Handler;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.ChainOfResponsability {
    public class AbstractHandler : IHandler {

        public IHandler NextHandler { get; set; }
        public virtual string Handle(int userId, int projectId) {
            if (NextHandler != null) {
                return NextHandler.Handle(userId, projectId);
            }
            Console.WriteLine("no next handler, all informations retrieved");
            return null;
        }

        public IHandler SetNext(IHandler handler) {
            NextHandler = handler;
            return handler;
        }
    }
}
