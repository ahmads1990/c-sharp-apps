using System;
using System.Runtime.InteropServices;

namespace ArrayFlatten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array3Da = new int[2, 2, 3] {
                { { 1, 2, 3 }, { 4, 5, 6 } },
                { { 7, 8, 9 }, { 10, 11, 12 } } };

            foreach (var item in array3Da)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("/////");
            int[] test1 = flatten3DArray(array3Da);
            foreach (var item in test1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("/////");
            int[,,] expanded = Expand1DArray(test1, 2, 2);
            foreach (var item in expanded)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("/////");
        }

        public static T[] flatten3DArray<T>(T[,,] array3d)
        {
            int sizeOfArr = array3d.GetLength(0) * array3d.GetLength(1) * array3d.GetLength(2);
            T[] newArray = new T[sizeOfArr];
            Type type = newArray.GetType();
            type = type.GetElementType();
            var sizeOfElementType = Marshal.SizeOf(type);
            Buffer.BlockCopy(array3d, 0, newArray, 0, sizeOfArr * sizeOfElementType);
            return newArray;
        }
        public static T[,,] Expand1DArray<T>(T[] array1d, int height, int width)
        {
            int length = array1d.GetLength(0);
            int breadth = (int)Math.Ceiling((double)(length / (height * width)));

            T[,,] newArray = new T[height, width, breadth];
            int x, y, z;
            for (int i = 0; i < length; i++)
            {
                int rem;
                if (Math.DivRem(i,height,out rem) ==0){x = rem+1;}
                else { x = rem; }
                //x = i % height;
                y = (i / height) % width;
                z = i / (height * width);
                newArray[x, y, z] = array1d[i];
            }
            return newArray;
        }
    }
}
