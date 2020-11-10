using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Forms_ControlWork
{
    public partial class UserPanel : Form
    {
        public string DocName = "Data.xml";
        public UserPanel()
        {
            InitializeComponent();
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
        private void UserPanel_Load(object sender, EventArgs e)
        {
            Loadd();
        }
    }
}
