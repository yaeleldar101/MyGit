
using System;

class program {

      static void Main(string[] args)
     {
    f7();
      }
    public static void f7()
    {
        int[,] mat =
            {
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12},
            {13,14,15,16},

            };
        int max = 0; int sum = 0;
        int[,] mat2 = new int[5, 5];
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                mat2[i, j] = mat[i, j];
                mat2[ mat.GetLength(0),j] += mat[i, j];
                
                 if (max < mat[i, j])
                {
                    max = mat[i, j];

                }
                if (j == mat.GetLength(1) - 1)
                {
                    mat2[i, j + 1] = max;
                    sum += max;
                
                    max = 0;
                  }  

            }
            

            
        }
        
        mat2[mat.GetLength(0), mat.GetLength(1)] = sum;
        print(mat2);
    }
    public static void f8()
    {

    }
   static void print(int[,] mat2)
    {
        for (int i = 0; i < mat2.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.GetLength(1); j++)
            {
                Console.Write(mat2[i, j]+" ");

            }
            Console.WriteLine();
        }
    }

}