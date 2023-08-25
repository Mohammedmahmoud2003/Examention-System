using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mainprog.Classes
{
    class Answers
    {
        #region property
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value > 0 ? value : -1; }
        }
        public string Answer { get; set; }
        #endregion

        #region Consterctor
        public Answers()
        {
            id = -1;
            Answer = "No answer";
        }
        public Answers(int _Id, string _Answer)
        {
            Id = _Id;
            Answer = _Answer;
        }
        #endregion

    }
}
