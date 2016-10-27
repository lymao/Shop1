using AutoMapper;
using Shop1.Model.Models;
using Shop1.Service;
using Shop1.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop1.Web.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        IContactDetailService _contactDetailService;
        public ContactController(IContactDetailService contactDetailService)
        {
            this._contactDetailService = contactDetailService;
        }
        public ActionResult Index()
        {
            var model = _contactDetailService.GetDefaultContact();
            var contactViewModel = Mapper.Map<ContactDetail, ContactDetailViewModel>(model);
            return View(contactViewModel);
        }
    }
}