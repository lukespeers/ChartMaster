using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;

namespace ChartMaster.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [AllowNull]
        public string Lyrics { get; set; }
        [AllowNull, DisplayName("Short Lyrics")]
        public string ShortLyrics { get; set; }
        [AllowNull, DisplayName("Full Tab")]
        public string FullTab { get; set; }
    }
}
