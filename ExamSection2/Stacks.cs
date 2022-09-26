using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSection2
{
    internal class Stacks
    {
        public static void createStack()
        {
            //Stack named teams that contains strings
            Stack<string> teams = new Stack<string>();
            //Pushing strings onto the stack
            teams.Push("Statement 1");
            teams.Push("Statement 2");
            teams.Push("Statement 3");
            teams.Push("Statement 4");
            teams.Push("Statement 5");
            //Retrieve the first item in the stack and store it in a string variable named team
            //Peek keeps the item in the stack
            string team = teams.Peek();
            Console.WriteLine("\nThe first statement in the stack is : " + team + "\n");

            //Loop showing all items still in stack
            foreach (var stackItem in teams)
            {
                Console.WriteLine(stackItem);
            }
        }
    }
}
