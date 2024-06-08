using AplicativoMAUI.Models;
using AplicativoMAUI.Services;
using AplicativoMAUI;
using AplicativoMAUI.Views;
// Adicione esta referência

namespace AplicativoMAUI
{
    public partial class LoginPage : ContentPage
    {
        readonly ILoginRepository repository = new LoginService();

        public LoginPage()
        {
            InitializeComponent();

            // Shell.SetBackButtonBehavior(this, new BackButtonBehavior { IsEnabled = false });
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string username = Username.Text;
                string password = Password.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    await DisplayAlert("Erro", "Preencha todos os campos", "OK");
                    return;
                }

                Aluno aluno = await repository.Login(username, password);

                if (aluno  != null)
                {
                    await Navigation.PushAsync(new AlunoView(aluno));
                }
                else
                {
                    await DisplayAlert("Erro", "Usuário ou senha incorretos", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro","Verifique a conexao com a api","ok");
            }
        }

    }
}
