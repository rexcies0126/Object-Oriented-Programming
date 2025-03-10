using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Animal animal = new Animal();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            animal.AddAnimal(new Animal(textBox1.Text));
            MessageBox.Show("Animal added successfully!");
            LoadAnimals();
            textBox1.Clear();
        }

        private void LoadAnimals()
        {
            listBox1.Items.Clear();
            foreach (Animal a in animal.GetAnimals())
            {
                listBox1.Items.Add(a.Name);
            }
        }
    }
}
