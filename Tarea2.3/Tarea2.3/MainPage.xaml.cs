using Plugin.AudioRecorder;

namespace Tarea2._3
{
    public partial class MainPage : ContentPage
    {
        private AudioRecorderService recorder;
        public MainPage()
        {
            InitializeComponent();
            recorder = new AudioRecorderService();
        }


        private async void OnRecordClicked(object sender, EventArgs e)
        {
            if (!recorder.IsRecording)
            {
                var audioPath = await recorder.StartRecording();
                // Puedes realizar acciones adicionales al iniciar la grabación.
            }
        }

        private void OnViewListClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListPage());
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            if (recorder.IsRecording)
            {
                var audioPath = await recorder.StopRecording();
                // Guardar el audioPath en la base de datos SQLite junto con la descripción.
    
            }
        }


    }
}