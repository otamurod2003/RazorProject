using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        [Required,StringLength(50)]
        public string   Job  { get; set; }

        [Required, StringLength(50)]
        public int Age { get; set; }
    }
}
