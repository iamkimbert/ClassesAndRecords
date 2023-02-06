using System;
/* 
 * A class is a referance type. The variable pluralsightCourse is declared. The variable itself doesn't
 * contain the object. It only refers to the object that is located in memory. If a second variable is created
 * to be equal to the first, only the reference will be copied. Not the object itself. 
 * 
 * When you change the value of a property for a variable, that change is visible to the other variable because
 * it is just a reference to the same object.
 * 
 * The alternative to a reference type is a value type. This does copy its contents when it is assigned to
 * another variable. Examples of value types are interger, struct, and enum. They are more efficient than
 * value types because copying isn't necessary. A record is a reference type just like a class. 
 * 
 * A Record instance is Immutable. Its values cannot be changed once the object is constructed.
 * 
 * */
namespace ClassesAndRecords
{
    class Program
    {



        static void Main(string[] args)
        {
            var pluralsightCourse = new Course();
            pluralsightCourse.Name = "Working with C# Records";
            pluralsightCourse.Author = "Roland Guijt";

            var classroomCourse = new CourseRecord(
                "Working with C# Records",
                "Roland Guijt"
                );

            //var name = classroomCourse.Name;
            //var author = classroomCourse.Author;
            //var (name, author) == classroomCourse;
            //Console.WriteLine(name);
            //Console.WriteLine(author);

            //classroomCourse.Name = "Somethingelse";
            //var anotherCourse = classroomCourse with { Name = "C# Getting Started" };

            //var title = classroomCourse.GetTitle();
            var (name, author) = classroomCourse;
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public void Deconstruct(out string name, out string author)
        {
            name = Name;
            author = Author;
        }
    }
    public record CourseRecord(string Name)
    {
        // A record type with 2 properties
        //public record CourseRecord(string name, string author) : this()
        //{ 
        //    Name=name;
        //    Author = author; 
        //}

       // public string Name { get; init; }
        public string Author { get; init; }
        //public string GetTitle()
        public string Title
        {
            get
            {
                return $"{Name} - {Author}";
            }
        }
    }
}
