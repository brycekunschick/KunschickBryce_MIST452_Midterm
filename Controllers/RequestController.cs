using KunschickMidterm452.Data;
using KunschickMidterm452.Models;
using KunschickMidterm452.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KunschickMidterm452.Controllers
{
    public class RequestController : Controller
    {
        private PoliceDbContext _dbContext;

        public RequestController(PoliceDbContext context)
        {
            _dbContext = context;

        }

        public IActionResult Index()
        {
            var listOfRequests = _dbContext.Requests.ToList();

            return View(listOfRequests);
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            IEnumerable<SelectListItem> listOfOfficers = _dbContext.Officers.ToList().Select(u => new SelectListItem
            {
                Text = $"{u.FirstName} {u.LastName}",
                Value = u.OfficerId.ToString()
            });

            RequestWithOfficersVM requestWithOfficersVMobj = new RequestWithOfficersVM();

            requestWithOfficersVMobj.Request = _dbContext.Requests.Find(id);

            requestWithOfficersVMobj.ListOfOfficers = listOfOfficers;

            return View(requestWithOfficersVMobj);
        }

        [HttpPost]
        public IActionResult Edit(int id, RequestWithOfficersVM requestWithOfficersVMobj)
        {
            //Validation check for VehicleMake
            if (requestWithOfficersVMobj.Request.VehicleMake != null && requestWithOfficersVMobj.Request.VehicleMake.ToLower() == "test")
            {
                ModelState.AddModelError("Request.VehicleMake", "Vehicle make cannot be 'test'");
            }

            if (ModelState.IsValid)
            {
                var requestInDb = _dbContext.Requests.Find(id);

                requestInDb.VIN = requestWithOfficersVMobj.Request.VIN;
                requestInDb.PlateNum = requestWithOfficersVMobj.Request.PlateNum;
                requestInDb.VehicleMake = requestWithOfficersVMobj.Request.VehicleMake;
                requestInDb.VehicleModel = requestWithOfficersVMobj.Request.VehicleModel;
                requestInDb.Mileage = requestWithOfficersVMobj.Request.Mileage;
                requestInDb.Description = requestWithOfficersVMobj.Request.Description;
                requestInDb.OfficerId = requestWithOfficersVMobj.Request.OfficerId;

                _dbContext.SaveChanges();

                return RedirectToAction("Index", "Request");
            }
            else
            {
                //If model state not valid, repopulate ListOfOfficers for the view
                requestWithOfficersVMobj.ListOfOfficers = _dbContext.Officers.ToList().Select(u => new SelectListItem
                {
                    Text = $"{u.FirstName} {u.LastName}",
                    Value = u.OfficerId.ToString()
                });

                return View(requestWithOfficersVMobj);
            }
        }


    }
}
