using Mainprog.Classes;

namespace Mainprog.Inheritence
{
    class ChoiceTrueOrFalse : Quetions
    {
        public override Answers[] answers { get; set; } = new Answers[1];

        public override int Mark
        {
            get { return mark; }
            set { mark = value >= 0 ? value : 0; }
        }
        public ChoiceTrueOrFalse(string _questionHeader, int _mark, string correct ) : base(_questionHeader, _mark)
        {
            answers[0] = new Answers(1, correct);
        }
        public override void display()
        {
            Console.WriteLine($"  ==> {QuestionHeader} ? \n");
            Console.WriteLine($"   True     or     False ");
            Console.WriteLine("------------------------------------------");
            Console.Write("  ");
            


        }

    }
}
