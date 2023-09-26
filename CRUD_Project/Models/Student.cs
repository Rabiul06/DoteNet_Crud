using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Project.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Std_Name { get; set; }
        public int gender { get; set; }
        public DateTime DOB { get; set; }
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; } = default;
        public  DateTime Created_Date { get; set; } = default(DateTime);
        public DateTime Modificattion_Date { get; set; } = default(DateTime);
        

    }
}
