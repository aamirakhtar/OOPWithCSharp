using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    class Array
    {
        public static void Main()
        {
            #region Single Dimesional Array
            int[] arr = new int[5];//declaration

            //value assignment
            arr[0] = 434;
            arr[1] = 509;
            arr[2] = 600;
            arr[3] = 700;
            arr[4] = 800;

            int[] arr1 = { 1, 2, 3, 4, 5 };//initialization

            //Traversal
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion

            Console.WriteLine("********************************************");

            #region 2D Array

            int[,] d2 = new int[4, 2];//declaration

            //value assignment
            d2[0, 0] = 34;
            d2[0, 1] = 54;


            int[,] intArray = new int[,] {      /*0*/     /*1*/
                                           /*0*/{ 1    ,    2 }, //initialization
                                           /*1*/{ 3    ,    4 },
                                           /*2*/{ 5    ,    6 },
                                           /*3*/{ 7    ,    8 }
                                        };
            //Traversal
            //Number of dimensions are always equal to number of nested loops in case of traversal
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write(intArray[i, j] + (j == intArray.GetLength(1) - 1 ? "" : " , "));
                }

                Console.WriteLine();
            }

            #endregion

            Console.WriteLine("********************************************");

            #region 3D Array

            int[,,] d3 = new int[4, 2, 3]; //declaration

            int[,,] intArray3Dd = new int[2, 2, 3] //assignment
                                                   {
                                                   /*0*/{
                                                               /*0*/ /*1*/ /*2*/
                                                        /*0*/{   1,    2,    3 },
                                                        /*1*/{   4,    5,    6 }
                                                        },
                                                   /*1*/{
                                                        /*0*/{   7,    8,    9 },
                                                        /*1*/{   10,   11,   12}
                                                        }
                                                    };

            //Traversal
            for (int i = 0; i < intArray3Dd.GetLength(0); i++)
            {
                for (int j = 0; j < intArray3Dd.GetLength(1); j++)
                {
                    for (int k = 0; k < intArray3Dd.GetLength(2); k++)
                    {
                        Console.Write(intArray3Dd[i, j, k] + (k == intArray3Dd.GetLength(2) - 1 ? "" : " , "));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            #endregion

            Console.ReadLine();
        }
    }
}
