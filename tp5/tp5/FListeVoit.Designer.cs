
namespace tp5
{
    partial class FListeVoit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtmodele = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Dg_Voit = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rech_Voit = new System.Windows.Forms.PictureBox();
            this.combomarque = new MetroFramework.Controls.MetroComboBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Voit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rech_Voit)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Marque";
            // 
            // txtmodele
            // 
            // 
            // 
            // 
            this.txtmodele.CustomButton.Image = null;
            this.txtmodele.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtmodele.CustomButton.Name = "";
            this.txtmodele.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtmodele.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmodele.CustomButton.TabIndex = 1;
            this.txtmodele.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmodele.CustomButton.UseSelectable = true;
            this.txtmodele.CustomButton.Visible = false;
            this.txtmodele.Lines = new string[0];
            this.txtmodele.Location = new System.Drawing.Point(374, 102);
            this.txtmodele.MaxLength = 32767;
            this.txtmodele.Name = "txtmodele";
            this.txtmodele.PasswordChar = '\0';
            this.txtmodele.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmodele.SelectedText = "";
            this.txtmodele.SelectionLength = 0;
            this.txtmodele.SelectionStart = 0;
            this.txtmodele.ShortcutsEnabled = true;
            this.txtmodele.Size = new System.Drawing.Size(164, 23);
            this.txtmodele.TabIndex = 3;
            this.txtmodele.UseSelectable = true;
            this.txtmodele.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmodele.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(294, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Modèle";
            // 
            // Dg_Voit
            // 
            this.Dg_Voit.AllowUserToResizeRows = false;
            this.Dg_Voit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Voit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg_Voit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dg_Voit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Voit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg_Voit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Voit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_Voit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dg_Voit.EnableHeadersVisualStyles = false;
            this.Dg_Voit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dg_Voit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Voit.Location = new System.Drawing.Point(13, 200);
            this.Dg_Voit.Name = "Dg_Voit";
            this.Dg_Voit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Voit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dg_Voit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dg_Voit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_Voit.Size = new System.Drawing.Size(550, 243);
            this.Dg_Voit.TabIndex = 6;
            this.Dg_Voit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Voit_CellContentClick);
            this.Dg_Voit.DoubleClick += new System.EventHandler(this.Dg_Voit_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Immatriculation";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Marque";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Modèle";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kilométrage";
            this.Column4.Name = "Column4";
            // 
            // Rech_Voit
            // 
            this.Rech_Voit.Image = global::tp5.Properties.Resources.RechVoit;
            this.Rech_Voit.Location = new System.Drawing.Point(500, 142);
            this.Rech_Voit.Name = "Rech_Voit";
            this.Rech_Voit.Size = new System.Drawing.Size(53, 52);
            this.Rech_Voit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rech_Voit.TabIndex = 7;
            this.Rech_Voit.TabStop = false;
            this.Rech_Voit.Click += new System.EventHandler(this.Rech_Voit_Click);
            // 
            // combomarque
            // 
            this.combomarque.FormattingEnabled = true;
            this.combomarque.ItemHeight = 23;
            this.combomarque.Location = new System.Drawing.Point(83, 102);
            this.combomarque.Name = "combomarque";
            this.combomarque.Size = new System.Drawing.Size(152, 29);
            this.combomarque.TabIndex = 8;
            this.combomarque.UseSelectable = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Prix";
            this.Column5.Name = "Column5";
            // 
            // FListeVoit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.combomarque);
            this.Controls.Add(this.Rech_Voit);
            this.Controls.Add(this.Dg_Voit);
            this.Controls.Add(this.txtmodele);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FListeVoit";
            this.Text = "Liste des voitures diponible";
            this.Load += new System.EventHandler(this.FListeVoit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Voit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rech_Voit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtmodele;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid Dg_Voit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox Rech_Voit;
        private MetroFramework.Controls.MetroComboBox combomarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}