using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities()) 
            {
                var insurees = (from c in db.Insurees select c).ToList();
                var metadatas = new List<InsureeMetadata>();
                // for each loops iterates through all data listed below in the DB.
                foreach (var insuree in insurees)
                {
                    var metadata = new InsureeMetadata();
                    metadata.Id = insuree.Id;
                    metadata.FirstName = insuree.FirstName;
                    metadata.LastName = insuree.LastName;
                    metadata.EmailAddress = insuree.EmailAddress;
                    metadata.Quote = Convert.ToInt32(insuree.Quote);
                    metadatas.Add(metadata);
                }
                return View(metadatas);
            }
            
        }
    }
}