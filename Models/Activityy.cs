using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeltExam.Models
{
    public class Activityy
    {
        [Key]
        public int ActivityId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage="Title must be 2 characters or longer!")]
        [Display(Name = "Title")]
        public string Title {get;set;}

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime ActDate {get;set;}

        [Required]
        [MinLength(10)]
        public string Description {get;set;}

        [Required]
        public string Time { get; set; }
        [Required]
        [Display(Name = "Duration")]
        public int ActDuration {get;set;}

        [Required]
        [Display(Name = " ")]
        public string durationUnit { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserId {get;set;}
        public User PlanedBy {get;set;}
        public List<Participate> participants {get;set;}

    }
}