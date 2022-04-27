using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProgramsProblem
{
    public class MaxInArray
    {
        public void MaxNumber(int[] intArray)
        {
            foreach(int element in intArray)
            {
                Console.WriteLine(element+" ");
            }
            Console.WriteLine(" ");
            Array.Sort(intArray);
            int length = intArray.Length;
            Console.WriteLine("Maximum Number In This Array Is :" + intArray[length - 1]);
        }
    }
}
