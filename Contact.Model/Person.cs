using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contact.Model
{
    [Table("Contact")]
    public class Person
    {
        public int Id { get; set; }
        
        [MaxLength(40)]
        public string ImageName { get; set; }

        //Personal Detail
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100)]
        public string FullName { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(60)]
        public string PrimaryEmail { get; set; }

        [ForeignKey("Group")]
        public int? GroupId { get; set; }


        [MaxLength(15)]
        public string Mobile1 { get; set; }

        [MaxLength(15)]
        public string Mobile2 { get; set; }

        [MaxLength(20)]
        public string Relation { get; set; }

        public DateTime? BirthDay { get; set; }


        //Professional Detail
        [MaxLength(200)]
        public string Company { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Website { get; set; }

        [MaxLength(60)]
        public string ProfEmail { get; set; }

        [MaxLength(15)]
        public string Telephone1 { get; set; }

        [MaxLength(15)]
        public string Telephone2 { get; set; }

        [MaxLength(20)]
        public string ProfMobile1 { get; set; }

        [MaxLength(20)]
        public string ProfMobile2 { get; set; }

        [MaxLength(15)]
        public string Fax { get; set; }

        //Note

        [MaxLength(1500)]
        public string Note { get; set; }


        //IM
        [MaxLength(120)]
        public string Skype { get; set; }

        [MaxLength(120)]
        public string WindowsLive { get; set; }

        [MaxLength(120)]
        public string Yahoo { get; set; }

        [MaxLength(120)]
        public string Hangout { get; set; }

        [MaxLength(120)]
        public string Gmail { get; set; }

        [MaxLength(120)]
        public string Facebook { get; set; }

        //FK
        public virtual Group Group { get; set; }

    }
}
