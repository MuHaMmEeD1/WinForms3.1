using System.Text.Json;
using System.Windows.Forms;

namespace WinForms_C__LESSON_3._1
{
    public partial class Form1 : Form
    {

        public List<Person> persons = new List<Person>() { new Person("default", "defaultlu", "defdefdefdefdefd@gmail.com", "0777777777", DateTime.Now) };

        public Form1()
        {
            InitializeComponent();
            personListBox1.DataSource = persons;
        }

        private void nameTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void elaveEtButton_Click(object sender, EventArgs e)
        {

            bool nameYoxla = true;
            bool surnameYoxla = true;
            bool emailYoxla = true;
            bool telefonYoxla = true;

            if (nameTextBox1.Text.Length == 0) { nameYoxla = false; }

            for (int i = 0; i < nameTextBox1.Text.Length; i++)
            {
                if (!((int)nameTextBox1.Text[i] > 64 && (int)nameTextBox1.Text[i] < 91 || (int)nameTextBox1.Text[i] > 96 && (int)nameTextBox1.Text[i] < 123)) { nameYoxla = false; break; }
            }


            if (surnametextBox1.Text.Length == 0) { surnameYoxla = false; }

            for (int i = 0; i < surnametextBox1.Text.Length; i++)
            {
                if (!((int)surnametextBox1.Text[i] > 64 && (int)surnametextBox1.Text[i] < 91 || (int)surnametextBox1.Text[i] > 96 && (int)surnametextBox1.Text[i] < 123)) { surnameYoxla = false; break; }
            }

            string gml = "@gmail.com";

            if (emailTextBox1.Text.Length == 26)
            {
                for (int i = 0; i < emailTextBox1.Text.Length; i++)
                {

                    if (i < 16) { if (!((int)emailTextBox1.Text[i] > 96 && (int)emailTextBox1.Text[i] < 123 || (int)emailTextBox1.Text[i] > 47 && (int)emailTextBox1.Text[i] < 58)) { emailYoxla = false; break; } }
                    else
                    {
                        if (emailTextBox1.Text[i] != gml[i - 16]) { emailYoxla = false; break; };
                    }

                }
            }
            else { emailYoxla = false; }

            if (TelefonTextBox1.Text.Length == 10)
            {
                for (int i = 0; i < TelefonTextBox1.Text.Length; i++)
                {
                    if (!((int)TelefonTextBox1.Text[i] > 47 && (int)TelefonTextBox1.Text[i] < 58)) { telefonYoxla = false; break; }
                }
            }
            else { telefonYoxla = false; }

            if (!nameYoxla) { eroreLabel.Text = "Ada sef var"; return; }
            else if (!surnameYoxla) { eroreLabel.Text = "Soy ada sef var"; return; }
            else if (!emailYoxla) { eroreLabel.Text = "emailde sef var"; return; }
            else if (!telefonYoxla) { eroreLabel.Text = "telefonda sef var"; return; }

            persons.Add(new Person(nameTextBox1.Text, surnametextBox1.Text, emailTextBox1.Text, TelefonTextBox1.Text, dateTimePicker1.Value));

            nameTextBox1.Text = "";
            surnametextBox1.Text = "";
            emailTextBox1.Text = "";
            TelefonTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;

            personListBox1.DataSource = null;
            personListBox1.DataSource = persons;

        }

        private void deyisButton_Click(object sender, EventArgs e)
        {

            Person p1 = (personListBox1.SelectedItem as Person);

            nameTextBox1.Text = p1.name;
            surnametextBox1.Text = p1.surname;
            emailTextBox1.Text = p1.email;
            TelefonTextBox1.Text = p1.phone;
            dateTimePicker1.Value = p1.DateTime;

            persons.Remove(p1);

            personListBox1.DataSource = null;
            personListBox1.DataSource = persons;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "All File|*.*|Json|*.json";

            var secim = openFileDialog1.ShowDialog();

            if (secim == DialogResult.OK)
            {


                string json = JsonSerializer.Serialize(persons, new JsonSerializerOptions() { WriteIndented = true });


                File.WriteAllText(openFileDialog1.FileName, json);

            }

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "All File|*.*|Json|*.json";

            var secim = openFileDialog1.ShowDialog();

            if (secim == DialogResult.OK)
            {


                persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(openFileDialog1.FileName));

                personListBox1.DataSource = null;
                personListBox1.DataSource = persons;

                fileAdilabel.Text = openFileDialog1.FileName;

            }



        }
    }
}