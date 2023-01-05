using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPizza.Data;
using RazorPagesPizza.Models;

namespace RazorPagesPizza.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPizza.Data.RazorPagesPizzaContext _context;

        public IndexModel(RazorPagesPizza.Data.RazorPagesPizzaContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizzas { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string ? SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var pizzas = from p in _context.Pizza
                         select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                pizzas = pizzas.Where(s => s.Name.Contains(SearchString));
            }

            if (_context.Pizza != null)
            {
                Pizzas = await pizzas.ToListAsync();
            }
        }
    }
}
