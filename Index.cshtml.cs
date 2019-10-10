using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dog_Store_App.Data;

namespace Dog_Store_App.Pages.myPet
{
    public class IndexModel : PageModel
    {
        private readonly Dog_Store_App.Data.ApplicationDbContext _context;

        public IndexModel(Dog_Store_App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Pet_Stores> Pet_Stores { get;set; }

        public async Task OnGetAsync()
        {
            Pet_Stores = await _context.Pet_Stores.ToListAsync();
        }
    }
}
