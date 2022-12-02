using ConsoleApp9.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAplNew.MainApl
{
    internal class MainMenu
    {
        public void menu(User user)
        {
            int sum = user.getSum();
            int saveMoney = user.getSaveMoney();
            double balances = user.getBalance();
            var date = DateTime.Now;

            double Eur = 62.12;
            double USD = 60.74;
            double jpy = 2.31;
            double EURBalance = user.getEURBalance();
            double USDBalance = user.getUSDBalance();
            double JPYBalance = user.getJPYBalance();
            while (true)
            {
                int save = 0;
                int nums = 8;
                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine($"0 - Выход  \n1 - Узнать Дату и Время \n2 - Ваш баланс \n3 - Внести Затраты \n4 - Отложить деньги \n5 - Все операции \n6 - Снять сбережения \n7 - Конвертер ");
                nums = Convert.ToInt32(Console.ReadLine());

                switch (nums)
                {
                    case 1:
                        Console.WriteLine("Сейчас: " + DateTime.Now);
                        continue;
                    case 2:
                        Console.WriteLine("Ваш баланс - " + balances);
                        if (balances <= 4000)
                        {
                            Console.WriteLine("Стоит быть экономнее!");
                        }
                        if (balances >= 10000)
                        {
                            Console.WriteLine("Можно спокойно заниматься покупками!");
                        }
                        continue;
                    case 3:
                        int Expensive = 0;
                        Console.WriteLine("Ваш баланс " + balances);
                        Console.WriteLine("Введите затраты");
                        Expensive = Convert.ToInt32(Console.ReadLine());
                        sum = sum + Expensive;
                        balances = balances - Expensive;
                        if (balances < 0)
                        {
                            Console.WriteLine("Oшибка, недопустимое значение!");

                        }
                        Console.WriteLine("Общая сумма затрат " + sum);
                        continue;
                    case 4:
                        Console.WriteLine("Ваш баланс " + balances);
                        Console.WriteLine("Введите сколько хотите отложить ");
                        save = Convert.ToInt32(Console.ReadLine());
                        saveMoney = saveMoney + save;
                        balances = balances - save;
                        if (balances < 0)
                        {
                            Console.WriteLine("Oшибка, недопустимое значение!");
                            break;
                        }
                        Console.WriteLine("Ваши сбережения " + saveMoney);
                        continue;
                    case 5:
                        Console.WriteLine("Денег      " + balances + " Рублей");
                        Console.WriteLine("Сбережений    " + saveMoney + " Рублей");
                        Console.WriteLine("Затрат     " + sum + " Рублей");
                        Console.WriteLine("Евро      " + EURBalance);
                        Console.WriteLine("Долларов     " + USDBalance);
                        Console.WriteLine("Японская Йена     " + JPYBalance);
                        continue;

                    case 6:
                        Console.WriteLine("Сколько сбережений нужно снять? Сейчас " + saveMoney + "\n1) Самостоятельный Ввод \n2) 25% \n3) 50%");
                        int choice3 = Convert.ToInt32(Console.ReadLine());
                        int savemoneych;
                        
                        if (choice3 == 1)
                        {
                            savemoneych = Convert.ToInt32(Console.ReadLine());
                            saveMoney = saveMoney - savemoneych;
                            balances = balances + savemoneych;
                        }
                        if (choice3 == 3)
                        {
                            savemoneych = (saveMoney / 100) * 50;
                            saveMoney = saveMoney - savemoneych;
                            balances = balances + savemoneych;
                        }
                        if(choice3 == 2)
                        {
                            savemoneych = (saveMoney / 100) * 25;
                            saveMoney = saveMoney - savemoneych;
                            balances = balances + savemoneych;
                        }
                      
                        Console.WriteLine("Осталось сбережений " + saveMoney);
                        continue;
                    case 7:
                        Console.WriteLine("В какую валюту нужно перевести? \n0)Выход \n1)EUR \n2)USD \n3)JPY \n4)RUB");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            if (balances == 0)
                            {
                                Console.WriteLine("Нет Рублей");
                                continue;
                            }
                            Console.WriteLine("Сколько нужно перевести? Сейчас имеется: " + balances + " Рублей");
                            double Eurr = Convert.ToInt32(Console.ReadLine());
                            double eurB;
                            eurB = Eurr / Eur;

                            balances = balances - Eurr;
                            if (balances < 0)
                            {
                                Console.WriteLine("Oшибка, недопустимое значение!");
                                break;
                            }
                            EURBalance = EURBalance + eurB;
                            EURBalance = Math.Round(EURBalance, 2);
                            Console.WriteLine("На вашем счете " + EURBalance + "Eвро");

                            continue;
                        }
                        if (choice == 2)
                        {
                            if (balances == 0)
                            {
                                Console.WriteLine("Нет Рублей");
                                continue;
                            }
                            Console.WriteLine("Сколько нужно перевести? Сейчас имеется: " + balances + " Рублей");
                            double Usdd = Convert.ToInt32(Console.ReadLine());
                            double usdB;
                            usdB = Usdd / USD;
                            balances = balances - Usdd;
                            if (balances < 0)
                            {
                                Console.WriteLine("Oшибка, недопустимое значение!");
                                break;
                            }

                            USDBalance = USDBalance + usdB;
                            USDBalance = Math.Round(USDBalance, 2);
                            Console.WriteLine("На вашем счете " + USDBalance + "Долларов");
                            continue;
                        }
                        if (choice == 3)
                        {
                            if (balances == 0)
                            {
                                Console.WriteLine("Нет Рублей");
                                continue;
                            }
                            Console.WriteLine("Сколько нужно перевести? Сейчас имеется: " + balances + " Рублей");
                            double Jpyy = Convert.ToInt32(Console.ReadLine());
                            double jpyB = 0;
                            jpyB = Jpyy / jpy;
                            balances = balances - Jpyy;
                            if (balances < 0)
                            {
                                Console.WriteLine("Oшибка, недопустимое значение!");
                                break;
                            }
                            JPYBalance = JPYBalance + jpyB;
                            JPYBalance = Math.Round(JPYBalance, 2);
                            Console.WriteLine("На вашем счете " + JPYBalance + "Японских Йен");
                            continue;
                        }
                        if (choice == 4)
                        {
                            Console.WriteLine("Из какой валюты нужно перевести? \n0)Выход \n1)EUR \n2)USD \n3)JPY");
                            int choice2 = Convert.ToInt32(Console.ReadLine());
                            if (choice2 == 1)
                            {
                                if (EURBalance == 0)
                                {
                                    Console.WriteLine("Этой валюты у вас нет");
                                    continue;
                                }
                                Console.WriteLine("Сколько нужно перевести? Сейчас имеется: " + EURBalance);
                                double EurToRub = Convert.ToDouble(Console.ReadLine());
                                EURBalance = EURBalance - EurToRub;
                                if (EURBalance < 0)
                                {
                                    break;
                                }
                                EurToRub = EurToRub * Eur;
                                balances = balances + EurToRub;

                                EURBalance = Math.Round(EurToRub, 2);
                                balances = Math.Round(balances, 2);

                                EURBalance = EURBalance - EurToRub;
                                EURBalance = Math.Round(EURBalance, 2);
                                Console.WriteLine("Успешно! на вашем счете " + balances + " Рублей и " + EURBalance + " Евро");
                            }
                            if (choice2 == 2)
                            {
                                if (USDBalance == 0)
                                {
                                    Console.WriteLine("Этой валюты у вас нет");
                                    continue;
                                }
                                Console.WriteLine("Сколько нужно перевести? Сейчас имеется: " + USDBalance);
                                double USDToRub = Convert.ToDouble(Console.ReadLine());

                                USDBalance = USDBalance - USDToRub;
                                if (USDBalance < 0)
                                {
                                    break;
                                }
                                USDToRub = USDToRub * USD;
                                balances = balances + USDToRub;
                                USDBalance = Math.Round(USDToRub, 2);
                                balances = Math.Round(balances, 2);
                                USDBalance = USDBalance - USDToRub;
                                USDBalance = Math.Round(USDBalance, 2);
                                if (USDBalance < 0)
                                {
                                    USDBalance = 0;
                                }

                                Console.WriteLine("Успешно! на вашем счете " + balances + " Рублей и " + USDBalance + " Долларов");
                            }
                            if (choice2 == 3)
                            {
                                if (JPYBalance == 0)
                                {
                                    Console.WriteLine("Этой валюты у вас нет");
                                    continue;
                                }
                                Console.WriteLine("Сколько нужно перевести? Сейчас имеется: " + JPYBalance);
                                double JPYToRub = Convert.ToDouble(Console.ReadLine());

                                JPYBalance = JPYBalance - JPYToRub;
                                if (JPYBalance < 0)
                                {
                                    break;
                                }
                                JPYToRub = JPYToRub * jpy;
                                balances = balances + JPYToRub;
                                JPYBalance = Math.Round(JPYToRub, 2);
                                balances = Math.Round(balances, 2);
                                JPYBalance = JPYBalance - JPYToRub;
                                JPYBalance = Math.Round(JPYBalance, 2);

                                Console.WriteLine("Успешно! на вашем счете " + balances + " Рублей и " + JPYBalance + " Японских Йен");

                            }
                            if (choice2 == 0)
                            {
                                continue;
                            }
                        }
                        if (choice == 0)
                        {
                            continue;
                        }
                        continue;
                    case 0:

                        Console.ReadKey();
                        break;
                }
                break;
            }
        }
    }
}
