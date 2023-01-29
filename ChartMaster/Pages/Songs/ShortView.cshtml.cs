using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ChartMaster.Data;
using ChartMaster.Models;

namespace ChartMaster.Pages.Songs
{
    public class ShortViewViewModel : PageModel
    {
        private readonly ChartMaster.Data.ChartMasterContext _context;

        public ShortViewViewModel(ChartMaster.Data.ChartMasterContext context)
        {
            _context = context;
        }

      public Song Song { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Song == null)
            {
                return NotFound();
            }

            var song = await _context.Song.FirstOrDefaultAsync(m => m.ID == id);
            if (song == null)
            {
                return NotFound();
            }
            else 
            {
                Song = song;
            }
            return Page();
        }
    }
}
