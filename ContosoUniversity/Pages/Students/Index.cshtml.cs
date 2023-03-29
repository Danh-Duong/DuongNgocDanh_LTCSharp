using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public IndexModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync(string SearchString)
        {
            if (!string.IsNullOrEmpty(SearchString))
            {
                Student = _context.Students.Where(a => a.FirstMidName109.Contains(SearchString)).ToArray();
            }
            else
            {
                Student = await _context.Students.ToListAsync();
            }
        }
    }
}
