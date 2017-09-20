namespace ExamLib
{
    public class Student
    {
        public string studentNamn;

        public Student(string studentNamn)
        {
            this.studentNamn = studentNamn;
        }

        public override string ToString()
        {
            return this.studentNamn;
        }
    }
}