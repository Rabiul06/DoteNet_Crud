using System.ComponentModel.DataAnnotations;

namespace CRUD_Project.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string name { get; set; }
        public DateTime Created_Date { get; set; } = default(DateTime);
        public DateTime Modificattion_Date { get; set; } = default(DateTime);

    }
}
