using Microsoft.AspNetCore.Mvc;
using BSIT_32E2_Elective_2_Assignment_1.Models;

namespace BSIT_32E2_Elective_2_Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<QuizQuestion> _questions = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Number = 1,
                QuestionText = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
                Options = new Dictionary<string, string>
                {
                    { "A", "SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server." },
                    { "B", "SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON." },
                    { "C", "SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers." },
                    { "D", "SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server." }
                },
                CorrectOptionKey = "B",
                Explanation = "SSR/MVC renders HTML on the server and sends full markup to the client, whereas a Web API serves raw data (typically JSON) to any consumer."
            },
            new QuizQuestion
            {
                Number = 2,
                QuestionText = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
                Options = new Dictionary<string, string>
                {
                    { "A", "ControllerBase supports Razor View rendering using View() and ViewData." },
                    { "B", "ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead." },
                    { "C", "Controller is obsolete in .NET and cannot handle HTTP POST requests." },
                    { "D", "ControllerBase automatically creates SQLite database files on application startup." }
                },
                CorrectOptionKey = "B",
                Explanation = "ControllerBase provides HTTP request routing, model binding, and helpers without the view-rendering features found in Controller."
            },
            new QuizQuestion
            {
                Number = 3,
                QuestionText = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
                Options = new Dictionary<string, string>
                {
                    { "A", "[Route]" },
                    { "B", "[HttpGet]" },
                    { "C", "[ApiController]" },
                    { "D", "[FromQuery]" }
                },
                CorrectOptionKey = "C",
                Explanation = "The [ApiController] attribute enables automatic model state validation and returns HTTP 400 responses when validation fails."
            },
            new QuizQuestion
            {
                Number = 4,
                QuestionText = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
                Options = new Dictionary<string, string>
                {
                    { "A", "200 OK" },
                    { "B", "201 Created" },
                    { "C", "204 No Content" },
                    { "D", "404 Not Found" }
                },
                CorrectOptionKey = "B",
                Explanation = "201 Created is the standard REST status code confirming resource creation, typically accompanied by a Location header."
            },
            new QuizQuestion
            {
                Number = 5,
                QuestionText = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
                Options = new Dictionary<string, string>
                {
                    { "A", "200 OK" },
                    { "B", "201 Created" },
                    { "C", "204 No Content" },
                    { "D", "400 Bad Request" }
                },
                CorrectOptionKey = "C",
                Explanation = "204 No Content indicates that the action was successful and the response body contains no further data."
            },
            new QuizQuestion
            {
                Number = 6,
                QuestionText = "Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?",
                Options = new Dictionary<string, string>
                {
                    { "A", "GET /api/getAllCourses" },
                    { "B", "GET /api/courses" },
                    { "C", "POST /api/createNewCourseRecord" },
                    { "D", "POST /api/deleteCourseById?id=5" }
                },
                CorrectOptionKey = "B",
                Explanation = "RESTful best practices dictate using plural nouns for resource collections (e.g., /api/courses) and letting HTTP verbs handle the actions."
            },
            new QuizQuestion
            {
                Number = 7,
                QuestionText = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
                Options = new Dictionary<string, string>
                {
                    { "A", "It connects the controller directly to an Entity Framework database context." },
                    { "B", "It maps incoming URI request paths to the controller class using the class name token." },
                    { "C", "It encrypts all incoming JSON payloads." },
                    { "D", "It enables Cross-Origin Resource Sharing (CORS) for external React apps." }
                },
                CorrectOptionKey = "B",
                Explanation = "The [controller] token dynamically replaces itself with the controller name minus the 'Controller' suffix during routing."
            },
            new QuizQuestion
            {
                Number = 8,
                QuestionText = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
                Options = new Dictionary<string, string>
                {
                    { "A", "POST" },
                    { "B", "PUT" },
                    { "C", "GET" },
                    { "D", "DELETE" }
                },
                CorrectOptionKey = "C",
                Explanation = "GET is both safe (no server modifications) and idempotent (multiple identical requests yield identical effects)."
            },
            new QuizQuestion
            {
                Number = 9,
                QuestionText = "In ASP.NET Core Web API, what wrapper type allows action methods to return either a strongly typed domain object or standard HTTP status result helpers (such as Ok(), NotFound())?",
                Options = new Dictionary<string, string>
                {
                    { "A", "Task<ActionResult<T>> / ActionResult<T>" },
                    { "B", "ViewResult<T>" },
                    { "C", "JsonResult<T>" },
                    { "D", "ContentResult<T>" }
                },
                CorrectOptionKey = "A",
                Explanation = "ActionResult<T> allows developers to return either an instance of type T directly or an ActionResult status response helper."
            }
        };

        // Home Landing Page
        public IActionResult Index()
        {
            return View();
        }

        // Assignment Questions Page
        public IActionResult Assignment()
        {
            return View(_questions);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}