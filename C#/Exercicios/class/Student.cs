public class Student : Person{
    private int nCourses = 0;
    private string[] courses;
    private int[] grades;

    public Student(string name, string address) : base(name, address){
        courses = new string[10];
        grades = new int[10];
    }

    public void AddCourseGrade(string course, int grade){
        courses[nCourses] = course;
        grades[nCourses] = grade;
        nCourses++;
    }

    public void PrintGrades(){
        for (int i = 0; i < nCourses; i++){
            Console.WriteLine($"{courses[i]}: {grades[i]}");
        }
    }

    public double GetAvarageGrade(){
        double sum = 0;
        for (int i = 0; i < nCourses; i++){
            sum += grades[i];
        }
        return sum / nCourses;
    }

    public override string ToString(){
        return $"Student: {GetName()} ({GetAddress()})";
    }

}