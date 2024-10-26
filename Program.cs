
namespace day2_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task2
            Console.WriteLine(" please enter you grada ( A , B , C , D , F ) ;");
            char grade = Console.ReadLine().ToUpper()[0];
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("exelent");
                    break;
                case 'B':
                    Console.WriteLine("very good")
                        ; break;
                case 'c':
                    Console.WriteLine("good");
                    break;
                case 'd':
                    Console.WriteLine("fair");
                    break;
                case 'f':
                    Console.WriteLine("FAILED");
                    break;
             
                    default:
                    Console.WriteLine(" is not match");

                    break;

                   


            }





        }
    }
}
