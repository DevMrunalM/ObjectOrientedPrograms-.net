using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    //internal class LeftRotate
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] array = { 1, 2, 3, 4, 5 };
    //        int rotations = 2;

    //        Console.WriteLine("Original Array:");
    //        PrintArray(array);

    //        LeftRotateArray(array, rotations);

    //        Console.WriteLine("\nArray after " + rotations + " left rotations:");
    //        PrintArray(array);
    //    }

    //    static void LeftRotateArray(int[] array, int rotations)
    //    {
    //        int length = array.Length;

            
    //        rotations = rotations % length;

            
    //        int[] temp = new int[length];

            
    //        int index = 0;
    //        for (int i = rotations; i < length; i++)
    //        {
    //            temp[index++] = array[i];
    //        }

            
    //        for (int i = 0; i < rotations; i++)
    //        {
    //            temp[index++] = array[i];
    //        }

            
    //        for (int i = 0; i < length; i++)
    //        {
    //            array[i] = temp[i];
    //        }
    //    }

        
    //    static void PrintArray(int[] array)
    //    {
    //        foreach (int item in array)
    //        {
    //            Console.Write(item + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //}
}
