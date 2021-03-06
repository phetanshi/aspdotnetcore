using EmployeeManagement.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Models.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using EmployeeManagement.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _service;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly ILogger logger;
        private readonly IConfiguration _config;

        public HomeController(IHomeService service, IWebHostEnvironment hostingEnvironment, ILogger<HomeController> logger, IConfiguration configuration)
        {
            _service = service;
            this.hostingEnvironment = hostingEnvironment;
            this.logger = logger;
            _config = configuration;
        }
        
        [AllowAnonymous]
        public IActionResult Index()
        {
            HomeIndexEmployeeViewModel model = null;
            try
            {
                logger.LogDebug("Entered into into Action Method");
                model = _service.Get();
                logger.LogDebug("Returning from into Action Method");
            }
            catch(Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            return View(model);
        }
        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Details(int Id)
        {
            HomeDetailsEmployeeViewModel model = null;
            try
            {
                logger.LogDebug("Entered into Details Action Method");
                model = _service.Get(Id);

                if (model == null)
                {
                    Response.StatusCode = 404;
                    return View("EmployeeNotFound", Id);
                }
                logger.LogDebug("Returning from Details Action Method");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HomeCreateEmployeeViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string uniqueFileName = GetUniqueFileName(model.Photo);
                    model.PhotoPath = uniqueFileName;
                    _service.Add(model);

                    HomeDetailsEmployeeViewModel detailsViewMode = new HomeDetailsEmployeeViewModel();
                    detailsViewMode.Id = model.Id;
                    detailsViewMode.Name = model.Name;
                    detailsViewMode.Email = model.Email;
                    detailsViewMode.PhotoPath = model.PhotoPath;
                    detailsViewMode.Department = model.Department;
                    detailsViewMode.Message = "New employee have been created";

                    return View("Details", detailsViewMode);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }

            return View();
        }
        
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            HomeDetailsEmployeeViewModel model = null;
            try
            {
                model = _service.Get(Id);
                HomeEditEmployeeViewModel editModel = new HomeEditEmployeeViewModel();
                PropertyCopy.Copy(model, editModel);
                editModel.ExistingPhotoPath = model.PhotoPath;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(HomeEditEmployeeViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string uniqueFileName = GetUniqueFileName(model.Photo);
                    model.PhotoPath = uniqueFileName;
                    _service.Update(model);

                    HomeDetailsEmployeeViewModel detailsViewMode = new HomeDetailsEmployeeViewModel();

                    //PropertyCopy.Copy(model, detailsViewMode);

                    detailsViewMode.Message = "Employee have been updated";
                    detailsViewMode.Id = model.Id;
                    detailsViewMode.Name = model.Name;
                    detailsViewMode.Email = model.Email;
                    detailsViewMode.PhotoPath = model.PhotoPath;
                    detailsViewMode.Department = model.Department;

                    return View("Details", detailsViewMode);
                }
                else
                {
                    model.Message = "Model Validation Failed";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            return View(model);
        }
        
        public IActionResult Delete(int Id)
        {
            HomeDetailsEmployeeViewModel model = null;
            try
            {
                model = _service.Delete(Id);
                model.Message = "Employee have been deleted";
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            return View("Details", model);
        }
        
        private string GetUniqueFileName(IFormFile Photo)
        {
            string uniqueFileName = null;
            if (Photo != null)
            {
                uniqueFileName = Path.Combine(_config["EmployeeDPFolder"], Guid.NewGuid().ToString() + "_" + Photo.FileName);
                string filePath = Path.Combine(hostingEnvironment.WebRootPath, uniqueFileName);
                Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            return uniqueFileName;
        }
    }
}
