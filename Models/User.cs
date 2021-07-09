using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeltExam.Models
{
    public class User
    {
    [Key]
    public int UserId {get;set;}
    [Required]
    [MinLength(2,ErrorMessage="Name must be 2 characters or longer!")]
    [Display(Name ="Name")]
    public string name {get;set;}

    [EmailAddress]
    [Required]
    [Display(Name ="Email")]

    public string Email {get;set;}

    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
    [Display(Name ="Password")]

    public string Password {get;set;}
    // Will not be mapped to your users table!
    [NotMapped]
    [Required]
    [Compare("Password")]
    [DataType(DataType.Password)]
    [Display(Name ="Confirm PW")]

    [MinLength(8, ErrorMessage = "Confirm must be 8 characters or longer!")]
    public string Confirm {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    // nav props
    public List<Activityy> planedActivities {get;set;}

    public List<Participate> participatedActivities {get;set;}

    }
}