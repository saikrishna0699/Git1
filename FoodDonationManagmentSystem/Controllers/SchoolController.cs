using FoodDonationManagmentSystem.Data.Interface;
using FoodDonationManagmentSystem.Models;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagmentSystem.Controllers
{
    [ApiController]
    public class SchoolController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly ISchoolModuleRepository _SchoolRepo;
        public SchoolController(ISchoolModuleRepository schoolModuleRepository)
        {
            _SchoolRepo = schoolModuleRepository;

        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = _SchoolRepo.Get();
                log.Info("Data is Displayed");
                return StatusCode(200, result);
            }
            catch (Exception)
            {
                log.Error("Error occur");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data from the Database");
            }
        }
        [HttpPost("Post")]
        public async Task<ActionResult> Post([FromBody] DonarsModule donar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _SchoolRepo.Post(donar);
                    log.Info("Created Successfully");
                    return StatusCode(200, "Created Successfully");
                }
                else
                {
                   log.Error("No Data");
                    return BadRequest("No Data");
                }
            }
            catch (Exception)
            {
                log.Error("Error occur");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Adding Data to the Database");
            }

        }
        [HttpPut("Put")]
        public  async Task<IActionResult> Put ([FromBody] DonarsModule donar )
        {
            try
            {
                var result = _SchoolRepo.Put(donar);
                log.Info("Updated Successfully");
                return StatusCode(200, "Successfully Updated");
            }
            catch (Exception )
            {
                log.Error("Error occur");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Updating Data to the Database");
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int DonarId)
        {
            try
            {
                var result = _SchoolRepo.Delete(DonarId);
                log.Info("Deleted Successfully");
                return StatusCode(200," Successfully Deleted");
            }
            catch (Exception )
            {
                log.Error("Error occur");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Deleting Data to the Database");
            }
        }

    }
}

    
