namespace ConsoleApp9.Register
{

    internal class User
    {
        double balance;
        string login;
        string password;
        double eurbalance = 0;
        double usdbalance = 0;
        double jpybalance = 0;
        int sum = 0;
        int savemoney = 0;


        public double getBalance()
        {

            return balance;
        }
        public void setBalance(double balance)
        {

            this.balance = balance;
        }
        public string getLogin()
        {
            return login;
        }
        public void setLogin(string login)
        {
            this.login = login;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public double getEURBalance()
        {
            return eurbalance;
        }
        public double getUSDBalance()
        {
            return usdbalance;
        }
        public double getJPYBalance()
        {
            return jpybalance;
        }
        public int getSum()
        {
            return sum;
        }
        public int getSaveMoney()
        {
            return savemoney;
        }




        //while (true)
        //   {
        //       password = "";
        //       var key = Console.ReadKey(true);

        //       if (key.Key == ConsoleKey.Enter) break;

        //       Console.Write("*");
        //       password += key.KeyChar;



        //   }

    }

}
