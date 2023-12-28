using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Pages.ProdutoCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication.Data.ApplicationDbContext _context;

        public DetailsModel(WebApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto = await _context.Produto.FirstOrDefaultAsync(m => m.IdProduto == id);

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
