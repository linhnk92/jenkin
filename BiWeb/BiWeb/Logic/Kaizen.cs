using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiWeb.Logic
{
    public class Kaizen
    {
        public bool GetResult()
        {
            return true;
        }

        public int GetAge(int birthYear)
        {
            return DateTime.Now.Year - birthYear;
        }
    }
}
