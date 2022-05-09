using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProFit.Models;

namespace ProFit.Areas.Identity.Pages.Account
{
    public class SetRoleModel : PageModel
    {
        private UserManager<IdentityUser> userManager { get; set; }
        public SetRoleModel(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task OnGet(string username, string role)
        {
            var user = (User)await userManager.FindByNameAsync(username);
            await userManager.RemoveFromRoleAsync(user, user.Role);
            await userManager.AddToRoleAsync(user, role);
            user.Role = role;
            await userManager.UpdateAsync(user);
        }
    }
}
