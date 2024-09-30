using College;

public class Program
{
    public static void Main()
    {

        List<Student> examlist = new List<Student>();   

        string stdhoice;
        do
        {
            Student s = new Student();
            Console.WriteLine("Please enter roll to add ");
            s.RollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter name to add ");
            s.StudentName = Console.ReadLine();
            Console.WriteLine("Please enter email to add ");
            s.Email = Console.ReadLine();
            //exe1.s

            string ExamChoice;
            do
            {

                Examination exe= new Examination();
                Console.WriteLine("Please enter whic sem  you attaneded");
                exe.ExaminationName = Console.ReadLine();
                Console.WriteLine("Please enter exam year  that you attaneded");
                exe.Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter exam month  that you attaneded");
                exe.Month = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter total exam for in marks");
                exe.MaxMarks = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter marks that you scored");
                exe.SecuredMarks = int.Parse(Console.ReadLine());
                s.examination.Add(exe);
                Console.WriteLine("exam details addedd sucessfulyy do yo wan t add more YEs/No");
                ExamChoice = Console.ReadLine().ToLower() ;
            } while (ExamChoice!="No" && ExamChoice!="n");

            examlist.Add(s);
            Console.WriteLine("student details addess succesfully do you wan add more YES/NO");
            stdhoice = Console.ReadLine().ToLower() ;

        } while (stdhoice!="NO" && stdhoice!="n");

        Console.WriteLine("students details and exam details added sucessfully..!");
        foreach (var item in examlist)
        {
            Console.WriteLine(item.StudentName);
            Console.WriteLine(item.Email);
            Console.WriteLine(item.RollNo);

            foreach (var item1 in item.examination)
            {
                Console.WriteLine(item1.ExaminationName);
                Console.WriteLine(item1.Year);
                Console.WriteLine(item1.Month);
                Console.WriteLine(item1.MaxMarks);
                Console.WriteLine(item1.SecuredMarks);
            }

        }

        Student student = new Student();
        student.RollNo = 1;
        student.StudentName = "ashok";
        student.Email = "ashok@";
        student.examination = new List<Examination>();
        student.examination.Add(new Examination() { ExaminationName="1st sem",Year=2022,Month=06,MaxMarks=1000,SecuredMarks=700});
        student.examination.Add(new Examination() { ExaminationName="2nd sem",Year=2022,Month=12,MaxMarks=1000,SecuredMarks=760});
        student.examination.Add(new Examination() { ExaminationName="3rd sem",Year=2023,Month=06,MaxMarks=100,SecuredMarks=650});
        student.examination.Add(new Examination() { ExaminationName="4th sem",Year=2023,Month=12,MaxMarks=1000,SecuredMarks=780});
        student.examination.Add(new Examination() { ExaminationName="1st sem",Year=2022,Month=02,MaxMarks=100,SecuredMarks=70});
        student.examination.Add(new Examination() { ExaminationName="5th sem",Year=2024,Month=02,MaxMarks=1000,SecuredMarks=800});
        student.examination.Add(new Examination() { ExaminationName="6th sem",Year=2024,Month=12,MaxMarks=1000,SecuredMarks=800});

        Console.WriteLine("Roll:-"+student.RollNo);
        Console.WriteLine("Roll:-" + student.Email);
        Console.WriteLine("Roll:-" + student.StudentName);
        foreach (Examination item in student.examination)  
        {
            Console.WriteLine("Semister exam:-"+item.ExaminationName+",attempted on"+item.Year + "/" + item.Month+"\nMarks Got out of :-"+item.MaxMarks+" is "+item.SecuredMarks);
        }
        Console.ReadKey();

    }
}