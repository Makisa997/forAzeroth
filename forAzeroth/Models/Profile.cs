using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Web;

namespace forAzeroth.Models
{
    public class Profile
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string CharacterName { get; set; }
        public string ClassName { get; set; }
        public string Orientations { get; set; }
        public string TypeOfPlay { get; set; }
        public string Welcome()
        {
            string message = Name + ",Thanks for applying to our guild as " + TypeOfPlay + ",we'll respond as fast as possible!";
            return message;

        }
    }
}