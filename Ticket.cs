using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview_of_Stack_and_Queue_Part_2
{
    class Program
    {

        public static void Mains(string[] args)
        {
            Queue qg = new Queue();
            Queue qs = new Queue();
            Person p1 = new Person { type = "G", name = "P1" };
            Person p2 = new Person { type = "G", name = "P2" };
            Person p3 = new Person { type = "G", name = "P3" };
            Person p4 = new Person { type = "G", name = "P4" };
            Person p5 = new Person { type = "S", name = "P5" };
            Person p6 = new Person { type = "S", name = "P6" };
            List<Person> list = new List<Person> { p1, p2, p3, p4, p5, p6 };
            foreach (var k in list)
            {
                if (k.type == "S")
                    qs.Enqueue(k);
                else
                    qg.Enqueue(k);
            }
            Console.WriteLine("------------TICKET COUNTER------------");
            while (true)
            {
                if (qs.Count != 0)
                {
                    Console.WriteLine("Ticket Issued To " + ((Person)qs.Dequeue()).name);
                }
                if (qg.Count != 0)
                {
                    Console.WriteLine("Ticket Issued To " + ((Person)qg.Dequeue()).name);

                    if (qg.Count != 0)
                    {
                        Console.WriteLine("Ticket Issued To " + ((Person)qg.Dequeue()).name);

                    }
                }
                if (qs.Count != 0 && qg.Count == 0)
                {
                    while (qs.Count != 0)
                    {
                        Console.WriteLine("Ticket Issued To " + ((Person)qs.Dequeue()).name);
                         Console.WriteLine("Ticket Issued To " + ((Person)qs.Dequeue()).name);

                    }
                }
                if (qg.Count != 0 && qs.Count == 0)
                {
                    while (qg.Count != 0)
                    {
                        Console.WriteLine("Ticket Issued To " + ((Person)qg.Dequeue()).name);

                    }
                }
                //if (qs.Count == 0 && qg.Count == 0)
                //{
                //    Environment.Exit(1);
                //}
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public string name, type;

    }
}
