using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataSets
{
    public static class QueueStackHashtablePractice
    {
        //TODO: Extract duplicate code into private functions
        public static void HowToEnqueueAndDequeue()
        {
            var queueExample = new Queue<string>();
            queueExample.Enqueue("Hello");
            queueExample.Enqueue("World");

            Console.WriteLine("Dequeue: ");
            for (int i = 0; i < queueExample.Count + 1; i++)
            {
                Console.WriteLine(queueExample.Dequeue());
            }
        }

        public static void HowToPeekInAQueue()
        {
            var queueExample = new Queue<string>();
            queueExample.Enqueue("Hello");
            queueExample.Enqueue("World");

            Console.WriteLine("Peek: ");
            Console.WriteLine(queueExample.Peek());

            Console.WriteLine("Dequeue: ");
            for (int i = 0; i < queueExample.Count + 1; i++)
            {
                Console.WriteLine(queueExample.Dequeue());
            }
        }

        public static void HowToStack()
        {
            var stackExample = new Stack<string>();

            stackExample.Push("WrapperFunction");
            stackExample.Push("Function");

            Console.WriteLine("Pop: ");
            for (int i = 0; i < stackExample.Count + 1; i++)
            {
                Console.WriteLine(stackExample.Pop());
            }
        }

        public static void HowToHashtable()
        {
            var hashtableExample = new Hashtable(capacity: 3);
            hashtableExample.Add("FirstWord", "Hello");
            hashtableExample.Add(1, "World"); // Keys and values are loosely-typed

            Console.WriteLine(hashtableExample["FirstWord"]);
            Console.WriteLine(hashtableExample[1]);

            if (!hashtableExample.ContainsKey("NonExistentKey"))
            {
                Console.WriteLine("ContainsKey Example");
            }
        }

        public static void HowToDictionary()
        {
            var dictionaryExample = new Dictionary<Guid, string>();
            var helloGuid = Guid.NewGuid();
            var worldGuid = Guid.NewGuid();

            dictionaryExample.Add(helloGuid, "Hello");
            dictionaryExample.Add(worldGuid, "World");

            Console.WriteLine(dictionaryExample[helloGuid]);
            Console.WriteLine(dictionaryExample[worldGuid]);
        }
    }
}
