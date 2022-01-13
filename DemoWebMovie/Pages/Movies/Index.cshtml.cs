#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoWebMovie.Data;
using DemoWebMovie.Models;

namespace DemoWebMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly DemoWebMovie.Data.MovieContext _context;

        public IndexModel(DemoWebMovie.Data.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
