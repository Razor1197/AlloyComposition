namespace Alloy_composition
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Add_alloy_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.Add_restictions_button = new System.Windows.Forms.Button();
            this.headerStop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPierwiastkiProcenty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.headerPierwiastek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerOgraniczenie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerStop,
            this.headerPierwiastkiProcenty,
            this.headerCena});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 17);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(598, 150);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Add_alloy_button
            // 
            this.Add_alloy_button.Location = new System.Drawing.Point(38, 330);
            this.Add_alloy_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_alloy_button.Name = "Add_alloy_button";
            this.Add_alloy_button.Size = new System.Drawing.Size(79, 40);
            this.Add_alloy_button.TabIndex = 1;
            this.Add_alloy_button.Text = "Dodaj stop";
            this.Add_alloy_button.UseVisualStyleBackColor = true;
            this.Add_alloy_button.Click += new System.EventHandler(this.Add_alloy_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(204, 330);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(79, 40);
            this.Clear_button.TabIndex = 2;
            this.Clear_button.Text = "Wyczyść";
            this.Clear_button.UseVisualStyleBackColor = true;
            // 
            // Calculate_button
            // 
            this.Calculate_button.Location = new System.Drawing.Point(556, 330);
            this.Calculate_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(79, 40);
            this.Calculate_button.TabIndex = 3;
            this.Calculate_button.Text = "Oblicz";
            this.Calculate_button.UseVisualStyleBackColor = true;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // Add_restictions_button
            // 
            this.Add_restictions_button.Location = new System.Drawing.Point(121, 330);
            this.Add_restictions_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_restictions_button.Name = "Add_restictions_button";
            this.Add_restictions_button.Size = new System.Drawing.Size(79, 40);
            this.Add_restictions_button.TabIndex = 4;
            this.Add_restictions_button.Text = "Dodaj ograniczenia";
            this.Add_restictions_button.UseVisualStyleBackColor = true;
            this.Add_restictions_button.Click += new System.EventHandler(this.Add_restictions_button_Click);
            // 
            // headerStop
            // 
            this.headerStop.Text = "Stop";
            this.headerStop.Width = 45;
            // 
            // headerPierwiastkiProcenty
            // 
            this.headerPierwiastkiProcenty.Text = "Pierwiastki i zawartości";
            this.headerPierwiastkiProcenty.Width = 467;
            // 
            // headerCena
            // 
            this.headerCena.Text = "Cena";
            this.headerCena.Width = 82;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerPierwiastek,
            this.headerOgraniczenie});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(38, 175);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(597, 150);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // headerPierwiastek
            // 
            this.headerPierwiastek.Text = "Pierwiastek";
            this.headerPierwiastek.Width = 71;
            // 
            // headerOgraniczenie
            // 
            this.headerOgraniczenie.Text = "Warunek ograniczający";
            this.headerOgraniczenie.Width = 100;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(451, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 387);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.Add_restictions_button);
            this.Controls.Add(this.Calculate_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Add_alloy_button);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Alloy Composition";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Add_alloy_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.Button Add_restictions_button;
        private System.Windows.Forms.ColumnHeader headerStop;
        private System.Windows.Forms.ColumnHeader headerPierwiastkiProcenty;
        private System.Windows.Forms.ColumnHeader headerCena;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader headerPierwiastek;
        private System.Windows.Forms.ColumnHeader headerOgraniczenie;
        private System.Windows.Forms.TextBox textBox1;
    }
}

