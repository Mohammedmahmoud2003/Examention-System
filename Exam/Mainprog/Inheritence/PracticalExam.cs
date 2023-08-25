namespace Mainprog.Inheritence
{
    class PracticalExam :Exam
    {
        public override Quetions[] Questions { get; set; }
        public PracticalExam(int _NumberOfQuestion, int _TimeOfExam) : base(_NumberOfQuestion, _TimeOfExam)
        {
             Questions = new ChoiceCorrect[_NumberOfQuestion];
        }
        
        public override void ShowExamFunctionlity()
        {
            Console.Clear();
            Console.WriteLine(" YOUR ANSWERS");
            if (Questions is not null)
            {
                for (int i = 0; i < Questions.Length; i++)
                {
                    if (Questions[i] is not null)
                    {
                        Console.WriteLine($"{i+1} ) => {Questions[i].QuestionHeader} ? {Questions[i].answers[0].Answer} \n");
                    }
                    else
                        break;

                }
            }
            
            Console.WriteLine($" The Duration => {DateTime.Now-start}");


        }

        
    }
}
