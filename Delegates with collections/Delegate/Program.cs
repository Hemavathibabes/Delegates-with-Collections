using System;
using System.Collections.Generic;



namespace Delegate
{
    class student
    {
        public int id { get; set; }
        public String name { get; set; }
        public string bloodgroup { get; set; }
        public float fees { get; set; }
    }

    class Operation
    {
       
        public void Getname(List<student> st)
        {
            int c = 0;
            foreach (student s in st)
            {
                if (s.bloodgroup == "A Negative")
                {
                    Console.WriteLine("The person with a A Negative blood group is {0}", s.name);
                    c = 1;
                }
               
            }
            if(c==0)
            {
                Console.WriteLine("No students have a blood group of A Negative");
            }
        }
        public  void GetId(List<student> st)
        {
            Console.WriteLine("The student whose fees is higher than 20000");
            foreach (student s in st)
            {
                if (s.fees> 20000)
                {
                    Console.WriteLine(s.name + " " + s.id + " ");
                   
                }
                
            }
        }
     
    }
  
    class Program
    {

        public delegate void del(List<student> students);
        static void Main(string[] args)
        {
            List<student> stu = new List<student>()
            {
                new student() { id = 101, name = "Harry", bloodgroup = "A1B Negative", fees = 23000.30f },
                new student() { id = 102, name = "Hermoini", bloodgroup = "B Negative", fees = 33000.60f },
                new student() { id = 103, name = "Walter", bloodgroup = "A Pasitive", fees = 20000.80f },
                new student() { id = 104, name = "Priyal", bloodgroup = "A Negative", fees = 12000.40f },
                new student() { id = 105, name = "Nick", bloodgroup = "B pasitive", fees = 40000.00f },
            };

            //using Delegates
            Operation op = new Operation();
            del myobj1 = new del(op.Getname);
           // myobj(stu);
            del myobj2 = new del(op.GetId);
            // myobj(stu);



            //using multicase Delegates
            del myobj = myobj1 + myobj2;
            myobj(stu);
           
          
        }
    }
}
