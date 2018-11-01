using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contact.Model
{
    public class Group
    {
       [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Group name is required.")]
        [MaxLength(30)]
        public string Name { get; set; }

        public virtual IList<Person>   Persons { get; set; }
    }
}
