using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTVN_Bai5
{
    class Program
    {
        static int sharedNumber; // Biến chung để lưu số ngẫu nhiên
        static bool newNumberGenerated = false; // Đánh dấu khi có số mới được sinh ra
        static readonly object locker = new object(); // Đối tượng dùng cho cơ chế khóa (synchronization)

        // Thread 1: Sinh số ngẫu nhiên từ 1 đến 20 mỗi 2 giây
        static void Thread1()
        {
            Random rand = new Random();

            while (true)
            {
                lock (locker)
                {
                    sharedNumber = rand.Next(1, 21); // Sinh số ngẫu nhiên từ 1 đến 20
                    newNumberGenerated = true; // Đánh dấu rằng có số mới
                    Console.WriteLine($"\nThread 1: Sinh số {sharedNumber}");
                }

                Thread.Sleep(2000); // Dừng 2 giây
            }
        }

        // Thread 2: Lấy số từ Thread 1 và tính bình phương
        static void Thread2()
        {
            while (true)
            {
                lock (locker)
                {
                    if (newNumberGenerated) // Kiểm tra xem có số mới hay chưa
                    {
                        int square = sharedNumber * sharedNumber; // Tính bình phương
                        Console.WriteLine($"Thread 2: Bình phương của {sharedNumber} là {square}");
                        newNumberGenerated = false; // Đặt lại trạng thái
                    }
                }

                Thread.Sleep(100); // Thread 2 chạy liên tục nhưng kiểm tra nhanh
            }
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo và khởi động thread 1
            Thread t1 = new Thread(Thread1);
            // Tạo và khởi động thread 2
            Thread t2 = new Thread(Thread2);

            // Bắt đầu thực thi cả hai thread
            t1.Start();
            t2.Start();

            // Đợi cả hai thread chạy vô thời hạn
            t1.Join();
            t2.Join();
        }
    }
}

