using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp.src {
    class Person {
        protected string name;
        protected int age;

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public virtual void Show() {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Student : Person {
        protected int studentID;

        public Student(string name, int age, int studentID) : base(name, age) {
            this.studentID = studentID;
        }

        public override void Show() {
            base.Show();
            Console.WriteLine($"Student ID: {studentID}");
        }
    }

    class Teacher : Person {
        protected string subject;

        public Teacher(string name, int age, string subject) : base(name, age) {
            this.subject = subject;
        }

        public override void Show() {
            base.Show();
            Console.WriteLine($"Teaches: {subject}");
        }
    }

    class DepartmentHead : Teacher {
        protected string department;

        public DepartmentHead(string name, int age, string subject, string department) : base(name, age, subject) {
            this.department = department;
        }

        public override void Show() {
            base.Show();
            Console.WriteLine($"Department: {department}");
        }
    }
}
