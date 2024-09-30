using College;

public class Program
{
    public static void Main()
    {
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