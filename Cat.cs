using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatProject
{
    public class Cat
    {
        private int _timesPetted;

        public string Pur()
        {
            return "Purrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr";
        }

        public int Pet()
        {
            return ++_timesPetted;
        }
    }
}
