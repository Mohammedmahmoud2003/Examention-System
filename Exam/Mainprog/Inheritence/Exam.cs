using Mainprog.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mainprog.Inheritence
{
    abstract  class Exam
    {
        public int TimeOfExam { get; set; }
        public DateTime start;
        public int GBA = 0;
        public abstract Quetions[] Questions { get; set; }
        public int NumberOfQuestion { get; set; }
        public Exam(int _NumberOfQuestion,int _TimeOfExam)
        {
            TimeOfExam = _TimeOfExam;
            NumberOfQuestion = _NumberOfQuestion;              
        }
        public abstract void ShowExamFunctionlity();
        

    }
}
