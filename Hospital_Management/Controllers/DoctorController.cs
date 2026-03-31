using HospitalManagement.DBEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Controllers
{
    public class DoctorController : Controller
    {
        DBEntities.HospitalManagementContext context = new DBEntities.HospitalManagementContext(); // to read from DB
        public IActionResult Add()
        {
            ViewBag.Shift = (from x in context.ShiftTypes.ToList()
                             select new
                             {
                                 Id = x.ShiftTypeId,
                                 Name = x.ShiftName,

                             }).ToList();

            ViewBag.Specialization = (from x in context.Specializations.ToList()
                                      select new
                                      {
                                          Id = x.SpecializationId,
                                          Name = x.SpecializationName,

                                      }).ToList();

            return View();
        }
        public IActionResult UpdateDoctor(Models.DoctorModel model)
        {
            DBEntities.Doctor doctor = new DBEntities.Doctor();
            doctor = context.Doctors.Where(x => x.DoctoeId == model.DoctoeId).FirstOrDefault();
            doctor.FirstName = model.FirstName;
            doctor.LastName = model.LastName;
            doctor.Gender = model.Gender;
            doctor.JoinDate = model.JoinDate;
            doctor.Salary = model.Salary;
            doctor.Mobile = model.Mobile;
            doctor.ShiftTypeId = model.ShiftTypeId;
            doctor.SpecializationId = model.SpecializationId;
            doctor.YearOfExperience = model.YearOfExperience;

            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        public IActionResult Edit(int Id)
        {
            // Here we didn't declear an obj from entity cause we want to return data and pass it to medle to show on screen just
            var result = context.Doctors.Where(x => x.DoctoeId == Id).FirstOrDefault();
            Models.DoctorModel doctorModel = new Models.DoctorModel();
            doctorModel.DoctoeId = result.DoctoeId;
            doctorModel.FirstName = result.FirstName;
            doctorModel.LastName = result.LastName;
            doctorModel.Gender = result.Gender;
            doctorModel.JoinDate = result.JoinDate;
            doctorModel.Mobile = result.Mobile;
            doctorModel.Salary = result.Salary;
            doctorModel.ShiftTypeId = result.ShiftTypeId;
            doctorModel.SpecializationId = result.SpecializationId;
            doctorModel.YearOfExperience = result.YearOfExperience;
            ViewBag.Shift = (from x in context.ShiftTypes.ToList()
                             select new
                             {
                                 Id = x.ShiftTypeId,
                                 Name = x.ShiftName,

                             }).ToList();

            ViewBag.Specialization = (from x in context.Specializations.ToList()
                                      select new
                                      {
                                          Id = x.SpecializationId,
                                          Name = x.SpecializationName,

                                      }).ToList();
            return View(doctorModel);
        }
        public IActionResult GetAll()
        {
            List<Models.DoctorModel> lst = new List<Models.DoctorModel>();
            lst = (from x in context.Doctors.Where(x => x.IsDeleted != true)
                .Include(x => x.ShiftType).Include(x => x.Specialization).ToList()
                   select new Models.DoctorModel
                   {
                       DoctoeId = x.DoctoeId,
                       FirstName = x.FirstName,
                       LastName = x.LastName,
                       GenderName = x.Gender ? "Male" : "Female",
                       JoinDate = x.JoinDate,
                       Mobile = x.Mobile,
                       ShiftName = x.ShiftType.ShiftName,
                       SpecializationName = x.Specialization.SpecializationName,
                       YearOfExperience = x.YearOfExperience,
                   }).ToList();
            return View(lst);
        }
        public IActionResult Delete(int Id)
        {
            var result = context.Doctors.Where(x => x.DoctoeId == Id).FirstOrDefault();
            result.IsDeleted = true;
            context.SaveChanges();

            return RedirectToAction("GetAll");

        }
        public IActionResult AddNewDoctor(Models.DoctorModel model)
        {
            try
            {




                DBEntities.Doctor doctor = new DBEntities.Doctor();
                doctor.FirstName = model.FirstName;
                doctor.LastName = model.LastName;
                doctor.Gender = model.Gender;
                doctor.JoinDate = model.JoinDate;
                doctor.Salary = model.Salary;
                doctor.Mobile = model.Mobile;
                doctor.ShiftTypeId = model.ShiftTypeId;
                doctor.SpecializationId = model.SpecializationId;
                doctor.YearOfExperience = model.YearOfExperience;
                doctor.IsDeleted = false;
                context.Doctors.Add(doctor);
                context.SaveChanges();
                return RedirectToAction("GetAll");


            }
            catch (Exception ex)
            {
                
                ErrorLog obj = new ErrorLog();
                obj.TransactionDate = DateTime.Now;
                if (ex.InnerException != null)

                    obj.InnerException = ex.InnerException.ToString();
                if (ex.Message != null)
                    obj.ErrorMessage = ex.Message;
                obj.StackTrace=ex.StackTrace;
                throw;
            }

        }
    }
}
