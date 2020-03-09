using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Custom
    {
        public List<Point> points = new List<Point>();

        public Custom() { }

        public Custom(List<Point> list1)
        {
            points = list1;
        }

        public string FileName {
            get;
            set;
        }

        
    }
}
