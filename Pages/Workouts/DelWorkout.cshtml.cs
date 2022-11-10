using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProFit.Models;

namespace ProFit.Pages.Workouts
{
    public class DelWorkoutModel : PageModel
    {
        private ApplicationDbContext databaseContext;
        public DelWorkoutModel(ApplicationDbContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
     
        public async Task OnGet(int workoutId)
        {
            var workout = databaseContext.Workouts.First(w => w.Id == workoutId);
            databaseContext.Remove(workout);
            await databaseContext.SaveChangesAsync();
        }
    }
}
