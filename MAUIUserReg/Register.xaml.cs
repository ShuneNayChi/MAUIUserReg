namespace MAUIUserReg;

public partial class Register : ContentPage
{
    VerticalStackLayout layout;
    public Register()
	{
		InitializeComponent();

        this.BackgroundColor = Color.FromArgb("#02425A");


        layout = new VerticalStackLayout
        {
            Margin = new Thickness(15, 15, 15, 15),
            Padding = new Thickness(30, 60, 30, 30),
            Children =
            {
                new Label { Text = "Username", TextColor = Color.FromRgb(255, 255, 255) },
                new Entry (),
                new Label { Text = "Password", TextColor = Color.FromRgb(255, 255, 255) },
                new Entry { IsPassword = true }
            }
        };
       
    }

    private async void RegisterButton_Clicked(object sender, EventArgs e)
    {
        string userName = txtUserName.Text;
        string password = txtPassword.Text;

        // If userName or password is empty, reject registration
        if (userName == null || password == null)
        {
            await DisplayAlert("Warning", "Please input username and password.", "Ok");
            return;
        }
        else
        {
           // Save user name
            Preferences.Set("name", userName);

            //Save password
            Preferences.Set("password", password);
            await DisplayAlert("Success", "Successfully registered!", "Ok");

            // If registration is successful, redirect to Welcome Page
            await Navigation.PushAsync(new WelcomePage(userName));

        }
    }
}