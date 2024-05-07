using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text
{
    internal class Gs
    {
        internal class Gets
        {
            public Gets(string Title, string Describe, string Answer1, string Answer2, Enum Correct_answer)
            {
                title = Title;
                describe = Describe;
                answer1 = Answer1;
                answer2 = Answer2;
                correct_answer = Correct_answer;
            }

            public string title { get; set; }
            public string describe { get; set; }
            public string answer1 { get; set; }
            public string answer2 { get; set; }
            public Enum correct_answer { get; set; }


        }
    }
}
