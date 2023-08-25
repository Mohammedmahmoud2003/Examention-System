using Mainprog.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mainprog.Inheritence
{
    abstract class Quetions
    {

        #region Property
        protected string questionHeader;
        public string QuestionHeader
        {
            get { return questionHeader ?? "No Question"; }
            set { questionHeader = value; }

        }


        protected int mark = 0;

        public abstract int Mark
        {
            get;
            set;
        }

        #endregion
        public Quetions(string _questionHeader, int _mark)
        {
            QuestionHeader = _questionHeader;
            Mark = _mark;
        }
        public abstract Answers[] answers { get; set; }
        public abstract  void display();
    }
}
