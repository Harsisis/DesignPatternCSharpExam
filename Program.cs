using DesignPatterns.Exam.Pattern.AbstractFactory;
using DesignPatterns.Exam.Pattern.AbstractFactory.Salty;
using DesignPatterns.Exam.Pattern.AbstractFactory.Sweet;
using DesignPatterns.Exam.Pattern.ChainOfResponsability.Handler;
using DesignPatterns.Exam.Pattern.Interpretor;
using DesignPatterns.Exam.Pattern.Interpretor.Expression;
using DesignPatterns.Exam.Pattern.Interpretor.Util;
using System;
using System.Collections.Generic;

namespace DesignPatternCSharpExam {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello Gauthier Cadet !");

            Console.WriteLine("\n\n########################## pattern ABSTRACT FACTORY ##########################");
            Console.WriteLine("SaltyFactory");
            IFoodFactory saltyFactory = new SaltyFactory();
            saltyFactory.Bake("yellow", "olives");
            saltyFactory.CookMelon("orange", true);
            saltyFactory.CookAvocado("green");
            saltyFactory.CookCheese("cream", "solid");

            Console.WriteLine("SweetFactory");
            IFoodFactory sweetFactory = new SweetFactory();
            sweetFactory.Bake("yellow", "olives");
            sweetFactory.CookMelon("orange", true);
            sweetFactory.CookAvocado("green");
            sweetFactory.CookCheese("cream", "solid");

            Console.WriteLine("\n\n########################## pattern CHAIN OF RESPONSABILITY ##########################");
            IHandler profilHandler = new ProfilHandler();
            IHandler projectHandler = new ProjectHandler();
            IHandler userHandler = new UserHandler();

            userHandler.SetNext(projectHandler);
            projectHandler.SetNext(profilHandler);

            Console.WriteLine(userHandler.Handle(1, 100) + "\n");// existing user with non existing project
            Console.WriteLine(userHandler.Handle(100, 0) + "\n");// non existing user
            Console.WriteLine(projectHandler.Handle(1, 1) + "\n");// existing user and project

            Console.WriteLine("\n\n########################## pattern INTERPRETOR ##########################");
            Context ctx = new Context();
            Console.WriteLine("\nstart query on : 'numbers' get all rows that contains 1");
            IExpression query = new Select(SelectTypeEnum.ALL, new From("numbers", new Where(row => row.ToLower().Contains("1".ToLower()))));
            List<string> result = query.Interpret(ctx);
            result.ForEach(res => {
                Console.WriteLine(res);
            });

            ctx = new Context();
            Console.WriteLine("\nstart query on : 'numbers' count all rows that contains 2");
            query = new Select(SelectTypeEnum.COUNT, new From("numbers", new Where(row => row.ToLower().Contains("2".ToLower()))));
            result = query.Interpret(ctx);
            result.ForEach(res => {
                Console.WriteLine(res);
            });

            ctx = new Context();
            Console.WriteLine("\nstart query on : 'letters' get all rows that contains A");
            query = new Select(SelectTypeEnum.ALL, new From("letters", new Where(row => row.ToLower().Contains("A".ToLower()))));
            result = query.Interpret(ctx);
            result.ForEach(res => {
                Console.WriteLine(res);
            });
            ctx = new Context();
            Console.WriteLine("\nstart query on : 'letters' count all rows that contains A");
            query = new Select(SelectTypeEnum.COUNT, new From("letters", new Where(row => row.ToLower().Contains("A".ToLower()))));
            result = query.Interpret(ctx);
            result.ForEach(res => {
                Console.WriteLine(res);
            });

        }
    }
}
