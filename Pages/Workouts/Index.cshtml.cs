using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProFit.Models;

namespace ProFit.Pages.Workouts
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext databaseContext;
        public IndexModel(ApplicationDbContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public List<Workout> workoutList { get; set; }

        public async Task OnGetAsync()
        {
            workoutList = await databaseContext.Workouts
                .Include(w=>w.Trainer)
                .Include(w=>w.WorkoutParticipants)
                .ToListAsync();
        }
    }

    


}
