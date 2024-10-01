using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace BTVN_Bai3
{
    internal class Service
    {
        int n, m;
        int[,] arr1;

        public void InputMaTran()
        {
            Console.WriteLine("Nhập vào ma trận gồm n hàng và m cột");
            Console.Write("Nhập n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập m: ");
            m = Convert.ToInt32(Console.ReadLine());

            arr1 = new int[n, m];
            Console.WriteLine("Nhập các phần tử vào ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Phần tử - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void OutputMaTran()
        {
            if (arr1 == null)
            {
                Console.WriteLine("Chưa có dữ liệu ma trận . Vui lòng nhấn phím 1 để nhập ma trận ! ");
                return;

            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("{0}\t", arr1[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public void findSoAmMin()
        {
            if (arr1 == null)
            {
                Console.WriteLine("Chưa có dữ liệu ma trận . Vui lòng nhấn phím 1 để nhập ma trận ! ");
                return;

            }
            else
            {
                int? soAmMin = null;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (arr1[i, j] < 0)
                        {
                            if (soAmMin == null || arr1[i, j] < soAmMin)
                            {
                                soAmMin = arr1[i, j];
                            }
                        }
                    }
                }

                if (soAmMin != null)
                {
                    Console.WriteLine($"Số âm nhỏ nhất là : {soAmMin}");
                }
                else
                {
                    Console.WriteLine("Không có số âm nào trong ma trận");
                }
            }
        }

        public void SortColums()
        {
           if(arr1 == null)
            {
                Console.WriteLine("Chưa có dữ liệu ma trận . Vui lòng nhấn phím 1 để nhập ma trận ! ");
                return;
            }
            else
            {
                Console.WriteLine("Ma trận trước khi sắp xếp : ");
                OutputMaTran();

                
                for(int j = 0;j < m; j++)
                {
                    int[] temp = new int[n];
                    for (int i = 0;i < n; i++)
                    {
                        temp[i] = arr1[i, j];
                    }

                    Array.Sort(temp);

                    for (int i = 0; i < n; i++)
                    {
                        arr1[i, j] = temp[i];
                    }
                }
                Console.WriteLine("Ma trận sau khi sắp xếp : ");
                OutputMaTran();
            }
        }

        public void RemoveColumn()
        {
            if (arr1 == null)
            {
                Console.WriteLine("Chưa có dữ liệu ma trận . Vui lòng nhấn phím 1 để nhập ma trận ! ");
                return;

            }
            else
            {
                int k;
                Console.Write("Nhập số nguyên k để xóa cột thứ k :");
                k = Convert.ToInt32(Console.ReadLine());

                if (k < 0 || k >= m)
                {
                    Console.WriteLine($"Cột thứ {k} không tồn tại !");
                    return;
                }

                int[,] newArr = new int[n, m - 1];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (j < k)
                        {
                            newArr[i, j] = arr1[i, j];
                        }
                        else if (j > k)
                        {
                            newArr[i, j - 1] = arr1[i, j];
                        }
                    }
                }

                arr1 = newArr;
                m--;

                Console.WriteLine($"Đã xóa cột thứ {k}");
                OutputMaTran();
            }
        }

        public void findEvenNumbers()
        {
            if (arr1 == null)
            {
                Console.WriteLine("Chưa có dữ liệu ma trận . Vui lòng nhấn phím 1 để nhập ma trận ! ");
                return;

            }
            else
            {
                List<int> evenNumbers = new List<int>();

                for (int i = 0;i < n;i++)
                {
                    for(int j = 0;j < m;j++)
                    {
                        if (arr1[i, j] % 2 == 0)
                        {
                            evenNumbers.Add(arr1[i, j]);
                        }
                    }
                }

                if (evenNumbers.Count > 0)
                {
                    Console.Write("\nCác phần tử chẵn trong ma trận là : ");
                    foreach (int item in evenNumbers)
                    {
                        Console.Write($"{item} \t");
                    }
                    Console.WriteLine(" ");

                    int sum = 0;
                    foreach (int item in evenNumbers)
                    {
                        sum += item;
                    }

                    Console.WriteLine($"Tổng các số chẵn trong ma trận trên : {sum}");

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Không có phần tử chẵn nào trong ma trận !!!");
                }
            }
        }
    }
}
