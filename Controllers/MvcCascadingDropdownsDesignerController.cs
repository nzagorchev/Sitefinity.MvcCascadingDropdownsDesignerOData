using SitefinityWebApp.Mvc.Models;
using System;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "MvcCascadingDropdownsDesigner", Title = "MvcCascadingDropdownsDesigner", SectionName = "MvcWidgets")]
    public class MvcCascadingDropdownsDesignerController : Controller
    {
        public Guid ConferenceId { get; set; }

        public Guid SpeakerId { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new MvcCascadingDropdownsDesignerModel();

            model.ConferenceId = this.ConferenceId;
            model.SpeakerId = this.SpeakerId;

            return View("Default", model);
        }
    }
}