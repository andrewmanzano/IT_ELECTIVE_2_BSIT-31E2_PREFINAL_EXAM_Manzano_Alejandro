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
                }
            };
            return View(questions);
        }
    }
}
