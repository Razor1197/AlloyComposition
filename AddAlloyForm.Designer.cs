namespace Alloy_composition
{
    partial class AddAlloyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zawartosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Add_element_button = new System.Windows.Forms.Button();
            this.Clear_elements_button = new System.Windows.Forms.Button();
            this.End_button = new System.Windows.Forms.Button();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Percent_box = new System.Windows.Forms.TextBox();
            this.Price_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nazwa,
            this.Zawartosc});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(204, 325);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Nazwa";
            this.Nazwa.Width = 101;
            // 
            // Zawartosc
            // 
            this.Zawartosc.Text = "Zawartość";
            this.Zawartosc.Width = 99;
            // 
            // Add_element_button
            // 
            this.Add_element_button.Location = new System.Drawing.Point(254, 94);
            this.Add_element_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_element_button.Name = "Add_element_button";
            this.Add_element_button.Size = new System.Drawing.Size(92, 32);
            this.Add_element_button.TabIndex = 1;
            this.Add_element_button.Text = "Dodaj";
            this.Add_element_button.UseVisualStyleBackColor = true;
            this.Add_element_button.Click += new System.EventHandler(this.Add_element_button_Click);
            // 
            // Clear_elements_button
            // 
            this.Clear_elements_button.Location = new System.Drawing.Point(254, 132);
            this.Clear_elements_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clear_elements_button.Name = "Clear_elements_button";
            this.Clear_elements_button.Size = new System.Drawing.Size(92, 32);
            this.Clear_elements_button.TabIndex = 2;
            this.Clear_elements_button.Text = "Wyczyść";
            this.Clear_elements_button.UseVisualStyleBackColor = true;
            // 
            // End_button
            // 
            this.End_button.Location = new System.Drawing.Point(254, 284);
            this.End_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.End_button.Name = "End_button";
            this.End_button.Size = new System.Drawing.Size(92, 32);
            this.End_button.TabIndex = 3;
            this.End_button.Text = "Koniec";
            this.End_button.UseVisualStyleBackColor = true;
            this.End_button.Click += new System.EventHandler(this.End_button_Click);
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(262, 24);
            this.Name_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(76, 20);
            this.Name_box.TabIndex = 4;
            // 
            // Percent_box
            // 
            this.Percent_box.Location = new System.Drawing.Point(261, 63);
            this.Percent_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Percent_box.Name = "Percent_box";
            this.Percent_box.Size = new System.Drawing.Size(76, 20);
            this.Percent_box.TabIndex = 5;
            // 
            // Price_box
            // 
            this.Price_box.Location = new System.Drawing.Point(263, 205);
            this.Price_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Price_box.Name = "Price_box";
            this.Price_box.Size = new System.Drawing.Size(76, 20);
            this.Price_box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nazwa pierwiastka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zawartosc %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cena stopu";
            // 
            // AddAlloyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price_box);
            this.Controls.Add(this.Percent_box);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.End_button);
            this.Controls.Add(this.Clear_elements_button);
            this.Controls.Add(this.Add_element_button);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddAlloyForm";
            this.Text = "AddAlloyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.ColumnHeader Zawartosc;
        private System.Windows.Forms.Button Add_element_button;
        private System.Windows.Forms.Button Clear_elements_button;
        private System.Windows.Forms.Button End_button;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.TextBox Percent_box;
        private System.Windows.Forms.TextBox Price_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}