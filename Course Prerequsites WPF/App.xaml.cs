using System;
using System.Windows;
using System.IO;
using Course_Prerequsites_WPF.Classes;

namespace Course_Prerequsites_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                // Write the Courses Dictionary in file 
                void WriteObj(Course cour)
                {
                    if (cour != null)
                    {
                        int c = 0;
                        FileStream File = new FileStream("AllCoursesFile.txt", FileMode.Append, FileAccess.Write);
                        StreamWriter Sw = new StreamWriter(File);

                        Sw.Write(cour.Code);
                        Sw.Write('%');
                        Sw.Write(cour.CourseName);
                        Sw.Write('%');
                        Sw.Write(Convert.ToString(cour.MaximumNumberOfStudents));//converts the intgers to strings then writes them in the file 
                        Sw.Write('%');
                        Sw.Write(Convert.ToString(cour.CurrentNumberOfStudents));//converts the intgers to strings then writes them in the file 
                        Sw.Write('%');
                        Sw.Write(Convert.ToString(cour.PassingGrade));//converts the intgers to strings then writes them in the file 
                        Sw.Write('%');
                        Sw.Write(Convert.ToString(cour.CourseGrade));//converts the intgers to strings then writes them in the file 
                        Sw.Write('%');
                        Sw.Write(Convert.ToString(cour.Hours));//converts the intgers to strings then writes them in the file 
                        Sw.Write('%');
                        Sw.Write(cour.Instructor);
                        Sw.Write('%');
                        Sw.Write(cour.Description);
                        Sw.Write('%');

                        //loops on the list of prequsites and add '*' delimiter between them
                        foreach (var item in cour.PreRequiredCourses)
                        {
                            c++;
                            Sw.Write(item);
                            if (c != cour.PreRequiredCourses.Capacity - 1)
                            {
                                Sw.Write('*');
                            }
                        }

                        //end of record dilimter
                        Sw.Write('#');

                        //closes the stream writer and the file stream 
                        Sw.Close();
                        File.Close();
                    }
                    else
                    {
                        //throws an exceptions that says Unimplmented 
                        throw new NotImplementedException();
                    }
                }
            }
            finally
            {
                base.OnExit(e);
            }
        }

    }
}
