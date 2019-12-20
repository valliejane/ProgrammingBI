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
        private readonly Notees _notes;
        public EditNoteWindow(Repository repository, Notees notes=null)
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
            if (_notes == null)
            {
                _repository.Notess.Add(new Notees()
                {
                    Note = noteTextbox.Text,

                });
            }
            else
            {
                _notes.Note = noteTextbox.Text;

            }

            Close();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
