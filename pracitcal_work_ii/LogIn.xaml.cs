public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnSignInClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        // Put your simple login check here using your file approach
        // For example:
        if (CheckLogin(username, password))
        {
            // Navigate to Converter or Operations page
        }
        else
        {
            DisplayAlert("Error", "Invalid username or password", "OK");
            UsernameEntry.Text = "";
            PasswordEntry.Text = "";
        }
    }

    private bool CheckLogin(string username, string password)
    {
        // Your login logic here (read file, check creds)
        return false; // example
    }
}
