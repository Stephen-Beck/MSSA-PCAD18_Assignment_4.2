using System.ComponentModel;

namespace Assignment_4._2
{
    public class Student
    {
        public uint ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float GPA { get; set; }

        public static BindingList<Student> PopulateStudents()
        {
            return new BindingList<Student>
            {
                new Student() {ID = 0, FirstName = "Billy",   LastName = "Windows", GPA = 3.7f},
                new Student() {ID = 1, FirstName = "Tim",     LastName = "Apple",   GPA = 3.5f},
                new Student() {ID = 2, FirstName = "Linus",   LastName = "Linux",   GPA = 4.0f},
                new Student() {ID = 3, FirstName = "Mark",    LastName = "Zuckbook",GPA = 2.5f},
                new Student() {ID = 4, FirstName = "Satoshi", LastName = "Bitcoin", GPA = 3.0f}
            };
        }
    }
}
