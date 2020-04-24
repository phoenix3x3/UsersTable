using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _123.Data;
using _123.Models;

namespace _123
{
    public class EditModel : PageModel
    {
        private readonly _123.Data.UsersContext _context;

        public EditModel(_123.Data.UsersContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TableUserViewModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableUserViewModelExists(TableUserViewModel.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TableUserViewModelExists(string id)
        {
            return _context.TableUserViewModel.Any(e => e.Id == id);
        }
    }
}
