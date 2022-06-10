using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace serialize
{
    [Serializable]
    class student
    {
        public int stdid;
        public string std_name;
        public double std_value;
     
        public void ser()
        { 
            DateTime d = DateTime.Now;
            string str = Convert.ToString(d);
            FileStream fs = new FileStream(@"C:\visual\seralize.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
           
            formatter.Serialize(fs, str);
            fs.Close();
        }
        public void de()
        {
            string data;
            FileStream fs = new FileStream(@"C:\visual\seralize.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            data = (string)formatter.Deserialize(fs);
            Console.WriteLine(data);
            fs.Close();
        }
        // student(int id, string name,double value)
        // {
        //    stdid = id;
        //     std_name = name;
        //    double std_value=value;


        // class pro
        // {
        //   public void serial()
        //  {
        //     student obj = new student(101, "Veera Ashok",9.5D);
        //      FileStream fs = new FileStream(@"C:\visual\deserial.txt", FileMode.Create);
        //      BinaryFormatter bf = new BinaryFormatter();
        //      bf.Serialize(fs,obj);
        //      fs.Close();
        //    }
        //   public void dese()
        //   {
        //      student std;
        //FileStream fileStream = new FileStream(@"C:\visual\deserial.txt", FileMode.Open);
        //  BinaryFormatter binaryFormatter = new BinaryFormatter();
        //    std=(student)binaryFormatter.Deserialize(fileStream);
        //      int id=std.stdid;
        //        string name=std.std_name;
        // 
        //    double valu=std.std_value;
        //      Console.WriteLine("std_id:" + id);
        // Console.WriteLine("std_name:"+name);
        //   Console.WriteLine(valu);
        //     fileStream.Close();
        //   }



        static void Main(string[] args)
        {
            student program = new student();
            program.ser();
            program.de();
            //  pro pro = new pro();
            //   pro.serial();
            //      pro.dese();


        }
    }
}

