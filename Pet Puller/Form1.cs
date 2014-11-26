using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace Pet_Puller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class Character
        {
            public string name;
            public string realm;
            public Pet pets;
        }

        class Pet
        {
            public CollectedPets[] collected;
        }

        class CollectedPets
        {
            public string name;
        }
        private void PullDataBtn_Click(object sender, EventArgs e)
        {
            //remote test 
            string character = CharacterTextBox.Text;
            string realm = RealmTextBox.Text;
            string someUri = "http://us.battle.net/api/wow/character/" + realm + "/" + @character + "?fields=pets";
            string downloadedJson;

            try
            {
                using (WebClient json = new WebClient())
                {
                    downloadedJson = json.DownloadString(someUri);
                    Character c = JsonConvert.DeserializeObject<Character>(downloadedJson);

                    for (int i = 0; i < c.pets.collected.Length; i++)
                    {
                        PetListBox.Items.Add(c.pets.collected[i].name);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Character or Realm", "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}