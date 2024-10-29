namespace ProSource_Terminverwaltungssoftware
{
    partial class ContactList
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            contactBindingSource = new BindingSource(components);
            anredeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vornameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            strassseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ortDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firmaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            abteilungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            b2bDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { anredeDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, vornameDataGridViewTextBoxColumn, strassseDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn, plzDataGridViewTextBoxColumn, telDataGridViewTextBoxColumn, mobilDataGridViewTextBoxColumn, firmaDataGridViewTextBoxColumn, abteilungDataGridViewTextBoxColumn, b2bDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = contactBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1146, 489);
            dataGridView1.TabIndex = 0;
            // 
            // contactBindingSource
            // 
            contactBindingSource.DataSource = typeof(Contact);
            // 
            // anredeDataGridViewTextBoxColumn
            // 
            anredeDataGridViewTextBoxColumn.DataPropertyName = "anrede";
            anredeDataGridViewTextBoxColumn.HeaderText = "anrede";
            anredeDataGridViewTextBoxColumn.Name = "anredeDataGridViewTextBoxColumn";
            anredeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            vornameDataGridViewTextBoxColumn.DataPropertyName = "vorname";
            vornameDataGridViewTextBoxColumn.HeaderText = "vorname";
            vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            vornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strassseDataGridViewTextBoxColumn
            // 
            strassseDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            strassseDataGridViewTextBoxColumn.DataPropertyName = "strassse";
            strassseDataGridViewTextBoxColumn.HeaderText = "strassse";
            strassseDataGridViewTextBoxColumn.Name = "strassseDataGridViewTextBoxColumn";
            strassseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            ortDataGridViewTextBoxColumn.DataPropertyName = "ort";
            ortDataGridViewTextBoxColumn.HeaderText = "ort";
            ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            ortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plzDataGridViewTextBoxColumn
            // 
            plzDataGridViewTextBoxColumn.DataPropertyName = "plz";
            plzDataGridViewTextBoxColumn.HeaderText = "plz";
            plzDataGridViewTextBoxColumn.Name = "plzDataGridViewTextBoxColumn";
            plzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            telDataGridViewTextBoxColumn.HeaderText = "tel";
            telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobilDataGridViewTextBoxColumn
            // 
            mobilDataGridViewTextBoxColumn.DataPropertyName = "mobil";
            mobilDataGridViewTextBoxColumn.HeaderText = "mobil";
            mobilDataGridViewTextBoxColumn.Name = "mobilDataGridViewTextBoxColumn";
            mobilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmaDataGridViewTextBoxColumn
            // 
            firmaDataGridViewTextBoxColumn.DataPropertyName = "firma";
            firmaDataGridViewTextBoxColumn.HeaderText = "firma";
            firmaDataGridViewTextBoxColumn.Name = "firmaDataGridViewTextBoxColumn";
            firmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abteilungDataGridViewTextBoxColumn
            // 
            abteilungDataGridViewTextBoxColumn.DataPropertyName = "abteilung";
            abteilungDataGridViewTextBoxColumn.HeaderText = "abteilung";
            abteilungDataGridViewTextBoxColumn.Name = "abteilungDataGridViewTextBoxColumn";
            abteilungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b2bDataGridViewCheckBoxColumn
            // 
            b2bDataGridViewCheckBoxColumn.DataPropertyName = "b2b";
            b2bDataGridViewCheckBoxColumn.HeaderText = "b2b";
            b2bDataGridViewCheckBoxColumn.Name = "b2bDataGridViewCheckBoxColumn";
            b2bDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ContactList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 489);
            Controls.Add(dataGridView1);
            Name = "ContactList";
            Text = "ContactList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn anredeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn strassseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn abteilungDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn b2bDataGridViewCheckBoxColumn;
        private BindingSource contactBindingSource;
    }
}