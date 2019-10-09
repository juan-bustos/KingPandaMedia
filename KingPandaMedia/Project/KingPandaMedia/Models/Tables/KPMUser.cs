using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace KingPandaMedia.Models.Tables
{
    public class KPMUser : IdentityUser
    {
        //[Key]
        //public int UserID { get; set; }

        ////[Required(ErrorMessage =" Enter a username"), StringLength(20)]
        ////public override string UserName { get; set; }

        //[Required(ErrorMessage = "First Name Required"), StringLength(30)]
        //public string FirstName { get; set; }

        //[Required(ErrorMessage = "Last Name Required"), StringLength(30)]
        //public string LastName { get; set; }

        //[DataType(DataType.EmailAddress)]
        //[Required(ErrorMessage = "E-Mail required")]
        //public  string Email { get; set; }

        ////[DataType(DataType.PhoneNumber)]
        ////[Required(ErrorMessage = "Phone Number Required")]
        ////public override string PhoneNumber { get; set; }

        //[DataType(DataType.Password)]
        //[Required(ErrorMessage = "Password Required")]
        //[StringLength(50)]
        //public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm Password")]
        //[Compare("Password", ErrorMessage = "Passwords do not match.")]
        //[StringLength(50)]
        //public string ConfirmPassword { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime SignUpDate { get; set; }
        //public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
