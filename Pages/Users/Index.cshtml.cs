using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProFit.Data;
using ProFit.Models;
using ProFit.Utility;

namespace ProFit.Pages.Users
{
    [Authorize(Roles = StaticDetail.TrainerOrAdminRole)]
    public class IndexModel : PageModel
    {
        private ApplicationDbContext databaseContext;
        public IndexModel(ApplicationDbContext databaseContext)
        { 
            this.databaseContext = databaseContext;
        }

        public List<User> userList { get; set; }
            

        public async Task OnGet()
        {
            userList = await databaseContext.User.ToListAsync();
        }
    }
}
