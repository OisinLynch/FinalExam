using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    //Position enum
    public enum Position { Goakeeper, Defender, Midfielder, Forward }
    class Player
    {
        //Properties
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Position PreferedPosition { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
    }
}
