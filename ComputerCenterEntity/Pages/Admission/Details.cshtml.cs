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
    public class DetailsModel : PageModel
    {
        private readonly ComputerCenterEntity.Models.ComputerCenterEntityContext _context;

        public DetailsModel(ComputerCenterEntity.Models.ComputerCenterEntityContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.id == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
