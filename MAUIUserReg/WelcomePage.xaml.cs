using AndroidX.Navigation;
using static Android.Webkit.ConsoleMessage;

namespace MAUIUserReg;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();

    }

    public WelcomePage(string userName)
    {
        InitializeComponent();
        lblUserName.Text = "Welcome " + userName + "!";
    }

    //Disable Back Button Click
    protected override bool OnBackButtonPressed()
    {
        return true;
    }

    //LogOut
    private async void OnItemClicked(object sender, EventArgs e)
    {
        ToolbarItem item = (ToolbarItem)sender;
        await Navigation.PushAsync(new MainPage());
    }
}