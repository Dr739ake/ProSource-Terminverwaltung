namespace ProSource_Terminverwaltungssoftware
{
    public partial class AddContact : Form
    {
        Form1 parent;
        public AddContact(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxB2B.Checked)
            {
                checkBoxB2B.Text = "geschäftlich";
            }
            else
            {
                checkBoxB2B.Text = "privat";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxAnrede.Text != "" && 
                textBoxAbteilung.Text != "" &&
                textBoxFirma.Text != "" &&
                textBoxName.Text != "" && 
                textBoxMobil.Text != "" && 
                textBoxTel.Text != "" &&
                textBoxStrasse.Text != "" &&
                textBoxOrt.Text != "" && 
                textBoxPlz.Text != ""
                )
            {
                Contact contact = new Contact();
                contact.anrede = comboBoxAnrede.Text;
                contact.name= textBoxName.Text;
                contact.vorname = textBoxVorname.Text;
                contact.strassse = textBoxStrasse.Text;
                contact.ort = textBoxOrt.Text;
                contact.plz = textBoxPlz.Text;
                contact.tel = textBoxTel.Text;
                contact.mobil = textBoxMobil.Text;
                contact.abteilung = textBoxAbteilung.Text;
                contact.b2b = checkBoxB2B.Checked;

                parent.Save(contact);
                this.Close();
            }
            
        }
    }
}
