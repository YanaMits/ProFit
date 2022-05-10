using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProFit.Models
{
    public class Workout
    {
        [Key]
        public int Id  {get; set;}
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string TrainerId { get; set; }


        public User Trainer { get; set; }
        public List<WorkoutParticipant> WorkoutParticipants { get; set; }
    }

    public class WorkoutParticipant
    {
        [Key]
        public int Id { get; set; }
        public int WorkoutId { get; set; }
        public string UserId { get; set; } 


        public Workout Workout { get; set; }
        public User User { get; set; }
    }


}
