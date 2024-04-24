using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kohnen_Christian
{
    class Clicker : Game
    {
        public Clicker(string esrcParam, string titleParam) : base(esrcParam, titleParam) //calls parameters
        {
            Title = titleParam; //assigns parameter to Title
            Esrb = esrcParam; //assigns parameter to Esrb
        }
        public override string Describe() //creates Describe
        {
            return $"{Title} is a Clicker rated {Esrb}";
        }
    }
}
