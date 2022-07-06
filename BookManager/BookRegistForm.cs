using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class BookRegistForm : Form
    {
        public BookRegistForm()
        {
            InitializeComponent();
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Isbn = IsbnTextBox.Text;
            book.Name = BookNameTextBox.Text;
            book.Publisher = PublisherTextBox.Text;
            book.Type = BookTypeTextBox.Text;
            book.Price = Convert.ToInt32(PriceTextBox.Text);
            book.RegistTime = DateTime.Now;
            
        }
    }
}
