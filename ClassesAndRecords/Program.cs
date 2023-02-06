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

            classroomCourse.Name = "Another title";
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }

    // A record type with 2 properties
    public record CourseRecord(string Name, string Author);
    
}
