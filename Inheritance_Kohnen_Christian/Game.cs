using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kohnen_Christian
{
    abstract class Game
    {
        public string Esrb { get ; set; } //creates 
        public string Title { get; set; } //creates
        public Game(string esrcParam, string titleParam) //makes parameters for Title and Esrb
        {
            Esrb = esrcParam; //assigns paramterer to Esrb
            Title = titleParam; //assigns parameter to Title
        }
        public void PlayGame() //creates PlayGame 
        {
            Console.WriteLine($"{Title} is starting!"); //tells it to print when called
        }

        public abstract string Describe(); //calls Describe
    }
}
