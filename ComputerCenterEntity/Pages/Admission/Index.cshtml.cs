using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ComputerCenterEntity.DataLayer;
using ComputerCenterEntity.Models;

namespace ComputerCenterEntity.Pages.Admission
{
    public class IndexModel : PageModel
    {
        private readonly ComputerCenterEntity.Models.ComputerCenterEntityContext _context;

        public IndexModel(ComputerCenterEntity.Models.ComputerCenterEntityContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
