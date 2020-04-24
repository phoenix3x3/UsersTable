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
    public class IndexModel : PageModel
    {
        private readonly _123.Data.UsersContext _context;

        public IndexModel(_123.Data.UsersContext context)
        {
            _context = context;
        }

        public IList<TableUserViewModel> TableUserViewModel { get;set; }

        public async Task OnGetAsync()
        {
            TableUserViewModel = await _context.TableUserViewModel.ToListAsync();
        }
    }
}
