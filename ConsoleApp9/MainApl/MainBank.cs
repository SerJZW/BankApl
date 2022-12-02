using ConsoleApp9;
using ConsoleApp9.Register;

namespace BankAplNew.MainApl
{
    class programm
    {
        static void Main(string[] args)
        {
            User user = new User();
            RegisterOrAuto reg = new RegisterOrAuto();
            MainMenu Mmenu = new MainMenu();
            reg.registerMain(user);
            Mmenu.menu(user);
        }
    }
}