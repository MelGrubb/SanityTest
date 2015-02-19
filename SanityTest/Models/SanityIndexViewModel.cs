using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SanityTest.Models
{
    public class SanityIndexViewModel
    {
        [Display(Name = "Choice #1")]
        public string Choice1 { get; set; }

        [Display(Name = "Choice #2")]
        public string Choice2 { get; set; }

        [Display(Name = "Choice #3")]
        public string Choice3 { get; set; }

        [Display(Name = "Choice #4")]
        public string Choice4 { get; set; }

        [Display(Name = "Choice #5")]
        public string Choice5 { get; set; }

        public IEnumerable<SelectListItem> Choices { get; set; }
    }
}