using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMapApp
{
    public class DataPlace
    {
        public static readonly string directory = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length-9);
        public static string[] photoPaths = new String[6]
        {
            directory + "Images/krivonogov.jpg",
            directory + "Images/museum.jpg",
            directory + "Images/truzenikam.jpg",
            directory + "Images/btr.jpg",
            directory + "Images/stella.jpg",
            directory + "Images/shamshurina.jpg"
        };
    }
}
