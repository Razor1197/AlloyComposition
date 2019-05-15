namespace Alloy_composition
{
    partial class AddRestrictionsForm
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
            this.Middle_box = new System.Windows.Forms.ComboBox();
            this.Left_box = new System.Windows.Forms.TextBox();
            this.Right_box = new System.Windows.Forms.TextBox();
            this.Add_restriction_button = new System.Windows.Forms.Button();
            this.Clear_restrictions_button = new System.Windows.Forms.Button();
            this.End_button = new System.Windows.Forms.Button();
            this.headerPierwiastek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerRestriction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerPierwiastek,
            this.headerRestriction});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(163, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Middle_box
            // 
            this.Middle_box.FormattingEnabled = true;
            this.Middle_box.Items.AddRange(new object[] {
            "==",
            "<",
            ">",
            "<=",
            ">=",
            "!="});
            this.Middle_box.Location = new System.Drawing.Point(271, 49);
            this.Middle_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Middle_box.Name = "Middle_box";
            this.Middle_box.Size = new System.Drawing.Size(80, 21);
            this.Middle_box.TabIndex = 2;
            // 
            // Left_box
            // 
            this.Left_box.Location = new System.Drawing.Point(191, 49);
            this.Left_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Left_box.Name = "Left_box";
            this.Left_box.Size = new System.Drawing.Size(76, 20);
            this.Left_box.TabIndex = 3;
            // 
            // Right_box
            // 
            this.Right_box.Location = new System.Drawing.Point(355, 49);
            this.Right_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Right_box.Name = "Right_box";
            this.Right_box.Size = new System.Drawing.Size(76, 20);
            this.Right_box.TabIndex = 4;
            // 
            // Add_restriction_button
            // 
            this.Add_restriction_button.Location = new System.Drawing.Point(262, 93);
            this.Add_restriction_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_restriction_button.Name = "Add_restriction_button";
            this.Add_restriction_button.Size = new System.Drawing.Size(88, 33);
            this.Add_restriction_button.TabIndex = 5;
            this.Add_restriction_button.Text = "Dodaj";
            this.Add_restriction_button.UseVisualStyleBackColor = true;
            this.Add_restriction_button.Click += new System.EventHandler(this.Add_restriction_button_Click);
            // 
            // Clear_restrictions_button
            // 
            this.Clear_restrictions_button.Location = new System.Drawing.Point(262, 140);
            this.Clear_restrictions_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clear_restrictions_button.Name = "Clear_restrictions_button";
            this.Clear_restrictions_button.Size = new System.Drawing.Size(88, 33);
            this.Clear_restrictions_button.TabIndex = 6;
            this.Clear_restrictions_button.Text = "Wyczyść";
            this.Clear_restrictions_button.UseVisualStyleBackColor = true;
            // 
            // End_button
            // 
            this.End_button.Location = new System.Drawing.Point(262, 252);
            this.End_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.End_button.Name = "End_button";
            this.End_button.Size = new System.Drawing.Size(88, 33);
            this.End_button.TabIndex = 7;
            this.End_button.Text = "Koniec";
            this.End_button.UseVisualStyleBackColor = true;
            this.End_button.Click += new System.EventHandler(this.End_button_Click);
            // 
            // headerPierwiastek
            // 
            this.headerPierwiastek.Text = "Pierwiastek";
            // 
            // headerRestriction
            // 
            this.headerRestriction.Text = "Warunek ograniczający";
            // 
            // AddRestrictionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 310);
            this.Controls.Add(this.End_button);
            this.Controls.Add(this.Clear_restrictions_button);
            this.Controls.Add(this.Add_restriction_button);
            this.Controls.Add(this.Right_box);
            this.Controls.Add(this.Left_box);
            this.Controls.Add(this.Middle_box);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddRestrictionsForm";
            this.Text = "AddRestrictions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox Middle_box;
        private System.Windows.Forms.TextBox Left_box;
        private System.Windows.Forms.TextBox Right_box;
        private System.Windows.Forms.Button Add_restriction_button;
        private System.Windows.Forms.Button Clear_restrictions_button;
        private System.Windows.Forms.Button End_button;
        private System.Windows.Forms.ColumnHeader headerPierwiastek;
        private System.Windows.Forms.ColumnHeader headerRestriction;
    }
}