using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Notes
{
    /// <summary>
    /// Логика взаимодействия для EditNoteWindow.xaml
    /// </summary>
    public partial class EditNoteWindow : Window
    {
        private readonly Repository _repository;
        private readonly Notes _notes;
        public EditNoteWindow(Repository repository, Notes notes=null)
        {
            InitializeComponent();
            _repository = repository;
            _notes = notes;            

            if (notes != null)
            {
                noteTextbox.Text = notes.Note;
            }
        }

        private void OnOkClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(noteTextbox.Text))
            {
                MessageBox.Show("Error! Name is a required field", "Subject error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (_notes == null)
            {
                _repository.Notess.Add(new Notes()
                {
                    Note = noteTextbox.Text
                });
            }
            else
            {
                _notes.Note = noteTextbox.Text;
            }
            DialogResult = true;
            Close();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
