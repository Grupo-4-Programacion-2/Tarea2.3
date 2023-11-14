
using Plugin.AudioRecorder;
using Tarea2._3.DB;

namespace Tarea2._3
{
    public partial class ListPage : ContentPage
    {
  
        public ListPage()
        {
            InitializeComponent();
        }

        private void LoadAudioList()
        {
            // Obtener la lista de audios desde la base de datos y asignarla al ListView.
            
        }


        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var selectedAudio = (AudioRecord)e.SelectedItem;
                // Implementar lógica para reproducir el audio seleccionado.
            }
        }


    }
}