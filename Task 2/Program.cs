using System.Threading.Channels;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "          test test         test         hi  test      end        ";


            //ArrayHelpers.Trim(word); 

            //word = word.TrimStart();
            


            Console.WriteLine(ArrayHelpers.Trim(word));
            Console.WriteLine(ArrayHelpers.TrimSart(word));
            Console.WriteLine(ArrayHelpers.TrimEnd(word));
        }
    }
}