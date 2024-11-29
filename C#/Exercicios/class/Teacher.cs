using System.Security.Authentication;

public abstract class Teacher : Person {
    private int nCourses = 0;
    private string[] courses = {};

    public Teacher(string name, string address) : base(name, address) {
        this.courses = new string[10];
    }

    public bool AddCourse(string courses){
        for(int i = 0; i < nCourses; i++){
            if(this.courses[i].Equals(courses)){
                return false;
            }
        }
        this.courses[nCourses] = courses;
        this.nCourses++;
        return true;
    } 
}