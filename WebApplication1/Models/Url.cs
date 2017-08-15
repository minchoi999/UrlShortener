using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UrlShortener.Models
{
    public class Url
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }
        public DateTime Date { get; set; }
       
	}
}


