using SteCvp.Presentation.Maui.Services;
using Plugin.Maui.Audio;

namespace SteCvp.Presentation.Maui
{
    public partial class MainPage : ContentPage
    {
        private readonly RestService _restService;

        public MainPage()
        {
            InitializeComponent();

            _restService = new RestService();
        }
        
        public async void OnLoadPokemonCardsClicked(object sender, EventArgs e)
        {
            if (PokemonCardsListView.ItemsSource != null) 
            {
                PokemonCardsListView.ItemsSource = null;

                LoadPokemonCardsButton.Text = "Load Pokémon Cards";

                return;
            }

            var pokemonCards = await _restService.GetPokemonCardsAsync(); // Haalt de lijst van Pokemon-kaarten op van de REST API

            PokemonCardsListView.ItemsSource = pokemonCards; // Stelt de ItemsSource van de ListView in op de opgehaalde lijst van Pokemon-kaarten

            LoadPokemonCardsButton.Text = "Hide Pokémon Cards";
        }

        private async void OnPlaySoundClicked(object sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            string pokemonName = button.CommandParameter?.ToString();

            string fileName = pokemonName switch
            {
                "Pikachu ex" => "pikachu.mp3",
                "Charizard" => "charizard.mp3",
                _ => null
            };

            if (fileName == null)
            {
                await DisplayAlert("Error", $"No sound found for {pokemonName}", "OK");
                return;
            }

            var stream = await FileSystem.OpenAppPackageFileAsync(fileName);
            var player = AudioManager.Current.CreatePlayer(stream);
            player.Play();
        }
    }

}
