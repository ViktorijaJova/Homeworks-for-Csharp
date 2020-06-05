using System;
using System.Collections.Generic;
using System.Text;

namespace quiz.data.Models
{
   public class Question


    {
        public string Questions { get; set; }
        public string FirstChoice { get; set; }
        public string SecondChoice { get; set; }
        public string ThirdChoice { get; set; }
        public string ForthChoice { get; set; }
        public int Corect { get; set; }

        public List<int> answers { get; set; }




    }
}
