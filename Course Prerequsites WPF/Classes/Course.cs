using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Course_Prerequsites_WPF.Classes
{
    public class Course
    {
        public string Code { get; set; }
        public string CourseName { get; set; }
        public int MaximumNumberOfStudents { get; set; }
        public int CurrentNumberOfStudents { get; set; }
        public int PassingGrade { get; set; }
        public int CourseGrade { get; set; }
        public int Hours { get; set; }
        public string Instructor { get; set; }
        public string Description { get; set; }
        public List<string> PreRequiredCourses { get; set; }

        public Course()
        {
            Code = "";
            CourseName = "";
            MaximumNumberOfStudents = 0;
            CurrentNumberOfStudents = 0;
            PassingGrade = 0;
            CourseGrade = 0;
            Hours = 0;
            Instructor = "";
            Description = "";
        }

        public Course(string code, string coursename, int Maximumnumber, int CurrentNumber, int passinggrade, int coursegrade, int hours, string instructor, string description, List<string> pre)
        {
            Code = code;
            CourseName = coursename;
            MaximumNumberOfStudents = Maximumnumber;
            CurrentNumberOfStudents = CurrentNumber;
            PassingGrade = passinggrade;
            CourseGrade = coursegrade;
            Hours = hours;
            Instructor = instructor;
            Description = description;
            PreRequiredCourses = new List<string>();

            foreach (var item in pre)
            {
                PreRequiredCourses.Add(item);
            }
        }

        public Dictionary<string, Course> GetAllCourses()
        {
            FileStream fs = new FileStream("AllCoursesFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            // 3 string arrays 
            string[] fileds;
            string[] records;
            string[] prerequirds;

            //list of prerequired courses 
            List<string> pr = new List<string>();

            //List of objects <this is the return of the function>
            Dictionary<string, Course> M = new Dictionary<string, Course>();

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
                    MaximumNumberOfStudents = Convert.ToInt32(fileds[2]);
                    CurrentNumberOfStudents = Convert.ToInt32(fileds[3]);
                    PassingGrade = Convert.ToInt32(fileds[4]);
                    CourseGrade = Convert.ToInt32(fileds[5]);
                    Hours = Convert.ToInt32(fileds[6]);
                    Instructor = fileds[7];
                    Description = fileds[8];

                    //creates an array of the PreREquried subjects 
                    prerequirds = fileds[9].Split('*');

                    //fills the array that exists in the class with the one in the file
                    for (int j = 0; j < prerequirds.Length; j++)
                    {
                        pr.Add(prerequirds[j]);
                    }
                    //Creates a costume obkject of the courses cllass 
                    Course c = new Course(Code, CourseName, MaximumNumberOfStudents, CurrentNumberOfStudents, PassingGrade, CourseGrade, Hours, Instructor, Description, pr);

                    //adds it ot the list pf Courss
                    M[CourseName] = c;

                }


            }

            //returns list of objs
            return M;

        }

        //Function to give a certain course with all it's information
        public Course ReturnObj(string Name)
        {
            Dictionary<string, Course> Objects = GetAllCourses();//Read all Courses from file in alist using this funtion

            bool check = false;//To chaeck if this course exist or not

            foreach (var x in Objects)//loop to search for certaion subjects in all the subjects
            {
                if (x.Key == Name)
                {
                    check = true;
                    return x.Value;
                }
            }
            if (check == false)
            {
                return null;
            }
            else return null;
        }

    }

}
