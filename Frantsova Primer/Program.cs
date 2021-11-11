using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frantsova_Primer
{
    class Program
    {
        const int N_max = 1000000;
        static double[] a = new double[N_max];
        static void Main(string[] args)
        {
            int n = InputA(); //кол-во элементов и ввод массива
            OutputA("До сортировки", n); //вывод массива
            MaxSort(n);//сортировка по возрастанию
            OutputA("После сортировки через минимальный элемент", n);
            BoobleSort(n); //сортировка по убыванию
            OutputA("После пузырьковой сортировки", n);
            Console.ReadKey();
        }
        //Ввод данных
        static int InputA()
        {
            int n;
            Console.Write("Ввести кол-во чисел: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = Convert.ToDouble(Console.ReadLine());

            }
            return n;
        }
        //Вывод массива
        static void OutputA(string z, int n)
        {
            Console.WriteLine(z);
            for (int i=0;i<n;i++)
            {
                Console.Write("{0:#.#} ", a[i]);
            }
            Console.WriteLine();
        }
        //Сортировка через минимальный элемент по возрастанию
        static void MaxSort(int n)
        {
            double p;
            int k;
            for(int i=0;i<n-1;i++)
            {
                k = k_min(i + 1, n);
                if(a[i]>a[k])
                {
                    p = a[i];
                    a[i] = a[k];
                    a[k] = p;
                }
            }
        }
        //нахождение минимального элемента массива от j до n
        static int k_min(int j,int n)
        {
            double min = a[j];
            int k = j;
            for (int i = j + 1; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    k = i;
                }
            }
            return k;
        }
        //Пузырьковая сортировка по убыванию
        static void BoobleSort(int n)
        {
            double c;
            for(int i=n-1;i>0;i--)
                for(int j=0;j<i;j++)
                {
                    if(a[j]<a[j+1])
                    {
                        c = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = c;
                    }
                }
        }
    }
}
    
