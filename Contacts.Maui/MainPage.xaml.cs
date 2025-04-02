namespace Contacts.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void OnCameraButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                if (photo != null)
                {
                    // Guarda la foto en una ubicación temporal
                    var stream = await photo.OpenReadAsync();
                    // Aquí puedes procesar la imagen, guardarla o mostrarla
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudo abrir la cámara: {ex.Message}", "OK");
            }
        }

        // Lógica para el botón de la hamburguesa
        private void OnHamburgerClick(object sender, EventArgs e)
        {
            // Aquí agregarías la lógica para mostrar el menú de navegación
        }

        // Lógica para el botón de búsqueda
        private void OnSearchClick(object sender, EventArgs e)
        {
            // Aquí agregarías la lógica para la búsqueda
        }
    }
}
