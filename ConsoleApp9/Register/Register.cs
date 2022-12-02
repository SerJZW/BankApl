using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using ConsoleApp9.Register;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace ConsoleApp9
{
    internal class RegisterOrAuto
    {
        public void registerMain(User user)
        {
            Console.WriteLine("Приветствуем! Что вы хотите сделать? \n1)Регистрация \n2)Вход");
            int var = 2;
            var = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (var)
                {
                    case 1:
                        getRegistration(user);
                        break;
                    case 2:
                        // need sql baza dannyx
                        break;       
                }
                break;    
            }       
        }
      public void getRegistration(User user)
        {
            CheckLog(user);
            CheckPass(user);
            CheckBalance(user);
            SayHello(user); 
        }
         private void CheckLog(User user)
        {
            while (true)
            {
                Console.WriteLine("Как вас зовут? от 3 до 16 символов c заглавными и прописными буквами ");
                user.setLogin(Convert.ToString(Console.ReadLine()));
                string login = user.getLogin();
                if (login.Length < 3)
                {
                    Console.WriteLine("Мало символов");
                    continue;
                }
                if (login.Length > 16)
                {
                    Console.WriteLine("Много символов");
                    continue;
                }
                if (Regex.IsMatch(login, @"[A-Z]") && Regex.IsMatch(login, @"[a-z]"))
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("Complete!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Login!");
                    continue;
                }   
            }    
        }
        private void CheckPass(User user)
        {
            while (true)
            {
                Console.Write("Введите пароль (Должен в себя включать заглавные, прописные, символы и цифры):\n ");
                user.setPassword(Convert.ToString(Console.ReadLine()));
                string password = user.getPassword();
                if (password.Length < 3)
                {
                    Console.WriteLine("Мало символов");
                    continue;
                }
                if (password.Length > 16)
                {
                    Console.WriteLine("Много символов");
                    continue;
                }
                if (Regex.IsMatch(password, @"[A-Z]") && Regex.IsMatch(password, @"[a-z]") && Regex.IsMatch(password, @"[0-9]") && Regex.IsMatch(password, @"[!-*]"))
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Complete!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong password!");
                    continue;
                }              
            }           
        }
        private void CheckBalance(User user)
        {
            while (true)
            {
                Console.WriteLine("\nВаш баланс?");
                user.setBalance(Convert.ToDouble(Console.ReadLine()));
                double balance = user.getBalance();
                if(balance == 0)
                {
                    Console.WriteLine("Не корректный баланс");
                    continue;
                }
                if (balance < 0)
                {
                    Console.WriteLine("Баланс не может быть отрицательным!");
                    continue;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Complete");
                    break;
                }
            }
        }
        private void SayHello(User user)
        {
            Console.WriteLine("\nПривет " + user.getLogin() + "!");
            Console.WriteLine("Ваш баланс: " + user.getBalance());
            DateTime date1 = new DateTime(2022, 11, 21, 12, 00, 00);
            Console.WriteLine("Ближайшая зарплата " + date1);
        }
    }
}
