using AplicativoMAUI;
using AplicativoMAUI.Views;

namespace AplicativoMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
           
          //  Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(AlunoView), typeof(AlunoView));
        //    Routing.RegisterRoute(nameof(ContactPage), typeof(ContactPage));
            


        }
    }
}
