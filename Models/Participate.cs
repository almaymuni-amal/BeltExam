using System.ComponentModel.DataAnnotations;

namespace BeltExam.Models
{
    public class Participate
    {
        [Key]
        public int ParticipateId {get;set;}
        public int UserId {get;set;}
        public User participant {get;set;}
        public int ActivityId { get; set; }
        public Activityy activity { get; set; }
    }
}