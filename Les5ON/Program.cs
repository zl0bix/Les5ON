using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5ON
{
    internal class Program
    {
        static void PrintArr(int[]arr)
        {       
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void ArrayAdd(int[] arr, int numMin, int numMax)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(numMin,numMax + 1);
            }
        }
        static void MoveArr(int[]arr,int num) 
        {


            for (int j = 0; j < num; j++)
            {
                int temp = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = temp;
            }
            
            
                
            
        }

        static void Main(string[] args)
        {
            /*
    Задача 1: Найти минимальное и максимальное значение в массиве.
    Напишите код, который находит минимальное и максимальное значение в заданном целочисленном 
    массиве. Результаты вывести на консоль.
             */
            int n;
            int nSize, nMin, nMax;
            List<int> arr0 = new List<int>();
            while (true)
            {
                Console.Write("\n\n\n\n\n\n\t\tВведите номер упражнения -> ");
                n = Convert.ToInt32(Console.ReadLine());
                
                switch (n)
                
                {
                    case 1:
                    {
                            Console.Clear();
                            //int nSize, nMin, nMax;
                            Console.WriteLine("\n\n\n\t\tEx1\n\n");
                            Console.Write("Введите колличество элементов массива -> ");
                            nSize = int.Parse(Console.ReadLine());
                            int[] arrEx1 = new int[nSize];
                            Console.Write("Введите минимальный возможный диапазон массива -> ");
                            nMin = int.Parse(Console.ReadLine());
                            Console.Write("Введите максимальный возможный диапазон массива -> ");
                            nMax = int.Parse(Console.ReadLine());
                            Random random = new Random();
                            for (int i = 0; i < arrEx1.Length; i++)
                            {
                                arrEx1[i] = random.Next(nMin, nMax + 1);
                                Console.Write(arrEx1[i] + " ");
                            }
                            nMin = arrEx1[0];
                            nMax = arrEx1[0];
                            for (int i = 0; i < arrEx1.Length; i++)
                            {
                                if (arrEx1[i] < nMin)
                                    nMin = arrEx1[i];
                                if (arrEx1[i] > nMax) nMax = arrEx1[i];
                            }
                            Console.WriteLine("\nMax is " + nMax + "\nMin is " + nMin);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    case 2:     
                    {
                            Console.Clear();
                            Console.WriteLine("\n\n\n\t\tEx2\n\n");
                            //Console.Write("Введите число на которое хотите сдвинуть -> ");
                            int []arr2= new int[10];
                            ArrayAdd(arr2, 1, 11);
                            PrintArr(arr2);
                            Console.WriteLine();
                           // MoveArr(arr2, 2);
                            Console.WriteLine();
                            //PrintArr(arr2);
                            Console.WriteLine();
                            MoveArr(arr2, 2);
                            PrintArr(arr2);


                            /*
   Задача 2: Сдвиг элементов массива на N позиций.
   Реализуйте функцию, которая принимает массив и число N, и возвращает новый массив с 
   элементами, сдвинутыми на N позиций влево или вправо (в зависимости от знака N).
               */
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    case 3:
                    {
                            Console.Clear();
                            Console.WriteLine("\n\n\n\t\tEx3\n\n");
                            Console.Write("Введите размер массива -> ");
                            nSize = Convert.ToInt32(Console.ReadLine());
                            int[] arr3 = new int[nSize];
                            ArrayAdd(arr3 , 1, 33);
                            PrintArr(arr3);
                            for (int i = 0; i < arr3.Length; i++)
                            {
                                for (int j = 0; j < arr3.Length - 1 - i; j++)
                                    if (arr3[j] > arr3[j + 1])
                                    {
                                        int temp = arr3[j];
                                        arr3[j] = arr3[j + 1];
                                        arr3[j + 1] = temp;
                                    }                               
                            }
                            
                            //for (int j = 0; j < arr3.Length; j++)
                            //{
                                for (int i = 0; i < arr3.Length -1; i++)
                                {
                                    if (arr3[i] != arr3[i + 1])
                                        arr0.Add(arr3[i]);
                                }
                            //}
                            Console.WriteLine();
                            foreach (var list in arr0)
                            {                                                                                     
                                Console.Write(list + " ");
                            }

                            Console.WriteLine();
                            //PrintArr(arr3);

                            /*
    Задача 3: Удаление дубликатов из массива.
    Напишите код, который удаляет все дубликаты из массива и возвращает новый массив без 
    повторяющихся элементов
                             */


                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
               
            }
        }
    }
}
