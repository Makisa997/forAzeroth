using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace forAzeroth.Models
{
    public class Orientation
    {
        public string TypeOfPlay { get; set; }
        public Orientation(string TypeOfPlay)
        {
            this.TypeOfPlay = TypeOfPlay;
        }
    }
}