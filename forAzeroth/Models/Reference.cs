using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace forAzeroth.Models
{
    public class Reference:Profile
    {
        public string LeaveAReference { get; set; }
        new public string Welcome()
        {
            string message = Name + ",Thank you for leaving a reference as a " + TypeOfPlay + "Player!";
            return message;
        }
    }
}