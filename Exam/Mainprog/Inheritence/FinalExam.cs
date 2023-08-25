namespace Mainprog.Inheritence
{
    class FinalExam : Exam
    {
        public override Quetions[] Questions { get; set;}

        public FinalExam(int _NumberOfQuestion, int _TimeOfExam) : base(_NumberOfQuestion, _TimeOfExam)
        {
            Questions = new Quetions[_NumberOfQuestion];

        }
       
        public override void ShowExamFunctionlity()
        {

            Console.Clear();
            int curr = 0;
            Console.WriteLine(" YOUR ANSWERS");

           
            if (Questions is not null)
            {
                for (int i = 0; i < Questions.Length; i++)
                {
                    if (Questions[i] is not null)
                    {
                        Console.WriteLine($"{++curr} )=> {Questions[i].QuestionHeader} ? ==>{Questions[i].answers[0].Answer} \n");

                    }
                    else
                        break;

                }
            }
            Console.WriteLine($"the Mark ==>{GBA}");
            Console.WriteLine($"the Duration ==> {DateTime.Now - start}");

        }
    }
}
