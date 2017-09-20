using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Exam
    {
        private string courseName;
        private Dictionary<Student, string> StudentGradeDictionary = new Dictionary<Student, string>();

        public Exam(string courseName)
        {
            this.courseName = courseName;
        }

        public void Assign(Student studentNamn)
        {
            StudentGradeDictionary.Add(studentNamn, "");
        }

        public void Grade(Student student, string grade)
        {
            if(!StudentGradeDictionary.ContainsKey(student))
                throw new UnassignedStudentException();

            StudentGradeDictionary[student] = grade;
        }

        public Dictionary<string, int> GenerateStatistics()
        {
            var result = new Dictionary<string, int>();
            result.Add("VG", 0);
            result.Add("G", 0);
            result.Add("IG", 0);

            foreach (var grade in StudentGradeDictionary)
            {
                result[grade.Value]++;
            }

            return result;
        }
    }

}

