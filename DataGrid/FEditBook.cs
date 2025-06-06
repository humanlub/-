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
    public partial class FEditBook : Form
    {
         
        public delegate void DelegateUpdateBook(Book updatedBook);
        public event DelegateUpdateBook BookUpdatedEvent;
        public Book EditedBook { get; set; }
        public FEditBook()
        {
            InitializeComponent();
        }

        private void FEditBook_Load(object sender, EventArgs e)
        {
            bookBindingSource.Add(EditedBook);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK2_Click(object sender, EventArgs e)
        {
            Book bookUpdated = (Book)bookBindingSource.Current;
            if (BookUpdatedEvent != null)
            {
                BookUpdatedEvent(bookUpdated);
            }
            Close();
        }
    }
   
    
}
