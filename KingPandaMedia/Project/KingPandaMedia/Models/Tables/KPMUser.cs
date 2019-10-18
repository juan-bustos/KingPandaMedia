using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace KingPandaMedia.Models.Tables
{
    public class KPMUser : IdentityUser
    {
        [Required(ErrorMessage = "First Name Required"), StringLength(30)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required"), StringLength(30)]
        public string LastName { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number Required")]
        public override string PhoneNumber { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SignUpDate { get; set; }
    }
}
