namespace MauiPlanets.Views;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (this.AnimationIsRunning("TransitionAnimation"))
        {
            return;
        }

        await Task.Delay(1000); // Oodake 1 sekund

        var parentAnimation = new Animation();

        //PlanetAnimation
        parentAnimation.Add(0, 0.2, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.1, 0.3, new Animation(v => imgVenus.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgEarth.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.3, 0.5, new Animation(v => imgMars.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.4, 0.6, new Animation(v => imgJupiter.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.5, 0.7, new Animation(v => imgSaturn.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.6, 0.8, new Animation(v => imgUranus.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.7, 0.9, new Animation(v => imgNeptune.Opacity = v, 0, 1, Easing.CubicIn));

        //Intro Box
        parentAnimation.Add(0.7, 1, new Animation(v => imgIntro.Opacity = v, 0, 1, Easing.CubicIn));

        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
    }

    async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
    {
        await Task.Delay(500); // Oodake 0.5 sekundit

        if (Application.Current?.MainPage != null)
        {
            Application.Current.MainPage = new NavigationPage(new PlanetsPage());
        }
    }
}
