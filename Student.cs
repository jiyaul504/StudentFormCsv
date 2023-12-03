namespace StudentFormCsv.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }



        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }




    }

}
