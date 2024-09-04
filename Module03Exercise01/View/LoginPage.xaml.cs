namespace Module03Exercise01.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Login Success", "Redirecting you to the Employee page...", "OK");

    }
}