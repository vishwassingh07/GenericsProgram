using GenericProgramsProblem;
using System;
namespace GenericProgramProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = {143,432,543,6944,5555};
            MaxInArray array = new MaxInArray();
            array.MaxNumber(intArr); 
        }
    }
}