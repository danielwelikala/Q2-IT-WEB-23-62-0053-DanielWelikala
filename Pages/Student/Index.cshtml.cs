using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Q2.Data;
using Q2.Model;

namespace Q2.Pages.Student
{
    public class IndexModel : PageModel
    {
        private readonly Q2.Data.Q2Context _context;

        public IndexModel(Q2.Data.Q2Context context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Students = await _context.Students.ToListAsync();
            }
        }
    }
}
