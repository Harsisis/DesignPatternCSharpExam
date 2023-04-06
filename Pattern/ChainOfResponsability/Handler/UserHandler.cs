using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.ChainOfResponsability.Handler {
    internal class UserHandler : AbstractHandler {
        public static List<int> UserIds { get; set; }
        static UserHandler() {
            UserIds = new List<int>();
            UserIds.Add(1);
            UserIds.Add(2);
            UserIds.Add(3);
            UserIds.Add(4);
            UserIds.Add(5);
        }
        public override string Handle(int userId, int projectId) {
            Console.WriteLine("handle user");
            if (!UserIds.Contains(userId)) {
                return ("no user found for id");
            }
            // retrieve a lot of informations blablabla
            return base.Handle(userId, projectId);
        }
    }
}
