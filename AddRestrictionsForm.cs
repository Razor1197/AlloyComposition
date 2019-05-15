using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alloy_composition
{
    public partial class AddRestrictionsForm : Form
    {
        public List<string> RestrictionList = new List<string>();

        public AddRestrictionsForm(List<string> RestrictionList)
        {
            this.RestrictionList = RestrictionList;
            InitializeComponent();
        }

        private void End_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_restriction_button_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem(Left_box.Text);
            item1.SubItems.Add(Middle_box.Text + " " + Right_box.Text);
            listView1.Items.Add(item1);

            RestrictionList.Add(Left_box.Text);
            RestrictionList.Add(Middle_box.Text + " " + Right_box.Text);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
