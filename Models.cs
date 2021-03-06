using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMapApp
{

    // в этом файле находятся классы, описывающие модель для базы данных

    [Table("places")]

    public class Place
    {
        [Key]

        public string name { get; set; }

        public string tooltip { get; set; }

        public string description { get; set; }

        public string image { get; set; }

        public double lat { get; set; }

        public double lng { get; set; }

        public Place() { }

        public Place(string name, string tooltip, string description, string image, double lat, double lng)
        {
            this.name = name;
            this.tooltip = tooltip;
            this.description = description;
            this.image = image;
            this.lat = lat;
            this.lng = lng;
        }
    }

    [Table("Routes")]

    public class Route
    {
        [Key]

        public string name { get; set; }

        public string points { get; set; }

        public Route() { }

        public Route(string name, string points)
        {
            this.name = name;
            this.points = points;
        }
    }

    [Table("Tests")]

    public class Test
    {
        [Key]

        public string question { get; set; }

        public string answer { get; set; }

        public Test() { }

        public Test(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }

    [Table("Users")]

    public class User
    {
        [Key]

        public int id { get; set; }

        public string unlockPlace { get; set; }

        public User() { }

        public void addUnlockPlace(int num)
        {
            unlockPlace += Convert.ToString(num);
        }

    }
}
