using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul1
{
    class Program
    {
        private static void problema1()
        {
            int a, b;
            float x;

            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());

            x = -b / a;
            Console.WriteLine("Rezultatul ecuatiei este " + x);

        }

        private static void problema2()
        {
            int a, b, c;
            double x1, x2, delta;

            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("c=");
            c = int.Parse(Console.ReadLine());

            delta = b ^ 2 - (4 * a * c);

            if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Rezultatul este " + x1);
            }
            else if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Valorile lui x sunt " + x1 + " si " + x2);
            }
            else
            {
                Console.WriteLine("Nu are solutii in multimea nr reale.");
            }
        }

        private static void problema3()
        {
            int n, k;

            Console.Write("Introduceti n=");
            n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti k=");
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine("Numarul " + n + " se divide cu " + k);
            else
                Console.WriteLine("Numarul " + n + " nu se divide cu " + k);
        }

        private static void problema4()
        {
            int y;

            Console.Write("Introduceti y= ");
            y = int.Parse(Console.ReadLine());

            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
            {
                Console.WriteLine("Anul " + y + " este an bisect.");
            }
            else
            {
                Console.WriteLine("Anul " + y + " nu este an bisect.");
            }
        }

        private static void problema5()
        {
            int n, k, save_n, cifra;

            Console.WriteLine("Introduceti n=");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti k=");
            k = int.Parse(Console.ReadLine());

            save_n = n;
            for (int i = 1; i < k; i++)
            {
                save_n /= 10;
            }
            cifra = save_n % 10;

            Console.WriteLine("Cifra de pe pozitia " + k + " a numarului " + n + " este " + cifra);
        }

        private static void problema6()
        {
            int a, b, c;

            Console.WriteLine("Introduceti a=");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti b=");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti c=");
            c = int.Parse(Console.ReadLine());

            if ((a + b > c) || (a + c > b) || (b + c > a))
            {
                Console.WriteLine("Numerele pot fi laturile unui triunghi");
            }
            else
            {
                Console.WriteLine("Numerele nu pot fi laturile unui triunghi");
            }
        }

        private static void problema7()
        {
            int a, b, aux;

            Console.WriteLine("Introduceti a=");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti b=");
            b = int.Parse(Console.ReadLine());

            aux = a;
            a = b;
            b = aux;

        }

        private static void problema8()
        {
            int a, b;

            Console.WriteLine("Introduceti a=");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti b=");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
        }

        private static void problema9()
        {
            int n, d, save_n;

            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Divizorii lui " + n + " sunt: 1, ");
            save_n = n;
            for (d = 2; d <= n / 2; d++)
            {
                if (save_n % d == 0)
                {
                    Console.Write(d + ", ");
                }
            }
            Console.WriteLine(n + ".");
        }

        private static void problema10()
        {
            int n, d;
            bool ok = true;
            Console.WriteLine("Introduceti n=");
            n = int.Parse(Console.ReadLine());

            for (d = 2; d * d <= n; d++)
            {
                if (n % d == 0)
                    ok = false;
            }
            if (ok)
            {
                Console.WriteLine("Numarul e prim.");
            }
            else
            {
                Console.WriteLine("Numarul nu e prim.");
            }
        }

        private static void problema11()
        {
            int n;
            Console.WriteLine("Introduceti n=");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                Console.WriteLine(n % 10);
                n /= 10;
            }
        }

        private static void problema12()
        {
            int a, b, n, contor = 0;

            Console.WriteLine("Introduceti a=");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti b=");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti n=");
            n = int.Parse(Console.ReadLine());

            while (a <= b)
            {
                if (a % n == 0)
                    contor++;
                a++;
            }

            Console.WriteLine("Exista " + contor + " numere divizibile cu " + n + " in intervalul dat.");

        }

        private static void problema13()
        {
            int y1, y2, contor = 0;

            Console.WriteLine("Introduceti y1=");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti y2=");
            y2 = int.Parse(Console.ReadLine());

            while (y1 <= y2)
            {
                if ((y1 % 4 == 0 && y1 % 100 != 0) || y1 % 400 == 0)
                    contor++;
                y1++;
            }
            Console.WriteLine("In intervalul de timp dat sunt " + contor + " ani bisecti.");
        }

        private static void problema14()
        {
            int n, save_n, aux = 0;
            Console.WriteLine("Introduceti n=");
            n = int.Parse(Console.ReadLine());

            save_n = n;
            while (n != 0)
            {
                aux = aux * 10 + n % 10;
                n /= 10;
            }

            if (save_n == aux)
            {
                Console.WriteLine("Numarul " + save_n + " este palindrom.");
            }
            else
            {
                Console.WriteLine("Numarul " + save_n + " nu este palindrom.");
            }
        }

        private static void problema15()
        {
            int a, b, c, aux;

            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("c=");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }

            Console.WriteLine(a + " " + b + " " + c);

        }

        private static void problema16()
        {
            int a, b, c, d, e, aux;

            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("c=");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("d=");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("e=");
            e = int.Parse(Console.ReadLine());

            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (a > d)
            {
                aux = a;
                a = d;
                d = aux;
            }
            if (a > e)
            {
                aux = a;
                a = e;
                e = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (b > d)
            {
                aux = b;
                b = d;
                d = aux;
            }
            if (b > e)
            {
                aux = b;
                b = e;
                e = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if (c > e)
            {
                aux = c;
                c = e;
                e = aux;
            }
            if (d > e)
            {
                aux = d;
                d = e;
                e = aux;
            }

            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
        }

        private static void problema17()
        {
            int a, b, n, m;

            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());

            n = a;
            m = b;

            while (n != m)
            {
                if (n > m)
                {
                    n -= m;
                }
                else
                    m -= n;
            }
            Console.WriteLine("Cel mai mare divizor comun este " + n);

            n = a;
            m = b;

            while (n != m)
            {
                if (n < m)
                {
                    n += a;
                }
                else
                {
                    m += b;
                }
            }

            Console.WriteLine("Cel mai mic multiplu comun este " + n);
        }

        private static void problema18()
        {
            int n, d = 2, p = 0;

            Console.WriteLine("Introduceti n=");
            n = int.Parse(Console.ReadLine());

            while (n > 1)
            {
                if (n % d == 0)
                {
                    n /= d;
                    p++;
                }
                else
                {
                    if (p > 0)
                    {
                        Console.Write(d + "^" + p + "*");
                    }
                    d++;
                    p = 0;
                }
            }
            Console.WriteLine(d + "^" + p);
        }

        private static void problema19()
        {
            int n, contor = 0; ;

            Console.WriteLine("Introduceti n=");
            n = int.Parse(Console.ReadLine());

            int[] array = new int[10];

            while (n != 0)
            {
                array[n % 10]++;
                n /= 10;
            }

            for (int i = 0; i < 10; i++)
            {
                if (array[i] != 0)
                    contor++;
            }

            if (contor == 2)
            {
                Console.WriteLine("Numarul e format doar din 2 cifre.");
            }
            else
            {
                Console.WriteLine("Numarul nu e format doar din 2 cifre.");
            }
        }

        private static void problema20()
        {
            int m, n;

            Console.WriteLine("Introduceti m=");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti n=");
            n = int.Parse(Console.ReadLine());



            int parteInt, parteFract;
            parteInt = m / n;
            parteFract = m % n;

            Console.Write(parteInt);

            int cifra, rest;

            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();

            resturi.Add(parteFract);
            bool periodic = false;

            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }

        private static void problema21()
        {
            int valMin = 1, valMax = 1024;
            int raspJucator;
            int nrRasp;
            int rasp;

            Console.WriteLine("Voi ghici un numar la care te gandesti intre 1 si 1024 doar punand cateva intrebari.");
            do
            {
                nrRasp = valMin + valMax - 1;
                rasp = nrRasp / 2;
                Console.WriteLine("Este numarul tau mai mare sau mai mic decat " + rasp + "?");
                Console.WriteLine("Apasa: (1)Este mai mare. (2)Este mai mic. (3)Acesta este numarul meu.");
                raspJucator = int.Parse(Console.ReadLine());

                if (raspJucator == 1)
                {
                    valMin = rasp + 1;
                }
                else if (raspJucator == 2)
                {
                    valMax = rasp - 1;
                }
                else
                {
                    break;
                }

            } while (valMin < valMax);

            Console.WriteLine("Numarul tau este " + rasp + ".");


        }

        static void Main(string[] args)
        {
            //problema1();

            //problema2();

            //problema3();

            //problema4();

            //problema5();

            //problema6();

            //problema7();

            //problema8();

            //problema9();

            //problema10();

            //problema11();

            //problema12();

            //problema13();

            //problema14();

            //problema15();

            //problema16();

            //problema17();

            //problema18();

            //problema19();

            //problema20();

            problema21();
        }
    }
}
