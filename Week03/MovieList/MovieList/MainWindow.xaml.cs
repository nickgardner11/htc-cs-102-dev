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

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Movie> Movies = new List<Movie>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in Movies)
            {
                MessageBox.Show("The movie " + movie.Title + " was released in " + movie.ReleaseYear + "." + "\r\n" + movie.Title + "'s runtime is " + movie.Length + " hours and was directed by " + movie.Director + "." + "This movie is part of the " + movie.Genre + " genre");


            }

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int releaseYear = Convert.ToInt32(releaseYearInput.Text);
            string length = lengthInput.Text;
            string title = titleInput.Text;
            string director = directorrInput.Text;
            string genre = genreInput.Text;
        }
    }
}