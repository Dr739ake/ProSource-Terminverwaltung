namespace ProSource_Terminverwaltungssoftware
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripSplitButton1 = new ToolStripDropDownButton();
            neuToolStripMenuItem = new ToolStripMenuItem();
            toolStripButtonAppointment = new ToolStripButton();
            toolStripButtonInfo = new ToolStripButton();
            labelList = new Label();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Desc = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            listeToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripButtonAppointment, toolStripButtonInfo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { neuToolStripMenuItem, listeToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(67, 22);
            toolStripSplitButton1.Text = "Kontakte";
            // 
            // neuToolStripMenuItem
            // 
            neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            neuToolStripMenuItem.Size = new Size(180, 22);
            neuToolStripMenuItem.Text = "Neu";
            neuToolStripMenuItem.Click += neuToolStripMenuItem_Click;
            // 
            // toolStripButtonAppointment
            // 
            toolStripButtonAppointment.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonAppointment.Image = (Image)resources.GetObject("toolStripButtonAppointment.Image");
            toolStripButtonAppointment.ImageAlign = ContentAlignment.MiddleRight;
            toolStripButtonAppointment.ImageTransparentColor = Color.Magenta;
            toolStripButtonAppointment.Name = "toolStripButtonAppointment";
            toolStripButtonAppointment.Size = new Size(53, 22);
            toolStripButtonAppointment.Text = "Termine";
            // 
            // toolStripButtonInfo
            // 
            toolStripButtonInfo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonInfo.Image = (Image)resources.GetObject("toolStripButtonInfo.Image");
            toolStripButtonInfo.ImageTransparentColor = Color.Magenta;
            toolStripButtonInfo.Name = "toolStripButtonInfo";
            toolStripButtonInfo.Size = new Size(32, 22);
            toolStripButtonInfo.Text = "Info";
            // 
            // labelList
            // 
            labelList.AutoSize = true;
            labelList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelList.Location = new Point(12, 37);
            labelList.Name = "labelList";
            labelList.Size = new Size(126, 30);
            labelList.TabIndex = 1;
            labelList.Text = "Terminliste:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Time, Desc, Contact });
            dataGridView1.Location = new Point(12, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 368);
            dataGridView1.TabIndex = 2;
            // 
            // Date
            // 
            Date.HeaderText = "Datum";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Resizable = DataGridViewTriState.False;
            // 
            // Time
            // 
            Time.HeaderText = "Uhrzeit";
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Resizable = DataGridViewTriState.False;
            // 
            // Desc
            // 
            Desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Desc.HeaderText = "Kurzbeschreibung";
            Desc.Name = "Desc";
            Desc.ReadOnly = true;
            Desc.Resizable = DataGridViewTriState.False;
            // 
            // Contact
            // 
            Contact.HeaderText = "Kontakt";
            Contact.Name = "Contact";
            Contact.ReadOnly = true;
            Contact.Resizable = DataGridViewTriState.False;
            Contact.Width = 150;
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(180, 22);
            listeToolStripMenuItem.Text = "Liste";
            listeToolStripMenuItem.Click += listeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(labelList);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "ProSource - Terminverwaltung";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAppointment;
        private ToolStripButton toolStripButtonInfo;
        private Label labelList;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn Contact;
        private ToolStripDropDownButton toolStripSplitButton1;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
    }
}
