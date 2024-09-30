using System.Collections.Generic;
namespace College
{
    public class Student
    {
        public int RollNo { set; get; }

        public string StudentName { set; get; }

        public string Email { set; get; }

        public List<Examination> examination { set; get; }=new List<Examination>();
    }
}
