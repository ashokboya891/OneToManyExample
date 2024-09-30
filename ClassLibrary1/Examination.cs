using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace College
{
    /// <summary>
    /// Represents examination attempted by student
    /// </summary>

    public class Examination
    {
        public string ExaminationName { set; get; }
        public int Month { set; get; }
        public int Year { set; get; }   
        public int MaxMarks { set; get; }
        public int SecuredMarks { set; get; }
    }
}
