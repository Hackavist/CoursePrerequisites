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

            // 3 string arrays 
            string[] fileds;
            string[] records;
            string[] prerequirds;

            //list of prerequired courses 
            List<string> pr = new List<string>();

            //List of objects <this is the return of the function>
            List<Course> l = new List<Course>();

            while (sr.Peek() != -1)
            {
                //splits the inputs into Courses (using the # delimter)
                records = sr.ReadLine().Split('#');

                //loops until it reaches the number of courses

                for (int i = 0; i < records.Length - 1; i++)
                {
                    //splits each course into number of feilds  
                    fileds = records[i].Split('%');
                    //the course details
                    Code = fileds[0];
                    CourseName = fileds[1];
                    MaximumNumberOfStudents = fileds[2];
                    PassingGrade = fileds[3];
                    CourseGrade = fileds[4];
                    Hours = fileds[5];
                    Instructor = fileds[6];
                    Description = fileds[7];

                    //creates an array of the PreREquried subjects 
                    prerequirds = fileds[8].Split('*');

                    //fills the array that exists in the class with the one in the file
                    for (int j = 0; j < prerequirds.Length; j++)
                    {
                        pr.Add(prerequirds[j]);
                    }
                }


                //Creates a costume obkject of the courses cllass 
                Course c = new Course(Code, CourseName, MaximumNumberOfStudents, PassingGrade, CourseGrade, Hours, Instructor, Description, PreRequiredCourses);

                //adds it ot the list pf Courss
                l.Add(c);
            }

            //returns list of objs
            return l;

        }


    }
}
