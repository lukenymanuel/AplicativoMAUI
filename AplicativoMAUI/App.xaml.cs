using AplicativoMAUI.Models;
using AplicativoMAUI;
using System.Security.Cryptography.X509Certificates;

namespace AplicativoMAUI
{
    public partial class App : Application
    {
        public static Aluno aluno;
        public App()
        {   
            InitializeComponent();

            MainPage = new LoginPage();
        }
    }
}
