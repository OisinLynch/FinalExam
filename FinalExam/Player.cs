using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    //Position enum
    public enum Position { Goakeeper, Defender, Midfielder, Forward }
    class Player : IComparable
    {
        //Properties
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Position PreferedPosition { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }


        //Methods
        public override string ToString()
        {
            return $"{FirstName} {Surname} {(Age)} {PreferedPosition}";
        }

        internal void Add(Player selectedPlayer)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            Player that = (Player)obj;

            //Compare one Player Position to another 
            return this.PreferedPosition.CompareTo(that.PreferedPosition);
        }

    }
}
