namespace agricocw_SignupPage;

[QueryProperty(nameof(Username), "username")]
[QueryProperty(nameof(Email), "email")]
public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
    }

    private string username;
    public string Username
    {
        get => username;
        set
        {
            username = Uri.UnescapeDataString(value);
            UsernameLabel.Text = username;
        }
    }

    private string email;
    public string Email
    {
        get => email;
        set
        {
            email = Uri.UnescapeDataString(value);
            EmailLabel.Text = email;
        }
    }

    private async void OnSignOutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//signup");
    }
}
