using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _123.Data;
using _123.Models;

namespace _123
{
    public class DetailsModel : PageModel
    {
        private readonly _123.Data.UsersContext _context;

        public DetailsModel(_123.Data.UsersContext context)
        {
            _context = context;
        }

        public TableUserViewModel TableUserViewModel { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TableUserViewModel = await _context.TableUserViewModel.FirstOrDefaultAsync(m => m.Id == id);

            if (TableUserViewModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
