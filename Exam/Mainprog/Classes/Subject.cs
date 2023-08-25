using Mainprog.Inheritence;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Mainprog.Classes
{
    internal class Subject
    {
        #region property
        public int SubjectID { get; set; } = 0;
        public string SubjectName { get; set; } = "No Subject";
        public Exam Store { get; set; }
        #endregion

        public Subject(string Name, int Id)
        {
            SubjectID = Id;
            SubjectName = Name;
        }
        public void CreateExamOfSubject()

        {
            #region Take details
            int num = 0;
            int Choise = -1;
            int duration = 0;

            do
            {
                Console.Write("Enter The Type Of Exam ( 1 ==> Final || 0 ==>  Practical:");

            } while (!(int.TryParse(Console.ReadLine(), out Choise)) || Choise != 0 && Choise != 1);

            do
            {
                Console.Write("Enter The Number Of Question:");
            } while (!int.TryParse(Console.ReadLine(), out num) || num < 1);

            do
            {
                Console.Write("Enter The Duration Of The Exam:");
            } while (!int.TryParse(Console.ReadLine(), out duration) || duration < 1); 
            #endregion

            Console.Clear();
            
            if (Choise == 0)
            {
                 
                PracticalExam Exam = new PracticalExam(num, duration);

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("ChooseCorrectQustion");
                    string Question;
                    do
                    {
                        Console.WriteLine($"{i+1} ) Enter Your Question .");
                        Question = Console.ReadLine();
                    } while (Question?.Length == 0);
                    Console.WriteLine("Enter Optional Answer.");
                    string[] Arr = new string[4];
                    for (int j = 1; j < 4; j++)
                    {
                        do
                        {
                            Console.Write($"Enter The {j} Answer: ");
                            Arr[j] = Console.ReadLine();
                        } while (Arr[j]?.Length == 0);
                    }

                    string correct;
                    do
                    {
                         Console.Write("Enter the correct Answer : ");
                         correct = Console.ReadLine();
                       
                    } while (correct?.Length == 0);
                    Arr[0] = correct;
                    Console.Write("Enter the Mark: ");
                    int Mark = int.TryParse(Console.ReadLine(), out Mark) ? Mark : 0;

                    Exam.Questions[i] = new ChoiceCorrect(Question, Mark, Arr);
                }
                Store = Exam;

            }
            else
            {
                FinalExam Exam = new FinalExam(num, duration);
                
                for (int i = 0; i < num ; i++)
                {
                    int SubChoise;
                    do
                    {
                     Console.Write($"{i+1} ) You Want Type Question (0 ==>  True or False || 1 ==>Mulatble Choise:");
                     

                    } while (!int.TryParse(Console.ReadLine(),out SubChoise) || SubChoise !=0 && SubChoise!=1);
                    Console.Clear();

                    if (SubChoise == 0)
                    {
                        Console.WriteLine("True or False Question");

                        string Question;
                        do
                        {
                            Console.WriteLine("Enter Your Question .");
                            Question = Console.ReadLine();
                        } while (Question?.Length == 0);

                        string correct;
                        do
                        {
                            Console.Write("Enter the correct Answer: ");
                            correct = Console.ReadLine();
                        } while (correct?.Length == 0);
                        
                        Console.Write("Enter the Mark :");
                        int Mark = int.TryParse(Console.ReadLine(), out Mark) ? Mark : 0;
                        Exam.Questions[i] = new ChoiceTrueOrFalse(Question, Mark, correct);
                        
                    }

                    else
                    {
                        Console.WriteLine("Choise Correct Question");

                        string Question;
                        do
                        {
                            Console.WriteLine("Enter Your Question .");
                            Question = Console.ReadLine();
                        } while (Question?.Length == 0);
                        Console.WriteLine("Enter Optional Answer: ");
                        string[] Arr = new string[4];
                        for (int j = 1; j < 4; j++)
                        {
                            do
                            {
                                Console.Write($"Enter The {j} Answer: ");
                                Arr[j] = Console.ReadLine();
                                
                            } while (Arr[j]?.Length == 0);
                        }

                        string correct;
                        do
                        {
                            Console.Write("Enter the correct Answer: ");
                            correct = Console.ReadLine();
                        } while (correct?.Length == 0);
                        Arr[0] = correct;
                        Console.Write("Enter the Mark: ");
                        int Mark = int.TryParse(Console.ReadLine(), out Mark) ? Mark : 0;

                        Exam.Questions[i] = new ChoiceCorrect(Question, Mark, Arr);

                    }
                    Console.Clear();

                }

                Store = Exam;
            }
        }
        public void Start()
        {
            Console.Clear();
     

            Store.start = DateTime.Now;
            if (Store.Questions is not null)
            {


                for (int j = 0; j < Store.Questions.Length; j++)
                {
                    if (Store.Questions[j] is not null)
                    {
                        Store.Questions[j].display();
                        string Answer = Console.ReadLine();
                        Console.WriteLine("================================================");

                        if (Store.Questions[j].answers[0].Answer == Answer)
                        {
                            Store.GBA += Store.Questions[j].Mark;
                        }

                    }
                    else
                        break;
                



            }

            Console.WriteLine("\n End Exam.");
            Console.WriteLine(" ===============================================");
        }
    }


    }

}

