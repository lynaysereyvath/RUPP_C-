using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show16
{

    //public delegate void delshow();
    public delegate bool delegatePassStudent(Student s);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //delshow obj = new delshow(show);
            //obj();

            delegatePassStudent dp = new delegatePassStudent(isPassed);

            List<Student> obj = new List<Student>();
            obj.Add(new Student("James", 50));
            obj.Add(new Student("Koko", 67));
            obj.Add(new Student("Momo", 45));
            obj.Add(new Student("Mina", 90));
            obj.Add(new Student("Panda", 30));
            obj.Add(new Student("Mongo", 70));

            Student.passedStudents(obj, dp);

        }
        void show()
        {
            MessageBox.Show("This is show function");
        }

        bool isPassed(Student s)
        {
            if (s.avg > 50) return true;
            else return false;
        }

    }

    public class Student
    {
        public string name;
        public double avg;
        public Student(string n, double a)
        {
            name = n; avg = a;
        }

        public static void passedStudents(List<Student> students, delegatePassStudent dp)
        {
            foreach(Student student in students)
            {
                if(dp(student))
                {
                    MessageBox.Show("Name: " + student.name + " Average: " + student.avg);
                }
            }
        }
    }

    
}
