using MauiPlanets.Models;
using MauiPlanets.Services;

namespace MauiPlanets.Views;

public partial class PlanetsPage : ContentPage
{
    private const uint AnimationDuration = 800u;

    public PlanetsPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Veenduge, et need kontrollid on XAML-failis m‰‰ratletud
        lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
        lstAllPlanets.ItemsSource = PlanetsService.GetAllPlanets();
    }

    async void Planets_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Planet selectedPlanet)
        {
            await Navigation.PushAsync(new PlanetsDetailsPage(selectedPlanet));
        }
        else
        {
            // K‰sitle olukorda, kus valikut ei ole
            await DisplayAlert("Viga", "Palun valige planeet.", "OK");
        }
    }

    async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
    {
        _ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
        await MainContentGrid.ScaleTo(0.8, AnimationDuration);
        _ = MainContentGrid.ScaleTo(0.8, AnimationDuration);
    }

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {
        await CloseMenu();
    }

    private async Task CloseMenu()
    {
        _ = MainContentGrid.FadeTo(1, AnimationDuration);
        _ = MainContentGrid.ScaleTo(1, AnimationDuration);
        await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }

    private void listPopularPlanets_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // K‰sitle valiku muutust
        if (e.CurrentSelection.FirstOrDefault() is Planet selectedPlanet)
        {
            // N‰iteks: n‰ita planeedi detaile
            DisplayAlert("Valitud planeet", selectedPlanet.Name, "OK");
        }
    }
}