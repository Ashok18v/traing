using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Bank_System
{
    internal class library
    {

        int i = 0;
        string[] name = new string[5];
        string[] abc = new string[5];
        
        public void writeflies()
        {
 
           FileStream fs = new FileStream(@"C:\visual\books.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fs);
           
            name[0] = "Book Name:C sharp";
            name[1] = "Book Name:Python";
            name[2] = "Book Name:SQL";
            name[3] = "Book Name:Java";
            name[4] = "Book Name:CP";
            for(int i = 0; i < 5; i++)
            {
                streamWriter.WriteLine(name[i]);
                
            }streamWriter.Close();
            fs.Close();
        }
        public void writefile()
        {
            FileStream fs = new FileStream(@"C:\visual\user_details.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter= new StreamWriter(fs);
            abc[0]  = "user id:101"+"\n"+
                "Name:Ashok" + "\n" +
                "Branch:ECE";
            abc[1] = "user id:102" + "\n" +
                "Name:Sai" + "\n" + 
                "Branch:ECE";
            abc[2] = "user id:103" + "\n" +
                "Name:Venkat" + "\n" +
                "Branch:ECE";
            abc[3] = "user id:104" + "\n" +
                "Name:Ajay" + "\n" +
                "Branch:CSE";
            abc[4] = "user id:105" + "\n" +
                "Name:Avinash" + "\n" +
                "Branch:ECE";
            for(int i = 0; i < abc.Length; i++)
            {
                streamWriter.WriteLine(abc[i]);
                streamWriter.WriteLine("\n");
                
            }streamWriter.Close();
            fs.Close();

        }
        public void bookissue()
        {
            FileStream fileStream = new FileStream(@"C:\visual\book_issue.txt", FileMode.Create, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(fileStream);
            Console.WriteLine("search the book" + "\n" + "Enter the Book name:");
            string a=Console.ReadLine();
            for (int i = 0; i < 5; i++)
            { 
                if (name[i].Contains(a))
                {
                    
                    fileWriter.WriteLine(name[i]);
                    
                    Console.WriteLine("Enter the user id");
                    String b =(Console.ReadLine());
                    for(int j = 0; j < 5; j++)
                    {
                        if (abc[j].Contains(b)) {
                            fileWriter.WriteLine(abc[i]);
                            string dateTime = DateTime.Now.ToShortDateString();
                            fileWriter.WriteLine("Issued date:"+dateTime);
                            Console.WriteLine("Return date(mm/dd/yy):");
                            string return_date = Console.ReadLine();
                            fileWriter.WriteLine("Return date:"+return_date);    
                        }
                    }
                }   
            }
            fileWriter.Close();
            fileStream.Close();
        }
        public void mange_invetory()
        {
            FileStream stream = new FileStream(@"C:\visual\mange_invetory.txt", FileMode.Create,FileAccess.Write);
            StreamWriter stream1=new StreamWriter(stream);
            stream1.WriteLine("Avaliable Book in Library:");
            for (int i = 0; i < 5; i++)
            {
                stream1.WriteLine(name[i]);
            }stream1.WriteLine("Users details");
            for (int i = 0; i < 5; i++)
            {
                stream1.WriteLine(abc[i]);
            }
            
            stream1.Close();
            stream.Close();
        }
        public void ss()
        {
            Console.ReadLine();
            Console.WriteLine(abc[0]);
        }
        




        static void Main(string[] args)
        {
            library library = new library();
          //  library.writefile();
           //  library.writeflies();
          //  library.bookissue();
           // library.mange_invetory();
            library.ss();
        }
    }
}
