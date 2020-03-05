using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WhyLong
{
    class Picture
    {
        public int PictureId { get; set; }
        public Artist Author { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public double Cost { get; set; }
        public Genre Genre { get; set; }
    }
}
