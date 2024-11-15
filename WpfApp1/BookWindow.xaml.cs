using System.Windows;

namespace WpfApp1
{
    public partial class BookWindow : Window
    {
        public Book Book { get; private set; }

        public BookWindow(Book book)
        {
            InitializeComponent();
            Book = book;

            TitleTextBox.Text = book.Title;
            AuthorTextBox.Text = book.Author;
            YearTextBox.Text = book.Year.ToString();
            GenreTextBox.Text = book.Genre;
            PageCountTextBox.Text = book.PageCount.ToString();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Book.Title = TitleTextBox.Text;
            Book.Author = AuthorTextBox.Text;
            Book.Year = int.TryParse(YearTextBox.Text, out var year) ? year : 0;
            Book.Genre = GenreTextBox.Text;
            Book.PageCount = int.TryParse(PageCountTextBox.Text, out var pageCount) ? pageCount : 0;

            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
