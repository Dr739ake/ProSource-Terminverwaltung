using System.Data.Common;

namespace ProSource_Terminverwaltungssoftware
{
    public partial class Form1 : Form
    {
        DbDataSource dataSource;
        List<Contact> contacts = new();
        public Form1()
        {
            InitializeComponent();
        }

        public void Save(Contact contact)
        {
            contacts.Add(contact);
            
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var subForm = new AddContact(this);
            subForm.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var subForm = new ContactList();
            subForm.Show();
        }
    }
}
