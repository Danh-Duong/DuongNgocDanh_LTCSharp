using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstMidName109="Carson",LastName109="Alexander",EnrollmentDate109=DateTime.Parse("2019-09-01")},
                new Student{FirstMidName109="Meredith",LastName109="Alonso",EnrollmentDate109=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName109="Arturo",LastName109="Anand",EnrollmentDate109=DateTime.Parse("2018-09-01")},
                new Student{FirstMidName109="Gytis",LastName109="Barzdukas",EnrollmentDate109=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName109="Yan",LastName109="Li",EnrollmentDate109=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName109="Peggy",LastName109="Justice",EnrollmentDate109=DateTime.Parse("2016-09-01")},
                new Student{FirstMidName109="Laura",LastName109="Norman",EnrollmentDate109=DateTime.Parse("2018-09-01")},
                new Student{FirstMidName109="Nino",LastName109="Olivetto",EnrollmentDate109=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID109=1050,Title109="Chemistry",Credits109=3},
                new Course{CourseID109=4022,Title109="Microeconomics",Credits109=3},
                new Course{CourseID109=4041,Title109="Macroeconomics",Credits109=3},
                new Course{CourseID109=1045,Title109="Calculus",Credits109=4},
                new Course{CourseID109=3141,Title109="Trigonometry",Credits109=4},
                new Course{CourseID109=2021,Title109="Composition",Credits109=3},
                new Course{CourseID109=2042,Title109="Literature",Credits109=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID109=1,CourseID109=1050,Grade109=Grade.A},
                new Enrollment{StudentID109=1,CourseID109=4022,Grade109=Grade.C},
                new Enrollment{StudentID109=1,CourseID109=4041,Grade109=Grade.B},
                new Enrollment{StudentID109=2,CourseID109=1045,Grade109=Grade.B},
                new Enrollment{StudentID109=2,CourseID109=3141,Grade109=Grade.F},
                new Enrollment{StudentID109=2,CourseID109=2021,Grade109=Grade.F},
                new Enrollment{StudentID109=3,CourseID109=1050},
                new Enrollment{StudentID109=4,CourseID109=1050},
                new Enrollment{StudentID109=4,CourseID109=4022,Grade109=Grade.F},
                new Enrollment{StudentID109=5,CourseID109=4041,Grade109=Grade.C},
                new Enrollment{StudentID109=6,CourseID109=1045},
                new Enrollment{StudentID109=7,CourseID109=3141,Grade109=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}