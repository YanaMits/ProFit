using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProFit.Utility;

namespace ProFit.Pages.Users
{
    [Authorize(Roles = StaticDetail.AdminRole)]
    public class AdminModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
