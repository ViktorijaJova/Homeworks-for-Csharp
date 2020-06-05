using System;
using System.Collections.Generic;
using System.Text;

namespace quiz.data.Models
{
   public class User
    {

        public string Name { get; set; }
        public int Password { get; set; }

        public bool isTeacher { get; set; }

        public bool TestDone { get; set; }

/*        public List<int>TestsDone { get; set; }
*/
    }
}
