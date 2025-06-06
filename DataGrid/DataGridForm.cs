using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class DataGridForm: Form
    {
        public DataGridForm()
        {
            InitializeComponent();
        }
        private List<Book> books = new List<Book>();
        private bool cancelContextMenu = false;

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            InitTestBooksData();
            RefreshGridAndBookDetails();
            UpdateButtonAddBookState();
        }
        private void InitTestBooksData()
        {
            books.Add(new Book("Война и мир", "Лев Николаевич Толстой",DateTime.Parse("1867-01-01")));
            books.Add(new Book("Анна Каренина", "Лев Николаевич Толстой",DateTime.Parse("1877-01-01")));
            books.Add(new Book("После бала", "Лев Николаевич Толстой",DateTime.Parse("1911-01-01")));
            books.Add(new Book("Юность", "Лев Николаевич Толстой",DateTime.Parse("1857-01-01")));
            books.Add(new Book("Кавказский пленник", "Лев Николаевич Толстой", DateTime.Parse("1872 - 01 - 01"))); 
            books.Add(new Book("Преступление и наказание", "Фёдор Михайлович Достоевский", DateTime.Parse("1866 - 01 - 01"))); 
            books.Add(new Book("Евгений Онегин", "Александр Сергеевич Пушкин", DateTime.Parse("1833 - 01 - 01"))); 
            books.Add(new Book("Капитанская дочка", "Александр Сергеевич Пушкин", DateTime.Parse("1836 - 01 - 01"))); 
            books.Add(new Book("Руслан и Людмила", "Александр Сергеевич Пушкин", DateTime.Parse("1820 - 01 - 01"))); 
            books.Add(new Book("Метель", "Александр Сергеевич Пушкин",DateTime.Parse("1831-01-01")));
            books.Add(new Book("Пиковая дама", "Александр Сергеевич Пушкин",DateTime.Parse("1834-01-01")));
            books.Add(new Book("Мать", "Максим Горький",DateTime.Parse("1906-01-01")));
            books.Add(new Book("Мёртвые души", "Николай Васильевич Гоголь",DateTime.Parse("1842-01-01")));
            books.Add(new Book("Шинель", "Николай Васильевич Гоголь",DateTime.Parse("1842-01-01")));
            books.Add(new Book("Тарас Бульба", "Николай Васильевич Гоголь",DateTime.Parse("1835-01-01")));
            books.Add(new Book("Нос", "Николай Васильевич Гоголь",DateTime.Parse("1836-01-01")));
            books.Add(new Book("Вечера на хуторе близ Диканьки", "Николай Васильевич Гоголь", DateTime.Parse("1830 - 01 - 01"))); 
            books.Add(new Book("Ночь перед рождеством", "Николай Васильевич Гоголь", DateTime.Parse("1832 - 01 - 01"))); 
            books.Add(new Book("Вий", "Николай Васильевич Гоголь",DateTime.Parse("1835-01-01")));
            books.Add(new Book("Повесть о капитане Копейкине", "Николай Васильевич Гоголь", DateTime.Parse("1842 - 01 - 01"))); 
            books.Add(new Book("Заколдованное место", "Николай Васильевич Гоголь", DateTime.Parse("1832 - 01 - 01"))); 
            books.Add(new Book("Портрет", "Николай Васильевич Гоголь",DateTime.Parse("1835-01-01")));
            books.Add(new Book("Тихий Дон", "Михаил Александрович Шолохов",DateTime.Parse("1928-01-01")));
        }
        private List<Book> GetFilteredBooks()
        {
            List<Book> result = new List<Book>();

            string searchString = searchtextbox.Text;

            if (searchString.Length == 0)
            {
                return books;
            }

            searchString = searchString.ToLower();

            foreach (Book book in books)
            {
                if ((book.Title.Length > 0 &&book.Title.ToLower().Contains(searchString)) ||
                    (book.Author.Length > 0 &&book.Author.ToLower().Contains(searchString)) ||
                    (book.YearPubl.Length > 0 &&book.YearPubl.Contains(searchString)))
                {
                    result.Add(book);
                }
            }
            return result;
        }
        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GetFilteredBooks();
            dataGridView1.Columns["Title"].HeaderText = "Название";
            dataGridView1.Columns["Title"].Width = 200;
            dataGridView1.Columns["Author"].HeaderText = "Автор";
            dataGridView1.Columns["Author"].Width = 200;
            dataGridView1.Columns["DatePublished"].HeaderText = "Дата издания"; 
            dataGridView1.Columns["DatePublished"].Width = 200;
            dataGridView1.Columns["DatePublished"].Visible = false;
            dataGridView1.Columns["YearPublished"].HeaderText = "Год публикации"; 
            dataGridView1.Columns["YearPublished"].Width = 126;
        }
        private void UpdateBooksListDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Books: [\r\n");
            foreach (Book b in books)
            {
                sb.Append(b.ToString());
                sb.Append("\r\n");
            }
            sb.Append("]");

            textBox1.Text = sb.ToString();
        }
        private void RefreshGridAndBookDetails()
        {
            RefreshDataGridView();
            UpdateBooksListDetails();
        }
        private void UpdateButtonAddBookState()
        {
            Addbook.Enabled = textBox2.Text.Length > 0 &&
            textBox3.Text.Length > 0;
        }
        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime truncatedDate = DateTime.Parse(selectedDate.ToString("dd.MM.yyyy")); Book newBook = new Book(textBox2.Text, textBox3.Text,truncatedDate);
            books.Add(newBook);
            RefreshGridAndBookDetails();
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox2.Focus();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;

                DataGridViewCell cell = dataGridView1[col, row];

                object cellValue = cell.Value;

                Book book = books[row];
                switch (col)
                {
                    case 0:
                        book.Title = (string)cellValue;
                        break;
                    case 1:
                        book.Author = (string)cellValue;
                        break;
                    case 2:
                        book.DataPublished = (DateTime)cellValue;
                        break;

                }
                UpdateBooksListDetails();
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0 && hitTestInfo.ColumnIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hitTestInfo.RowIndex].Selected = true;
                    cancelContextMenu = false;
                }
                else
                {
                    cancelContextMenu = true;
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            object editedValue = dataGridView1[col, row].EditedFormattedValue;

            if (e.Exception is FormatException fe && col == 2)
            {
                MessageBox.Show("Введите корректную дату, т.к. значение '" +
                editedValue.ToString() + "' не является датой", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (cancelContextMenu)
            {
                e.Cancel = true;
            }
        }

        private void removebook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows =dataGridView1.SelectedRows;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                Book book = books[rowIndex];

                DialogResult dlgConfirm = MessageBox.Show("Удалить эту книгу ?\r\n\r\nАвтор: " + book.Author + "\r\nНазвание: " + book.Title + "\r\nГодпубликации: " + book.YearPubl, "Подтвердите", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlgConfirm == DialogResult.Yes)
                {
                    books.RemoveAt(rowIndex);
                }
            }

            RefreshGridAndBookDetails();
        }

        private void MenuItemEditBook_Click(object sender, EventArgs e)
        {
          
        }

        private void editbook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                Book book = books[rowIndex];

                FEditBook frmEdit = new FEditBook();
                frmEdit.EditedBook = book;
                frmEdit.BookUpdatedEvent += FrmEdit_BookUpdatedEvent;
                frmEdit.Show();
            }
        }
        private void FrmEdit_BookUpdatedEvent(Book updatedBook)
        {
            RefreshGridAndBookDetails();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddBookState();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddBookState();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGridView(); 
        }

        private void Addbook_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime truncatedDate = DateTime.Parse(selectedDate.ToString("dd.MM.yyyy"));
            Book newBook = new Book(textBox2.Text, textBox3.Text, truncatedDate);
            books.Add(newBook);
            RefreshGridAndBookDetails();
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox2.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
