using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // New for Module 6 - Inheritance
                Console.WriteLine("Module 6 code: Inheritance");
                Teacher teacher = new Teacher("Stephen", "Hawking", new DateTime(1942, 1, 8));
                Student student = new Student("Don't", "AddMe", new DateTime(2000, 1, 1));

                teacher.GoAboutMyDay();
                Console.WriteLine("\n");
                student.GoAboutMyDay();
                Console.WriteLine("\n\n");

                // Old Module 5 code still works
                Console.WriteLine("Module 5 code: Classes");
                Course course = new Course("Programming with C#", 3, 12);

                course.AddStudent(new Student("Johnny", "Doe", new DateTime(1998, 1, 1)));
                course.AddStudent(new Student("Suzy", "Smith", new DateTime(1998, 1, 31)));
                course.AddStudent(new Student("Debbie", "Downer", new DateTime(1998, 1, 15)));

                // This student should not be added - course is full
                course.AddStudent(student);

                course.AddTeacher(teacher);
                Degree degree = new Module.Degree("Bachelor of Science", 30);
                degree.AddCourse(course);

                UProgram uProgram = new UProgram("Information Technology");

                Console.WriteLine("The {0} program contains the {1} degree.", uProgram.ProgramName, degree.DegreeName);
                Console.WriteLine("The {0} degree contains the course {1}.", degree.DegreeName, course.CourseName);
                Console.WriteLine("The {0} course contains {1} students.", course.CourseName, course.EnrolledStudentCount);


                Console.WriteLine("\n\nThis is a little extra clarification.");
                // This shows the number of students enrolled in the school
                Console.WriteLine("The school has {0} students enrolled.", Student.EnrolledStudents);
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Oops.  Please pardon our appearance.  This feature has not yet been implemented: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nHit any key to terminate the program.");
            Console.ReadKey();
        }
    }
}