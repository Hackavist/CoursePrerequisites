using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Course_Prerequsites_WPF.Classes
{
    class Course
    {
        public string Code { get; set; }
        public string CourseName { get; set; }
        public string MaximumNumberOfStudents { get; set; }
        public string PassingGrade { get; set; }
        public string CourseGrade { get; set; }
        public string Hours { get; set; }
        public string Instructor { get; set; }
        public string Description { get; set; }
        public List<string> PreRequiredCourses { get; set; }


        Course(string code, string coursename, string Maximumnumber, string passinggrade, string coursegrade, string hours, string instructor, string description, List<string> pre)
        {
            Code = code;
            CourseName = coursename;
            MaximumNumberOfStudents = Maximumnumber;
            PassingGrade = passinggrade;
            CourseGrade = coursegrade;
            Hours = hours;
            Instructor = instructor;
            Description = description;
            PreRequiredCourses = pre;
        }


        public List<Course> AllCourses()
        {
            FileStream fs = new FileStream("ReadingTrial.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string[] fileds;
            string[] records;
            string[] prerequirds;

            List<string> pr = new List<string>();
            List<Course> l = new List<Course>();

            while (sr.Peek() != -1)
            {
                records = sr.ReadLine().Split('#');

                for (int i = 0; i < records.Length - 1; i++)
                {
                    fileds = records[i].Split('%');

                    Code = fileds[0];
                    CourseName = fileds[1];
                    MaximumNumberOfStudents = fileds[2];
                    PassingGrade = fileds[3];
                    CourseGrade = fileds[4];
                    Hours = fileds[5];
                    Instructor = fileds[6];
                    Description = fileds[7];
                    prerequirds = fileds[8].Split('*');

                    for (int j = 0; j < prerequirds.Length; j++)
                    {
                        pr.Add(prerequirds[j]);
                    }
                }

                Course c = new Course(Code, CourseName, MaximumNumberOfStudents, PassingGrade, CourseGrade, Hours, Instructor, Description, PreRequiredCourses);
                l.Add(c);
            }

            return l;

        }
        //Function to give a certain course with all it's information
        public Course ObjectDetails(string Name)
        {
            List<Course> Objects = AllCourses();//Read all Courses from file in alist using this funtion
            bool check = false;//To chaeck if this course exist or not
            foreach (Course x in Objects)//loop to search for certaion subjects in all the subjects
            {
                if (x.CourseName == Name)
                {
                    check = true;
                    return x;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Not Found!!");
                return null;
            }
            else return null;
        }

    }

}
