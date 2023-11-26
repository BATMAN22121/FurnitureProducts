using FurnitureI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СollegeActivity
{
    public partial class Edit : Form
    {
        public string? _editName = "";
        public Edit()
        {
            InitializeComponent();
        }



        private void Save_Click(object sender, EventArgs e)
        {
            _editName = this.NameInput.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
                this.NameInput.Text = _editName;

        }


    }
}
