using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadVehicles();
            LoadCars();
            LoadMotors();
        }

        private void LoadVehicles()
        {
            Vehicle vehicle = new Vehicle();
            foreach (Vehicle v in vehicle.GetVehicles())
            {
                listBox1.Items.Add(v.Name);
            }
        }

        private void LoadCars()
        {
            Vehicle car = new Car();
            foreach (Vehicle c in car.GetVehicles())
            {
                listBox2.Items.Add(c.Name);
            }
        }

        private void LoadMotors()
        {
            Vehicle motor = new Motorcycle();
            foreach (Vehicle m in motor.GetVehicles())
            {
                listBox3.Items.Add(m.Name);
            }
        }
    }
}
