using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Repository _repository = new Repository();

        public MainWindow()
        {
            InitializeComponent();
            UpdateNotes();
        }
        private void UpdateNotes()
        {
            notesBox.ItemsSource = null;
            notesBox.ItemsSource = _repository.Notess;
        }

        private void OnSubjectAdd(object sender, RoutedEventArgs e)
        {
            var window = new EditNoteWindow(_repository);
            if (window.ShowDialog() == true)
                UpdateNotes();
        }

        private void OnSubjectEdited(object sender, RoutedEventArgs e)
        {
            if (notesBox.SelectedItem != null)
            {
                var note = notesBox.SelectedItem as Notes;
                var window = new EditNoteWindow(_repository, note);
                if (window.ShowDialog() == true)
                    UpdateNotes();

            }
        }

        private void OnSubjectDelete(object sender, RoutedEventArgs e)
        {
            if (notesBox.SelectedItem != null)
            {
                var note = notesBox.SelectedItem as Notes;
                _repository.Notess.Remove(note);
                UpdateNotes();
            }
        }
    }
}
