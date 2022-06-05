using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.SkyBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        class MyJson
        {
            public List<User>? JsonDeserialize()
            {
                var jsonStr = File.ReadAllText("saved.json");
                List<User>? txt = JsonConvert.DeserializeObject<List<User>>(jsonStr);
                return txt;
            }
            public void JsonSerialize(List<User> users)
            {
                var txt = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented); ;
                File.WriteAllText("saved.json", txt);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (surname.Text.Length > 0 && name.Text.Length > 0 && fname.Text.Length > 0 && country.Text.Length > 0 && city.Text.Length > 0)
            {
                MyJson myJson = new MyJson();
                User user = new User();
                user.Name = name.Text;
                user.Surname = surname.Text;
                user.Fname = fname.Text;
                user.Country = country.Text;
                user.City = city.Text;
                user.Phone = number.Text;
                user.Bday = birthday.Value;
                user.Gender = man.Checked;
                List<User>? users = myJson.JsonDeserialize();
                users.Add(user);
                myJson.JsonSerialize(users);
            }
            search_TextChanged(sender, e);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            MyJson myJson = new MyJson();

            var jsonStr = File.ReadAllText("saved.json");
            List<User>? users = JsonConvert.DeserializeObject<List<User>>(jsonStr);

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Surname.ToUpper().StartsWith(search.Text.ToUpper()) && search.Text.Length != 0)
                {
                    surname.Text = users[i].Surname;
                    name.Text = users[i].Name;
                    fname.Text = users[i].Fname;
                    country.Text = users[i].Country;
                    city.Text = users[i].City;
                    number.Text = users[i].Phone;
                    birthday.Value = new DateTime(users[i].Bday.Year, users[i].Bday.Month, users[i].Bday.Day);
                    if (users[i].Gender == true)
                        man.Checked = true;
                    else
                        woman.Checked = true;
                    return;
                }
                if (users[i].Name.ToUpper().StartsWith(search.Text.ToUpper()) && search.Text.Length != 0)
                {
                    surname.Text = users[i].Surname;
                    name.Text = users[i].Name;
                    fname.Text = users[i].Fname;
                    country.Text = users[i].Country;
                    city.Text = users[i].City;
                    number.Text = users[i].Phone;
                    birthday.Value = new DateTime(users[i].Bday.Year, users[i].Bday.Month, users[i].Bday.Day);
                    if (users[i].Gender == true)
                        man.Checked = true;
                    else
                        woman.Checked = true;
                    return;
                }
                else if (search.Text.ToUpper() == users[i].Surname.ToUpper() + " " + users[i].Name.ToUpper())
                {
                    surname.Text = users[i].Surname;
                    name.Text = users[i].Name;
                    fname.Text = users[i].Fname;
                    country.Text = users[i].Country;
                    city.Text = users[i].City;
                    number.Text = users[i].Phone;
                    birthday.Value = new DateTime(users[i].Bday.Year, users[i].Bday.Month, users[i].Bday.Day);
                    if (users[i].Gender == true)
                        man.Checked = true;
                    else
                        woman.Checked = true;
                    return;
                }

                else if (search.Text.ToUpper().StartsWith(""))
                {

                    surname.Text = "";
                    name.Text = "";
                    fname.Text = "";
                    country.Text = "";
                    city.Text = "";
                    number.Text = "";
                    birthday.Value = birthday.MinDate;
                    man.Checked = false;
                    woman.Checked = false;
                }
                
            }
        }
    }
}