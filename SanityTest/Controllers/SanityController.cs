using SanityTest.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SanityTest.Controllers
{
    public class SanityController : Controller
    {
        // GET: Sanity
        public ViewResult Index()
        {
            var choices = new List<SelectListItem>
            {
                new SelectListItem {Text = "Select", Value = ""},
                new SelectListItem {Text = "Value 1", Value = "1"},
                new SelectListItem {Text = "Value 2", Value = "2"},
                new SelectListItem {Text = "Value 3", Value = "3"},
                new SelectListItem {Text = "Value 4", Value = "4"}
            };

            var model = new SanityIndexViewModel
            {
                Choice1 = null,
                Choice2 = "1",
                Choice3 = null,
                Choice4 = "2",
                Choice5 = null,
                Choices = choices
            };

            return View(model);
        }
    }
}