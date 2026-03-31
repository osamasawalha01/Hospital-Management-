using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class DoctorModel
    {
        public int DoctoeId { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="This field is Required")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]

        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]

        public bool Gender { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]

        public DateOnly JoinDate { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]

        public decimal Salary { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]

        public string Mobile { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]

        public int ShiftTypeId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]

        public int SpecializationId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]

        public int YearOfExperience { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]

        public bool IsDeleted { get; set; }
        public string ShiftName { get; set; }
        public string GenderName {  get; set; }
        public String SpecializationName { get; set; }
    }
}
