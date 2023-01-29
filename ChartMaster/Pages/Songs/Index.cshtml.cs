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
    public class IndexModel : PageModel
    {
        private readonly ChartMaster.Data.ChartMasterContext _context;

        public IndexModel(ChartMaster.Data.ChartMasterContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Song != null)
            {
                Song = await _context.Song.ToListAsync();
            }
        }
    }
}
