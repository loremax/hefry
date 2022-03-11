using System;
class jaggedarray

{

static void Main()
    {
        Console.Clear();

        int[][] arr = new int[5][];
        arr[0] = new int[3];
        arr[1] = new int[6];
        arr[2] = new int[5];
        arr[3] = new int[4];
        arr[4] = new int[7];
        foreach (int[] iarr in arr)
        {
            foreach (int x in iarr)
                Console.Write(x + " ");
            Console.WriteLine();
        }

        Console.WriteLine("------------------");

        foreach (int[] iarr in arr)
        {
            for (int i = 0; i < iarr.Length; i++)
                Console.Write(iarr[i] + " ");
            Console.WriteLine();
        }
        Console.WriteLine("------------------");

        foreach(int[] iarr in arr)
        {
            for(int i=0; i<iarr.Length;i++)
            {
                iarr[i] = i + 1;
            }
        }

        for(int i=0;i<arr.GetLength(0);i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
                Console.Write(arr[i][j] + " ");
            Console.WriteLine();

        }
        Console.WriteLine("___________________________");

        for (int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr[i].Length;j++)
            {
                arr[i][j] = i + 1;
            }
        }

        for(int i=0;i<arr.GetLength(0);i++)
        {
            foreach (int x in arr[i])
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }

}