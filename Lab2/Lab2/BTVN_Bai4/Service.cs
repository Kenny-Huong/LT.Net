using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai4
{
    internal class Service
    {
        int n;
        int[,] arr1;

        public void InputMaTran()
        {
            Console.WriteLine("Nhập vào ma trận vuông cấp n ");
            Console.Write("Nhập n: ");
            n = Convert.ToInt32(Console.ReadLine());
            

            arr1 = new int[n, n];
            Console.WriteLine("Nhập các phần tử vào ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0}\t", arr1[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public void OutputTongDuongCheoPhu()
        {
            List<int> listDCP = new List<int>();
            if (arr1 == null)
            {
                Console.WriteLine("Chưa có dữ liệu ma trận. Vui lòng nhấn phím 1 để nhập ma trận!");
                return;
            }

            Console.WriteLine("Các phần tử trên đường chéo phụ là:");
            for (int i = 0; i < n; i++)
            {
                // Phần tử thuộc đường chéo phụ có vị trí arr1[i, n - i - 1]
                Console.WriteLine("arr1[{0},{1}] = {2}", i, n - i - 1, arr1[i, n - i - 1]);
                listDCP.Add(arr1[i, n - i - 1]);
            }
            int sum = 0;
            foreach (var item in listDCP)
            {
               
                sum += item;
            }
            Console.WriteLine($"\nTổng của các phần tử nằm trên đường chéo phụ : {sum}");
        }

        public void findSoAmMax()
        {
            if (arr1 == null)
            {
                Console.WriteLine("Chưa có dữ liệu ma trận . Vui lòng nhấn phím 1 để nhập ma trận ! ");
                return;

            }
            else
            {
                int? soAmMax = null;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (arr1[i, j] < 0)
                        {
                            if (soAmMax == null || arr1[i, j] > soAmMax)
                            {
                                soAmMax = arr1[i, j];
                            }
                        }
                    }
                }

                if (soAmMax != null)
                {
                    Console.WriteLine($"Số âm lớn nhất là : {soAmMax}");
                }
                else
                {
                    Console.WriteLine("Không có số âm nào trong ma trận");
                }
            }
        }

        public void FindCountChia3Va5()
        {
            if (arr1 == null)
            {
                Console.WriteLine("Chưa có dữ liệu ma trận . Vui lòng nhấn phím 1 để nhập ma trận ! ");
                return;

            }
            else
            {
                int count = 0;
                List<int> listChiaHet = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        if(arr1[i, j] % 5 == 0)
                        {
                            if(arr1[i, j] % 3 == 0)
                            {
                                count++;
                                listChiaHet.Add(arr1[i, j]);
                            }
                        }
                    }
                }

                if(count > 0)
                {
                    Console.Write($"Có {count} phần tử trong mảng chia hết cho cả 3 và 5 là : ");
                    foreach (int i in listChiaHet)
                    {
                        Console.Write($"{i} ");
                    }
                }
                else
                {
                    Console.WriteLine("Không có phần tử nào chia hết cho 5 và 3");
                }
            }
        }

    }
}
