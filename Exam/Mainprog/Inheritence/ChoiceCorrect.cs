using Mainprog.Classes;

namespace Mainprog.Inheritence
{
    class ChoiceCorrect : Quetions
    {
        
       public override Answers[] answers { get; set; }=new Answers[4+1];
       public override int Mark {
            get { return mark; }
            set { mark = value >= 0 ? value : 0; }
        }

        public ChoiceCorrect(string _questionHeader, int _mark, string[] _choices):base(_questionHeader,_mark)
        {
            answers[0] = new Answers(1, _choices[0]);
            answers[1] = new Answers(2, _choices[1]);
            answers[2] = new Answers(4, _choices[2]);
            answers[3] = new Answers(3, _choices[3]);

        }   
        public override void display()
        {
            Console.WriteLine($"  ==> {QuestionHeader} ? \n");
            Console.Write($"\t{answers[1].Answer}\t");
            Console.Write($"\t{answers[2].Answer}\t");
            Console.WriteLine($"\t{answers[3].Answer}\t");
            Console.WriteLine("------------------------------------------");
            Console.Write("  ");
           

        }
    }
}
