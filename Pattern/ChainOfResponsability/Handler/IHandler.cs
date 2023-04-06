using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.ChainOfResponsability.Handler {
    public interface IHandler {
        IHandler SetNext(IHandler handler);

        string Handle(int userId, int projectId);

    }
}
