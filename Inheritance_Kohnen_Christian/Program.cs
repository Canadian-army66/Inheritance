namespace Inheritance_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clicker myClicker = new Clicker("E", "Cookie Clicker"); //assigns variables to Title and Esrb

            Console.WriteLine(myClicker.Describe()); //prints Describe
            myClicker.PlayGame(); //Prints PlayGame 
        }
    }
}
