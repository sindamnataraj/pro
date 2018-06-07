using System;
using System.Collections.Generic;
using System.Text;

namespace proconsole
{
    public class sort
    {
        //O(n2)
        public static void selection(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int minindex = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[minindex]) minindex = j;
                }

                if (minindex != i) interchange(A, i, minindex);
            }
        }

        public static void insertion(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int j = i - 1;
                int k = A[i];
                while (j >= 0 && A[j] > k)
                {
                    A[j + 1] = A[j];
                    j--;
                }

                A[j+1] = k;
            }
        }

        public static void bucket(int[] A)
        {
            for (int i = A.Length-1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (A[j - 1] > A[j]) interchange(A, j - 1, j);
                }
            }
            
        }

        public static void interchange(int[] A, int p, int q)
        {
            int temp = A[p];
            A[p] = A[q];
            A[q] = temp;
         }
    }

}
