using System.Diagnostics; 
namespace MAUIUserReg;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        string userName = txtUserName.Text;
        string password = txtPassword.Text;

        string name = Preferences.Get("name", "Default Name");
        string pass = Preferences.Get("password", "Default Password");

        //  If userName or password is empty, reject registering
        //  If userName and password is correct, allow login
        //  If userName or password is wrong, reject registering
        if (userName == null || password == null)
        {
            await DisplayAlert("Warning", "Please input username and password.","Ok");
            return;
        }
        else if (name==userName && pass==password)
        {
            await Navigation.PushAsync(new WelcomePage(userName));
        }
        else
        {
            await DisplayAlert("Warning", "Username or password is incorrect.", "Ok");
            return;
        }
    }

    // Redirect to Registration Page
    private async void SignUpButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Register());
    }

}

