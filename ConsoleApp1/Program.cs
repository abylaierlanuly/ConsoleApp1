using System;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            try
            {


                que.Enqueue(1);
                que.Enqueue(2);
                que.Enqueue(3);
                que.Enqueue(4);
                que.Enqueue(5);
                que.Enqueue(6);
                que.Enqueue(7);
                que.Enqueue(8);
                que.Enqueue(9);
              
             

            }

            catch (QueueEmp)
            {

                Console.WriteLine("Empty");
            }
            catch (QueueEx) {
                Console.WriteLine("Queue Full");
            }
        }
    }

    class QueueEmp : Exception
    {
        public override string Message
        {
            get { return "Queue Empty"; }
        }
    }


    class QueueEx : Exception
    {
        public override string Message
        {
            get
            {
                return "No Place";
            }
        }
    }
    class Note
    {
        public int value;
        public Note next;
        public Note()
        {


        }

    }
    class Queue
    {
        int _count = 0;
        public Note current;
        public Note head;
        public int Counter
        {
            get { return _count; }
        }
        public Queue()
        {

        }
        public void Enqueue(int n)
        {
            if (_count <= 10)
            {
                Note b = new Note();
                b.value = n;
                if (head == null)
                {
                    head = b;
                    current = b;
                    _count++;
                }
                current.next = b;
                current = b;
                _count++;
            }
            else
            {
                throw new QueueEx();
            }
        }

        public int Dequeue()
        {
            if (head != null)
            {
                int GetValue = head.value;
                head = head.next;
                _count--;
                return GetValue;
            }
            else
            {
                throw new QueueEmp();
            }
        }
    }
    }
