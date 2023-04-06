using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.ChainOfResponsability.Handler {
    public class ProjectHandler : AbstractHandler {
        public static List<int> ProjectIds { get; set; }
        static ProjectHandler() {
            ProjectIds = new List<int>();
            ProjectIds.Add(1);
            ProjectIds.Add(2);
            ProjectIds.Add(3);
            ProjectIds.Add(4);
            ProjectIds.Add(5);
        }
        public override string Handle(int userId, int projectId) {
            Console.WriteLine("handle project");
            if (!ProjectIds.Contains(projectId)) {
                return ("no project found for id");
            }
            // retrieve a lot of informations blablabla
            return base.Handle(userId, projectId);
        }
    }
}
