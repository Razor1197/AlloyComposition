using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Alloy_composition
{
    public partial class MainForm : Form
    {
        public List<Alloy> AlloyList = new List<Alloy>();
        public List<string> RestrictionList = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_alloy_button_Click(object sender, EventArgs e)
        {
            AddAlloyForm newActivity = new AddAlloyForm(AlloyList);
            newActivity.ShowDialog();
            RefreshListViewAlloys();
        }

        private void Add_restictions_button_Click(object sender, EventArgs e)
        {
            AddRestrictionsForm newActivity = new AddRestrictionsForm(RestrictionList);
            newActivity.ShowDialog();
            RefreshListViewRestrictions();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //    
        }

        private void RefreshListViewAlloys()
        {
            listView1.Items.Clear();

            for(int i = 0; i < AlloyList.Count; i++)
            {
                ListViewItem item = new ListViewItem((i+1).ToString());

                string tempElements = "";
                for(int j = 0; j < AlloyList[i].ElementsList.Count; j++)
                {
                    tempElements = tempElements + AlloyList[i].ElementsList[j].Name + " - " + AlloyList[i].ElementsList[j].percent.ToString() + "%" + " ";
                }
                
                item.SubItems.Add(tempElements);
                item.SubItems.Add(AlloyList[i].price.ToString());

                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void RefreshListViewRestrictions()
        {
            listView2.Items.Clear();

            for(int i = 0; i < RestrictionList.Count; i = i + 2)
            {
                ListViewItem item = new ListViewItem(RestrictionList[i]);
                item.SubItems.Add(RestrictionList[i+1]);
                listView2.Items.Add(item);
            }

            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            using (var tw = new System.IO.StreamWriter("Variables.txt"))
            {
                for (int i = 0; i < AlloyList.Count; i++)
                {
                    tw.WriteLine("Stop" + i);
                }
            }

            using (var tw = new System.IO.StreamWriter("Constraints.txt"))
            {
                string tmp = "";
                for (int i = 0; i < AlloyList.Count; i++)
                {
                    tmp = tmp + AlloyList[i].price.ToString() + "*" + "Variables_list[" + i.ToString() + "]" + "+";
                }

                tw.WriteLine(tmp.Substring(0, tmp.Length - 1));

                for (int i = 0; i < RestrictionList.Count; i = i + 2)
                {
                    tmp = "";
                    for (int j = 0; j < AlloyList.Count; j++)
                    {
                        for (int k = 0; k < AlloyList[j].ElementsList.Count; k++)
                        {
                            if(AlloyList[j].ElementsList[k].Name == RestrictionList[i]) tmp = tmp + "0.01 *" + AlloyList[j].ElementsList[k].percent.ToString() + "*" + "Variables_list[" + j.ToString() + "]" + "+";
                        }
                    }
                    tw.WriteLine(tmp.Substring(0, tmp.Length - 1) + RestrictionList[i+1]);
                }
            }

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = "Solver.py"
                }
            };

            process.Start();
            process.WaitForExit();

            using (var sr = new System.IO.StreamReader("output.txt"))
            {
                textBox1.Text = sr.ReadToEnd();
            }
        }
    }
}
