using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvc_test.Controllers
{
    public class LocomotiveController : Controller
    {
        private readonly Layout _layout;

        public LocomotiveController(Layout layout)
        {
            _layout = layout;
        }
        // 
        // GET: /Locomotive/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Locomotive/Welcome/ 

        public string Welcome(int id)
        {
            return _layout.GetLocomotive(id).Description;
        }
    }
}