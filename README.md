# XamarinFormsLoading

Loading indicator sample

## Thanks
- [ACR User Dialogs Plugin for Xamarin](https://www.nuget.org/packages/Acr.UserDialogs/)

## Screenshot
![screenshot](https://raw.githubusercontent.com/xamarin-samples/XamarinFormsLoading/master/screenshots/screenshot.gif)

## Pickuped code
### PCL: MainPage.xaml.cs
```cs
public partial class MainPage : ContentPage
{
    ....
    private async void IncrementButton_Clicked(object sender, EventArgs e)
    {
        using (UserDialogs.Instance.Loading("doing..."))
        {
            await Task.Delay(1000);
            m_count++;
            CountLabel.Text = "COUNT = " + m_count;
            await Task.Delay(1000);
        }
    }
}
```

### Droid: MainActivity.cs
```
public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
{
    protected override void OnCreate(Bundle bundle)
    {
        ....
        global::Xamarin.Forms.Forms.Init(this, bundle);
        Acr.UserDialogs.UserDialogs.Init(this); // Initializing Acr Dialogs plugin
        LoadApplication(new App());
    }
}
```
