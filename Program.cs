using System;
using System.Collections.Generic;

namespace TASK2
{
    public class SubjectClass
    {
        public string Name;
        public string YearOfDelivery;
    }
    public class Person
    {
        public int id;
        public string firstname;
        public string surname;
        public int dob;
        public int height;
        public string color;
        public int idnumber;
        public List<SubjectClass> Subjects;
        public Person()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000, 9999);
            this.Subjects = new List<SubjectClass>();
        }
        public string GetFullName()
        {
          return this.firstname + " " + this.surname;
        }
        public string GetHeightDifference(Person OtherPerson)
        {
            int heightVariance = this.height - OtherPerson.height;
            string myStr = "Difference in height between " + this.firstname + " and " + OtherPerson.firstname + " is " + heightVariance.ToString();
            return myStr;
        }
        public void addSubject(string subjectName,string subjectYear)
        {
            SubjectClass mySubject = new SubjectClass();
            mySubject.Name = subjectName;
            mySubject.YearOfDelivery = subjectYear;
            this.Subjects.Add(mySubject);
        }
        public void listSubjects()
        {
            foreach ( SubjectClass i in this.Subjects )
            {
                Console.WriteLine(this.GetFullName() + " performing subject: " + i.Name);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(); 
        
            p1.firstname = "Marina";
            p1.surname = "Pajvancic";
            p1.height = 162;
            p1.addSubject("Maths","2020");
            p1.addSubject("Physics","2020");
            Console.WriteLine(p1.GetFullName()); 
            
            Person p2 = new Person(); 
            p2.firstname = "Naomi";
            p2.surname = "Campbell";
            p2.height = 185;
            Console.WriteLine(p2.GetFullName()); 
            Person p3 = new Person(); 
            p3.firstname = "George";
            p3.surname = "Clooney";
            p3.height = 190; 
            Console.WriteLine(p3.GetFullName());
            Console.WriteLine(p1.GetHeightDifference(p2));
            Console.WriteLine(p2.GetHeightDifference(p3));
            Console.WriteLine(p3.GetHeightDifference(p1));
            p1.listSubjects();
        }
    }
}
