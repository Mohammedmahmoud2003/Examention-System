using Mainprog.Classes;
using Mainprog.Inheritence;

namespace Mainprog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject("C#", 1); 
            
            sub.CreateExamOfSubject();
            Console.Clear();
            Console.Write(" Do You Want To Start Exam Y/N :?");
            char response = char.TryParse(Console.ReadLine()?.ToLower(), out response)?response:'n';
            
            if( response=='y')
            {
                sub.Start();
                sub.Store.ShowExamFunctionlity();
            }
            
            
        }
       
        
    }
}