using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In automatul de vanzari poti introduce monede doar de 5,10 si 25 de centi.\nCand suma totala introdusa va fi de 20 de centi produsul se va elibera si vei primi un eventual rest daca este cazul.");
            int money, suma,rest,flag;
            List<int> coins = new List<int>() { 5, 10, 25 };
            suma= 0;
            Console.WriteLine("Introdu moneda(tasteaza valoarea monedei:");
            money=int.Parse(Console.ReadLine());
            if (coins.Contains(money))
            {
                suma +=money;
            }
            else
            {
                Console.WriteLine("Nu exita moneda de valoarea aceasta.");
            }
            while(suma != 0)
            {
                Console.WriteLine($"Suma totala este {suma}.");
                if (suma < 20)
                {
                    Console.WriteLine("Suma nu este suficienta. Mai introdu o moneda:");
                    money = int.Parse(Console.ReadLine());
                    if (coins.Contains(money))
                    {
                        suma +=money;
                    }
                    else
                    {
                        Console.WriteLine("Nu exita moneda de valoarea aceasta.");
                        break;
                    }
                }
                if (suma >= 20)
                {
                    rest = suma - 20;

                    if (rest == 0)
                    {
                        Console.WriteLine("Produsul a fost eliberat. Nu mai ai bani in aparat. Reporneste aparatul daca mai doresti sa cumperi.");
                        break;
                    }
                    if (rest > 0)
                    {
                        Console.WriteLine($"Produsul a fost eliberat. Mai ai in aparat {rest} centi. Daca doresti sa primesti restul tasteaza '0'.\nDaca doresti sa mai introduci monede pentru un nou produs tasteaza '1'.");
                        flag=int.Parse(Console.ReadLine());
                        if (flag == 0)
                        {
                            Console.WriteLine($"Ai primit rest {rest} centi.Reporneste aparatul daca mai doresti sa cumperi.");
                            break;
                        }
                        if(flag == 1)
                        {
                            Console.WriteLine("Introdu moneda");
                            money= int.Parse(Console.ReadLine());
                            if (coins.Contains(money))
                            {
                                suma = rest + money;
                            }
                            else
                            {
                                Console.WriteLine("Nu exista moneda cu valoarea aceasta");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
