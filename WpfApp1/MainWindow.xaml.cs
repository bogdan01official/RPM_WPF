using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private List<Book> books = new List<Book>();

        public MainWindow()
        {
            InitializeComponent();
            BooksListView.ItemsSource = books;
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            Book newBook = new Book();
            BookWindow bookWindow = new BookWindow(newBook);
            if (bookWindow.ShowDialog() == true)
            {
                books.Add(newBook);
                BooksListView.Items.Refresh();
            }
        }

        private void EditBookButton_Click(object sender, RoutedEventArgs e)
        {
            if (BooksListView.SelectedItem is Book selectedBook)
            {
                BookWindow bookWindow = new BookWindow(selectedBook);
                if (bookWindow.ShowDialog() == true)
                {
                    BooksListView.Items.Refresh();
                }
            }
        }

        private void DeleteBookButton_Click(object sender, RoutedEventArgs e)
        {
            if (BooksListView.SelectedItem is Book selectedBook)
            {
                books.Remove(selectedBook);
                BooksListView.Items.Refresh();
            }
        }
        private void BooksListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
        }
    }
}
