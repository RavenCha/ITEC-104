/*
 * Created by SharpDevelop.
 * User: Raven
 * Date: 10/26/2022
 * Time: 12:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace ENGAGING_ACTIVITY
{
    class Program
    {
        static void Main(string[] args)
        {
              Stack st = new Stack();
            st.Push("E");
            st.Push("V");
            st.Push("A");
            st.Push("R");
            Console.WriteLine("Current stack: ");
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            st.Push("C");
            st.Push("N");
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing values");
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("Current stack: ");
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey(true);
        }
    }
}
