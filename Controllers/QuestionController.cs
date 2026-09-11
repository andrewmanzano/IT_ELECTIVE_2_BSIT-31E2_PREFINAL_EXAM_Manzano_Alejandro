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

                new Question
                {
                    Number = 4,
                    Text = "Which EF Core component is primarily responsible for communicating with the database?",
                    ChoiceA = "DbContext",
                    ChoiceB = "DbSerView",
                    ChoiceC = "ControllerContext",
                    ChoiceD = "RazorContext",
                    Answer = "A"
                },

                new Question
                {
                    Number = 5,
                    Text = "What does the following command primarily do?\r\n\r\ndotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models\r\n",
                    ChoiceA = "Deletes the database",
                    ChoiceB = "Creates a new MVC Project",
                    ChoiceC = "Generates EF Core models and a DbContext from an existing database",
                    ChoiceD = "Starts the MVC Application",
                    Answer = "C"
                },

                new Question
                {
                    Number= 6,
                    Text = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    ChoiceA = " Program.cs only",
                    ChoiceB = "appsettings json",
                    ChoiceC = "Index.cshtml",
                    ChoiceD = "Student.cs",
                    Answer = "B"
                },

                new Question
                {
                    Number= 7,
                    Text = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    ChoiceA = "one-to-one",
                    ChoiceB = "One-to-Many",
                    ChoiceC = "Many-to-Many",
                    ChoiceD = "Many-to-One only",
                    Answer = "B"
                },

                new Question
                {
                    Number= 8,
                    Text = "In the following example, what is SectionId?\r\n\r\npublic int SectionId { get; set; }\r\npublic Section Section { get; set; }\r\n",
                    ChoiceA = "Primary key of Student",
                    ChoiceB = "Foreign key referencing Section",
                    ChoiceC = "Navigation Property",
                    ChoiceD = "Database connection String",
                    Answer = "B"
                },

                new Question
                {
                    Number= 9,
                    Text = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    ChoiceA = "It stores the database password",
                    ChoiceB = "It represents a relationship to another entity",
                    ChoiceC = "It creates a new database",
                    ChoiceD = "It validates the student's name",
                    Answer = "B"
                },

                new Question
                {
                    Number= 10,
                    Text = "What does .Include() generally allow EF Core to do?",
                    ChoiceA = "Delete the section table",
                    ChoiceB = "Load related section data together with Stidents",
                    ChoiceC = "Create a new Student",
                    ChoiceD = "Validate student input",
                    Answer = "B"
                },

                new Question
                {
                    Number= 11,
                    Text = "WHy might a ViewModel be used when displaying Student and section information?",
                    ChoiceA = "To repalce the database",
                    ChoiceB = "To combine or shape the data specifically needed by the view",
                    ChoiceC = "To Automatically create database tables",
                    ChoiceD = "To prevent controllers from using LINQ",
                    Answer = "B"
                },

                new Question
                {
                    Number= 12,
                    Text = "Consider this query:\r\n\r\nvar students = _context.Students.Include(s => s.Section).ToList();\r\n\r\nWhat is the main benefit of Include(s => s.Section)?\r\n",
                    ChoiceA = "It loads the related section navigation property",
                    ChoiceB = "It creates the foreign key",
                    ChoiceC = "It removes the foreign key",
                    ChoiceD = " It prevents the query from accessing the database",
                    Answer = "A"
                },

                new Question
                {
                    Number= 13,
                    Text = "Whice type of validation occurs in the browser before a request is sent to the server?",
                    ChoiceA = "Database-level-validation",
                    ChoiceB = "Client-side-validation",
                    ChoiceC = "Server-side-validation",
                    ChoiceD = "EF Core migration validation",
                    Answer = "B"
                },

                new Question
                {
                    Number= 14,
                    Text = "Why is server side validation still necessary if client side validation exist?",
                    ChoiceA = "Clint side validation can be bypassed",
                    ChoiceB = "Client side validation automatically modifies the database",
                    ChoiceC = "Server side validaiton only works with SQLite",
                    ChoiceD = "Client side validation cannot display messages",
                    Answer = "A"
                },

                new Question
                {
                    Number= 15,
                    Text = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                    ChoiceA = "Student Number should always be nullable",
                    ChoiceB = "Student Number should be unique",
                    ChoiceC = "Student Number should always be the same",
                    ChoiceD = "Student Number should contain only spaces",
                    Answer = "B"
                },

                new Question
                {
                    Number= 16,
                    Text = "Which is the best reason for having a database level unique constraint on StudentNumber?",
                    ChoiceA = "It protects data integrity even if application level validation is bypassed",
                    ChoiceB = "It makes Razor Views Render Faster",
                    ChoiceC = "It removes the need for controllers",
                    ChoiceD = "It automatically creates a ViewModel",
                    Answer = "A"
                },

                new Question
                {
                    Number= 17,
                    Text = "What is the purpose of a try...catch block in a controller?",
                    ChoiceA = "To create navaigation properties",
                    ChoiceB = "To catch and handle exceptions that may occur during execution",
                    ChoiceC = "To generate database tables",
                    ChoiceD = "To perform client-side validation",
                    Answer = "B"
                },

                new Question
                {
                    Number= 18,
                    Text = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                    ChoiceA = "UsdeDatabase()",
                    ChoiceB = "UseExceptionHandler()",
                    ChoiceC = "UseValidationHandler()",
                    ChoiceD = "UseMvcDatabase()",
                    Answer = "B"
                },

                new Question
                {
                    Number= 19,
                    Text = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
                    ChoiceA = "Display the student's information anyway",
                    ChoiceB = "Display a Not Found (404) response/page",
                    ChoiceC = "Delete student 999",
                    ChoiceD = "Create student 999 automatically",
                    Answer = "B"
                }

            };
            return View(questions);
        }
    }
}
