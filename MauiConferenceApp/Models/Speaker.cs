using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiConferenceApp.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Twitter { get; set; }
        public string Website { get; set; }
        public string Image { get; set; } = "https://avatars.githubusercontent.com/u/100397211?v=4";
    }
}
