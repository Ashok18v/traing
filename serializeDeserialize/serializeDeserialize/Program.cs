using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;





namespace serializeDeserialize
{
    [Serializable]
    public class Student
    {
        public int id { get; set; }

        public string name { get; set; }
        public int age { get; set; }
        public int unitspercost = 10;
        public int marks { get; set; }
    }

        public class customer
        {
       
            public void serialize()
            {

                List<Student> students = new List<Student>();
                Student student1 = new Student();
                student1.id = 1002;
                student1.name = "Rahul Singh";
                student1.age = 21; ;
                student1.marks = 434;
                students.Add(student1);
                Student student2 = new Student();
                student2.id = 1003;
                student2.name = "Rakesh Singh";
                student2.age = 22;
                student2.marks = 469;
                students.Add(student2);
                foreach (Student student in students)
                {
                    Console.WriteLine(student.name);
                }
                FileStream fs = new FileStream(@"C:\visual\text7.txt", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, students);
                fs.Close();

            }
        public void de()
        {
            List<Student> students = new List<Student>();
            FileStream fs =new FileStream(@"C:\visual\text7.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            students = (List<Student>)binaryFormatter.Deserialize(fs);
           fs.Close ();
            foreach (Student student in students)
            {
                Console.WriteLine(student.id);
                Console.WriteLine(student.name);
                Console.WriteLine(student.age);
                Console.WriteLine(student.marks);
                Console.WriteLine();



            }
            
         
        }

            static void Main(string[] args)
            {
            //    customer customer = new customer();
            //customer.serialize();
            //    customer.de();

            show show = new show();
            show.serialize();
            show.deserialize(); 

        }

    }
    }

