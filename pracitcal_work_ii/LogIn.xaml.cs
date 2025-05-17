using System;
using Microsoft.Maui.Controls;

namespace practical_work_ii;

public partial class LoginPage : ContentPage
{
    private UserStore userStore;

    public LoginPage()
    {
        InitializeComponent();
        userStore = new UserStore(); // ← Instanciamos la clase UserStore

        var forgotTap = new TapGestureRecognizer();
        forgotTap.Tapped += async (s, e) =>
        {
            await Shell.Current.GoToAsync("forgotPassword"); // Asegúrate que esta ruta existe
        };
        forgotLabel.GestureRecognizers.Add(forgotTap);

        var registerTap = new TapGestureRecognizer();
        registerTap.Tapped += async (s, e) =>
        {
            await Shell.Current.GoToAsync("register"); // Asegúrate que esta ruta existe
        };
        registerLabel.GestureRecognizers.Add(registerTap);
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = usernameEntry?.Text?.Trim();
        string password = passwordEntry?.Text?.Trim();

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Error", "Por favor, completa ambos campos.", "OK");
            return;
        }

        bool loginSuccess = userStore.LoginUser(username, password);

        if (loginSuccess)
        {
            await DisplayAlert("Bienvenido", "Inicio de sesión correcto", "OK");
            await Shell.Current.GoToAsync("converter"); // ← Cambia si usas otra ruta
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "OK");
        }
    }
}
