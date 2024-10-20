using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2_VD_Bai1
{
    internal class Program
    {
        //Chương trình đọc và ghi file nhị phân trong C#
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;

            int i = 2003;
            double d = 8.92003;
            bool b = true;
            string s = "I'm Kenny Huong";

            try
            {
                bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
            }catch(IOException e)
            {
                Console.WriteLine(e.Message + "Không tạo được file.");
                return;
            }

            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "Không Ghi được file");
                return;
            }

            bw.Close();
            try
            {
                br = new BinaryReader(new FileStream("mydata", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + " Không mở được file");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Interger data : {0}, i");
                d = br.ReadDouble();
                Console.WriteLine("Double data : {0}, d");
                s = br.ReadString();
                Console.WriteLine("String data : {0}", s);
            }
            catch(IOException e) 
            {
                Console.WriteLine(e.Message + "Không thể đọc từ file");
                return;
            }

            br.Close();
            Console.ReadKey();
        }
    }
}
