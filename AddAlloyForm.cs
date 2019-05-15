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
    public partial class AddAlloyForm : Form
    {
        public Alloy newAlloy = new Alloy();
        public List<Alloy> AlloyList = new List<Alloy>();

        public AddAlloyForm(List<Alloy> AlloyList)
        {
            this.AlloyList = AlloyList;
            InitializeComponent();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void End_button_Click(object sender, EventArgs e)
        {
            if(Price_box.Text != "") newAlloy.price = float.Parse(Price_box.Text);

            AlloyList.Add(newAlloy);

            this.Close();
        }

        private void Add_element_button_Click(object sender, EventArgs e)
        {
            Element newElement = new Element(Name_box.Text, float.Parse(Percent_box.Text));
            newAlloy.ElementsList.Add(newElement);

            ListViewItem item = new ListViewItem(newElement.Name);

            item.SubItems.Add(newElement.percent.ToString());

            listView1.Items.Add(item);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
