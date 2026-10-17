using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daysonguyen
{
    internal class Program
    { 
        static void Nhap(int[] a)
        {
                for(int i=0; i<a.Length; i++)
            {
                Console.Write("a[" + i +"] =");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void In(int[] a)
        {
            for(int i=0; i<a.Length;i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static void XapXep(int[] a)
        {
            for(int i=0;i<a.Length - 1; i++)
            {
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n :");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Nhap day so:");
            Nhap(a);
            Console.WriteLine("Day so vua nhap la:");
            In(a);
            XapXep(a);
            Console.WriteLine("Day sau khi xap xep la:") ;
            In(a);
        }
    }
}
