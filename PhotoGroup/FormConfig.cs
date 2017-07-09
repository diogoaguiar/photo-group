using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoGroup
{
    public partial class FormConfig : Form
    {
        DataGridView categoriesDatagridView;

        public FormConfig()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            categoriesDatagridView = (DataGridView)this.Controls.Find("dgv_categories", true).FirstOrDefault();

            loadPreferences();
        }
        
        private void loadPreferences()
        {
            foreach (string val in Properties.Settings.Default.Categories)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxColumn collumn = new DataGridViewTextBoxColumn();
                row.Cells.Add(collumn.CellTemplate);
                row.Cells[0].Value = val;
                categoriesDatagridView.Rows.Add(row);
            }
        }

        private void savePreferences()
        {
            StringCollection categories = new StringCollection();

            foreach (DataGridViewRow row in categoriesDatagridView.Rows)
            {
                string name = row.Cells[0].Value as string;
                if (name != null && !name.Equals(""))
                {
                    categories.Add(name);
                }
            }

            Properties.Settings.Default.Categories = categories;
            Properties.Settings.Default.Save();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            savePreferences();
            this.Close();
        }
    }
}
