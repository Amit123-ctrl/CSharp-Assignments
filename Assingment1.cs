using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_a_
{
    internal class Program
    {
        static int SumOfElements(int[] arr) {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            return sum;
        }
        static float AverageOfElements(float[] arr) {
            float avg = 0;
            for (int i = 0; i < arr.Length; i++) {
                avg += arr[i];
            }
            avg /= arr.Length;
            return avg;
    ;        }
        static int LargestElement(int[] arr) {
            int max = int.MinValue;
          
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) { 
                max= arr[i];
                }
            }
            return max;
        }
        static int[] NumOfEvenAndOdd(int[] arr) {
            int[] c = new int[2];
            int even = 0;
            int odd = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else {
                    odd++; 
                }
            }
            c[0] = even;
            c[1] = odd;
            return c;
;        }
        static int[] SearchHistory(int[] arr) {
            for (int i = 0; i < arr.Length / 2; i++) {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length-1-i] = temp;
               
            }
            return arr;
        }

        static int[] MultipleByFactor(int[] arr,int k) { 
        for(int i=0;i<arr.Length; i++) {
                arr[i] *= k;
            }
            return arr;
        }
        static int SearchBook(int[] arr, int k) {
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == k) {
                    return i;
                }
            }
            return -1;
        }
        static int SecondSmallest(int[] arr) {
            for (int i = 0; i < arr.Length-1; i++) {
                for (int j = i + 1; j < arr.Length; j++) {
                    if (arr[i] > arr[j]) {
                        int temp = arr[i];
                        arr[i]=arr[j];
                        arr[j]=temp;    
                    }
                }
            }
            return arr[1];
        }
        static LinkedList<int> RemoveDuplicate(int[] arr) {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < arr.Length - 1; i++) {
                if (!list.Contains(arr[i])) { 
                   list.AddLast(arr[i]);
                }
              }
            return list;
        }
        static LinkedList<int> SameElementInBothArray(int[] a1, int[] a2) {
            LinkedList<int> list=new LinkedList<int>();
            for (int i = 0; i < a1.Length; i++) {
                for (int j = 0; j < a1.Length; j++) {
                    if (a1[i] == a2[j]) {
                        list.AddLast(a1[i]);
                    }
                }
                    }
            return list;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of element of array = " + SumOfElements(new int[] { 200, -150, 340, 500, -100 }));
            Console.WriteLine("Average of elements of array = " + AverageOfElements(new float[] { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f }));
            Console.WriteLine("Largest element of array = " + LargestElement(new int[] { 1500, 2300, 999, 3200, 1750 }));
            int[] a = NumOfEvenAndOdd(new int[] { 102, 215, 324, 453, 536 });
            Console.WriteLine("Number of Males: " + a[0] + " and number of Females: " + a[1]);
            int[] b = SearchHistory(new int[] { 101, 202, 303, 404, 505 });
            Console.WriteLine("Reverse search history: " + string.Join(", ", b));
            Console.WriteLine("Array Elements after the multiple by factor : " + string.Join(", ", MultipleByFactor(new int[] { 2, 4, 6, 8 }, 3)));
            Console.WriteLine("Book is at: " + SearchBook(new int[] { 101, 203, 304, 405, 506 }, 304));
            Console.WriteLine("Second smallest element of array: " + SecondSmallest(new int[] { 56, 78, 89, 45, 67 }));
            Console.WriteLine("Removing element from array " + string.Join(", ",RemoveDuplicate(new int[]{102, 215, 102, 324, 215})));
            Console.WriteLine("Common elements in both array = " + string.Join(", ", SameElementInBothArray(new int[] { 1, 2, 3, 4, 5 },new int[] { 3, 4, 5, 6, 7 })));
        }
        }
    }


