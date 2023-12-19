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
            IDocent docent = lstSelectDocent.SelectedItem as Docent;
            opleidingenServices.DeleteDocent(docent);
            SelectedListOfDocents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IDocent newDocent = new Docent();
            newDocent.Voornaam = txtFirstName.Text;
            newDocent.Familienaam = txtLastName.Text;
            newDocent.Wedde = Convert.ToInt32(txtWedde.Text);
            newDocent.CampusNr = cmbSelectCampus.SelectedIndex + 1;

            opleidingenServices.AddNewDocent(newDocent);
            SelectedListOfDocents();
        }

        private void lstSelectDocent_SelectedIndexChanged(object sender, EventArgs e)
        {
             IDocent docent = lstSelectDocent.SelectedItem as Docent;
            //IDocent docent = (Docent)lstSelectDocent.SelectedItem;

            //if (docent != null)
            //{
            //    txtFirstName.Text = docent.Voornaam;
            //    txtLastName.Text = docent.Familienaam;
            //    txtWedde.Text = docent.Wedde.ToString();
            //}

            lblDetailsFirstName.Text = "First Name: " + docent.Voornaam;
            lblDetailsLastName.Text = "Last Name: " + docent.Familienaam;
            lblDetailsWedde.Text = "Wedde: " + docent.Wedde;
            btnRemove.Text = $"Delete {docent.Voornaam} {docent.Familienaam} ?";

        }

        private void cmbSelectCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedListOfDocents();
        }

        private void SelectedListOfDocents()
        {
            var selectedCampus = cmbSelectCampus.SelectedIndex + 1;
            var docents = opleidingenServices.GetDocents().Where(x => x.CampusNr == selectedCampus).ToList();
            lstSelectDocent.DataSource = docents;
        }
    }
}
