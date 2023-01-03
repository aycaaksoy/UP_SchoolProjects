using CQRS.CQRS.Commands.StudentCommands;
using CQRS.CQRS.Handlers.StudentHandlers;
using CQRS.CQRS.Queries.StudentQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    public class StudentController : Controller
    {
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly GetAllStudentQueryHandler _getAllStudentQueryHandler;
        private readonly RemoveStudentCommandHandler _removeStudentCommandHandler;
        private readonly GetStudentByIDQueryHandler _getStudentByIDQueryHandler;
        private readonly UpdateStudentCommandHandler _updateStudentCommandHandler;


        public StudentController(CreateStudentCommandHandler createStudentCommandHandler, GetAllStudentQueryHandler getAllStudentQueryHandler, RemoveStudentCommandHandler removeStudentCommandHandler, GetStudentByIDQueryHandler getStudentByIDQueryHandler, UpdateStudentCommandHandler updateStudentCommandHandler)
        {
            _createStudentCommandHandler = createStudentCommandHandler;
            _getAllStudentQueryHandler = getAllStudentQueryHandler;
            _removeStudentCommandHandler = removeStudentCommandHandler;
            _getStudentByIDQueryHandler = getStudentByIDQueryHandler;
            _updateStudentCommandHandler = updateStudentCommandHandler;
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(CreateStudentCommand command)
        {
            _createStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var values = _getAllStudentQueryHandler.Handle();
            return View(values);
        }
        public IActionResult DeleteStudent(int id)
        {
            _removeStudentCommandHandler.Handle(new RemoveStudentCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var values = _getStudentByIDQueryHandler.Handle(new GetStudentByIDQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateStudent(UpdateStudentCommand command)
        {
            _updateStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
