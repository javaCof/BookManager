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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void BookAddButton_Click(object sender, EventArgs e)
        {
            BookRegistForm frm = new BookRegistForm();
            frm.ShowDialog(this);
        }

        private void BookSearchButton_Click(object sender, EventArgs e)
        {
            BookSearchForm frm = new BookSearchForm();
            frm.ShowDialog(this);
        }

        private void BookReviseButton_Click(object sender, EventArgs e)
        {
            BookReviseForm frm = new BookReviseForm();
            frm.ShowDialog(this);
        }

        private void BookRemoveButton_Click(object sender, EventArgs e)
        {
            BookRemoveForm frm = new BookRemoveForm();
            frm.ShowDialog(this);
        }
    }
}
