// Developed by: Cobie Luna
// Date: 02/4/2022

namespace T3_Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare CAD to US currency convertion rate as constant
            const double RATE = 0.792367;
            //ask increment value everytime
            Console.Write("Please, enter CAD increment value[5-25]: ");
            int increment = int.Parse(Console.ReadLine());
            //keep asking if not wihtin the 5-25 range every search
            while (increment < 5 || increment > 25)
            {
                //display error message if the number is out of range
                Console.WriteLine("Increment value must be within 5-25 range !");
                //ask and read again to retry
                Console.Write("Please, enter CAD increment value[5-25]: ");
                increment = int.Parse(Console.ReadLine());
            }
            //display table header after number input
            Console.WriteLine("    CAD       US$");
            Console.WriteLine("-----------------");
            //display table
            for (int cad = 0; cad <= 200; cad += increment)
            {
                //calculate us dollar value after enter
                double usd = cad * RATE;
                //display lines
                Console.WriteLine("{0,7:F2}    {1,6:F2}", cad, usd);
            }
            //wait for press any key to exit the program after serach is complete
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey(true);

        }
    }
}
