using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DapperLibrary;
using DapperLibrary.Interfaces;
using DapperLibrary.Models;

namespace EindopgaveDapper
{
    public partial class Form1 : Form
    {
        IOpleidingenServices opleidingenServices = new OpleidingenServices();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var campus = opleidingenServices.GetCampuses();
            foreach (var item in campus)
            {
                cmbSelectCampus.Items.Add(item);
            }

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IDocent newDocent = new Docent();
            newDocent.Voornaam = txtFirstName.Text;
            newDocent.Familienaam = txtLastName.Text;
            newDocent.Wedde = Convert.ToInt32(txtWedde.Text);
            newDocent.CampusNr = cmbSelectCampus.SelectedIndex + 1;

            opleidingenServices.AddNewDocent(newDocent);
            lstSelectDocent.DataSource = opleidingenServices.GetDocents();
        }

        private void lstSelectDocent_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFirstName.Text = lstSelectDocent.SelectedItem.ToString();
            txtLastName.Text = lstSelectDocent.SelectedItem.ToString();

            lblDetailsFirstName.Text = "First Name: " + txtFirstName.Text.ToString();
            lblDetailsLastName.Text = "Last Name: " + txtLastName.Text.ToString();
            lblDetailsWedde.Text = "Wedde: " + txtWedde.Text.ToString();
        }

        private void cmbSelectCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCampus = cmbSelectCampus.SelectedIndex + 1;
            var docents = opleidingenServices.GetDocents().Where(x => x.CampusNr== selectedCampus).ToList();
            lstSelectDocent.DataSource = docents;
        }
    }
}
