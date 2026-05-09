using SteCvp.Presentation.Maui.Services;

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
            var pokemonCards = await _restService.GetPokemonCardsAsync(); // Haalt de lijst van Pokemon-kaarten op van de REST API

            PokemonCardsListView.ItemsSource = pokemonCards; // Stelt de ItemsSource van de ListView in op de opgehaalde lijst van Pokemon-kaarten
        }
    }

}
