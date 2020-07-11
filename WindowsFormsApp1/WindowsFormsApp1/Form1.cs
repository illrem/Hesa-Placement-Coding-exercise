using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            listView.Items.Clear();
            ArrayList bees = Program.getBees();

            foreach (Bees bee in bees)
            {
                ListViewItem item = new ListViewItem(bee.getBeeType());
                item.SubItems.Add(bee.getHealth().ToString());
                item.SubItems.Add(bee.getIsDead());
                listView.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.damageBees();
            update();
        }
    }
}
