using Manzano_Exam.Models;
using Microsoft.AspNetCore.Mvc;

namespace Manzano_Exam.Controllers
{
    public class QuestionController : Controller
    {
        public ActionResult Index()
        {
            var questions = new List<Question>
            {
                new Question
                {
                    Number = 1,
                    Text = "What is the main problem solved by using a database instead of an in-memory collection?",
                    ChoiceA = "It makes C# code shorter",
                    ChoiceB = "It prevents the application from restarting",
                    ChoiceC = "It allows data to persist after the application stops",
                    ChoiceD = "It removes the need for MVC",
                    Answer = "C"
                },

                new Question
                {
                    Number = 2,
                    Text = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    ChoiceA = "Code-First",
                    ChoiceB = "Database-First",
                    ChoiceC = "Model-First",
                    ChoiceD = "Controller-First",
                    Answer = "B"
                },

                new Question
                {
                    Number = 3,
                    Text = "What is the primary purpose of Entity Framework Core?",
                    ChoiceA = "To create HTML pages automatically",
                    ChoiceB = "To replace the MVC Controller",
                    ChoiceC = "To map objects in code to relational database data",
                    ChoiceD = "To replace the C# compiler",
                    Answer = "C"
                },
            };
            return View(questions);
        }
    }
}
