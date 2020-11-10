using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Forms_ControlWork
{

    public partial class AdminPanel : Form
    {
        public List<Race> rase = new List<Race>();
        public string DocName = "Data.xml";
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
          Loadd();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) &&
                !String.IsNullOrEmpty(textBox2.Text) &&
                !String.IsNullOrEmpty(textBox3.Text))
            {
                rase.Add(new Race() { name = textBox1.Text, timeArr = textBox2.Text, timeDeparture = textBox3.Text });

                XmlSerializer serializer = new XmlSerializer(typeof(List<Race>));
                using (FileStream fs = new FileStream(DocName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    serializer.Serialize(fs, rase);
                    MessageBox.Show("Succsesfully");
                }
            }


            RefreshData();
        }


        public void RefreshData()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.dataGridView1.Rows.Clear();
            foreach (Race item in rase)
            {
                object[] row = { item.name, item.timeArr, item.timeDeparture };
                this.dataGridView1.Rows.Add(row);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                List<Race> r1 = new List<Race>();
                XmlSerializer xml = new XmlSerializer(typeof(List<Race>));
                using (FileStream fs = new FileStream(DocName, FileMode.Open, FileAccess.Read))
                {
                    r1 = xml.Deserialize(fs) as List<Race>;

                }
                r1.RemoveAt(index);
                File.Delete(DocName);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Race>));
                using (FileStream fs = new FileStream(DocName, FileMode.Create))
                {
                    serializer.Serialize(fs, r1);
                    MessageBox.Show("Succsesfully");
                }
                
            }
            RefreshData();
        }

            public void Loadd()
            {
                List<Race> r1 = new List<Race>();
                XmlSerializer xml = new XmlSerializer(typeof(List<Race>));
                using (FileStream fs = new FileStream(DocName, FileMode.Open, FileAccess.Read))
                {
                    r1 = xml.Deserialize(fs) as List<Race>;

                }
                foreach (Race item in r1)
                {
                    object[] row = { item.name, item.timeArr, item.timeDeparture };
                    this.dataGridView1.Rows.Add(row);
                }
            }

        }
    }


