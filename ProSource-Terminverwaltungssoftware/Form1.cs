using MySqlConnector;

namespace ProSource_Terminverwaltungssoftware
{
    public partial class Form1 : Form
    {
        List<Contact> contacts = new();
        public Form1()
        {
            InitializeComponent();
        }

        public void Save(Contact contact)
        {
            contacts.Add(contact);
        }

        public void UpdateLocalContactList()
        {
            string constr = "Server=cloud.jnsdev.de; User ID=ProSource; Password=4IzGsWTEJk; Database=ProSource;";
            using var cn = new MySqlConnection(constr);
            cn.Open();
            string querry = "select * from Kontakte;";
            using var cmd = new MySqlCommand(querry, cn);
            using var reader = cmd.ExecuteReader();

            contacts.Clear();
            while (reader.Read())
            {
                Contact c = new Contact();

                c.anrede = (string)reader["anrede"];
                c.name = (string)reader["name"];
                c.vorname = (string)reader["vorname"];
                c.strassse = (string)reader["strasse"];
                c.ort = (string)reader["ort"];
                c.plz = (string)reader["plz"];
                c.tel = (string)reader["tel"];
                c.mobil = (string)reader["mobil"];
                c.firma = (string)reader["firma"];
                c.abteilung = (string)reader["abteilung"];
                c.b2b = (bool)reader["b2b"];

                contacts.Add(c);
            }
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
