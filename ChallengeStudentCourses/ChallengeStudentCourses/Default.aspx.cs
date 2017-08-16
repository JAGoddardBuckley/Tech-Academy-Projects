using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.*/



            List<Course> courses = new List<Course>()
           {
                 new Course(){CourseId = 01, Name = "Psychology 101", Students = new List<Student>(){
                     new Student(){StudentId = 4444, Name = "John Holiday", Courses = new List<Course>() },
                     new Student(){StudentId = 4445, Name = "Susan Parker", Courses = new List<Course>()} } },
                 new Course(){CourseId = 02, Name = "Computer Science 102", Students = new List<Student>(){
                    new Student(){StudentId = 4446, Name = "Jordan Baker", Courses = new List<Course>()},
                    new Student(){StudentId = 4447, Name = "Charly Host", Courses = new List<Course>() } } },
                 new Course(){CourseId = 03, Name = "Literature 203", Students = new List<Student>() {
                    new Student(){StudentId = 4448, Name = "Lauren Smith", Courses = new List<Course>() },
                    new Student(){StudentId = 4449, Name = "Karen Jones", Courses = new List<Course>() } } }
           };
            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("<br />Course: {0} -- {1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Student: {0} -- {1}", student.Name, student.StudentId);
                }
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */
            Course course1 = new Course() { CourseId = 01, Name = "Psychology 101" };
            Course course2 = new Course() { CourseId = 02, Name = "Computer Science 102" };
            Course course3 = new Course() { CourseId = 03, Name = "Literature 203" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {4444, new Student { StudentId = 4444, Name = "John Holiday", Courses = new List<Course>
                                   {course1, course2 } } },
                {4448, new Student { StudentId = 4448, Name = "Lauren Smith", Courses = new List<Course>
                                   {course2, course3 } }},
                {4449, new Student { StudentId = 4449, Name = "Karen Jones", Courses = new List<Course>
                                   {course1, course3 } } }


             };
            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br />Student:{0} -- {1}",
                    student.Value.Name,
                    student.Value.StudentId);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Course: {0} -- {1}",
                        course.CourseId,
                        course.Name);
                }
            }
        }
    
        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            Student student = new Student();
            student.StudentId = 4444;
            student.Name = "John Holiday";
            student.Enrollments = new List<Enrolled>()
            {
                new Enrolled {Grade = 90, Course = new Course {CourseId = 1, Name = "Physiology 101"}},
                new Enrolled {Grade = 92, Course = new Course {CourseId = 2, Name = "Chemistry 102"}}
            };
            resultLabel.Text += String.Format("Student: {0} {1}", student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollments)
            {
                resultLabel.Text += String.Format("<br />Enrolled in: {0} -- {1}", 
                    enrollment.Course.Name, 
                    enrollment.Grade);
            }
            Student student1 = new Student();
            student1.StudentId = 4448;
            student1.Name = "Lauren Smith";
            student1.Enrollments = new List<Enrolled>()
            {
                new Enrolled {Grade = 98, Course = new Course {CourseId = 1, Name = "Computer Science 101"}},
                new Enrolled {Grade = 94, Course = new Course {CourseId = 2, Name = "Biology 102"}}
            };
            resultLabel.Text += String.Format("<br /><br />Student: {0} {1}", student1.StudentId, student1.Name);
            foreach (var enrollment in student1.Enrollments)
            {
                resultLabel.Text += String.Format("<br />Enrolled in: {0} -- {1}",
                    enrollment.Course.Name,
                    enrollment.Grade);
            }
        }
    }
}