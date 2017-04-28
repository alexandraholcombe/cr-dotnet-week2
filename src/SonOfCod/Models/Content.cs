using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCod.Models
{
    public class Content
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string Tagline { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string Text { get; set; }
        public string ClickText { get; set; }
        public string ClickView { get; set; }
        public string ClickController { get; set; }

    }
}
