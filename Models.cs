using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMapApp
{

    [Table("places")]

    public class Place
    {
        [Key]

        public string name { get; set; }

        public string tooltip { get; set; }

        public string description { get; set; }

        public string image { get; set; }

        public Place() { }

        public Place(string name, string tooltip, string description, string image)
        {
            this.name = name;
            this.tooltip = tooltip;
            this.description = description;
            this.image = image;
        }

    }
}
