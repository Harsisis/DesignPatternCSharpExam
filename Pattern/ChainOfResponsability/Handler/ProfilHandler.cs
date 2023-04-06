using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Exam.Pattern.ChainOfResponsability.Handler {
    public class ProfilHandler : AbstractHandler {
        public override string Handle(int userId, int projectId) {
            Console.WriteLine("handle profil informations");
            return base.Handle(userId, projectId);
        }
    }
}
