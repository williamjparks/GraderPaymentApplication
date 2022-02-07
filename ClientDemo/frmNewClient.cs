using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDemo
{
    public partial class frmNewClient : Form
    {
        public frmNewClient()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Client c = new Client();
            //c.ClientId = int.Parse(txtClientId.Text);
            //c.Address = txtAddress.Text;
            //c.Name = txtName.Text;
            //c.City = txtCity.Text;
            //c.State = cbxState.SelectedValue.ToString();
            //c.ZipCode = txtZipCode.Text;

            int id = 0;
            try
            {
                id = int.Parse(txtClientId.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number!");
                return;
            }

            ClientValue c = new ClientValue()
            {
                ClientId = id,
                Name = txtName.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                State = cbxState.SelectedValue.ToString(),
                ZipCode = txtZipCode.Text
            };

            try
            {
                ClientDB.AddClient(c);
                MessageBox.Show("It was successful.");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();

        }

        private void frmNewClient_Load(object sender, EventArgs e)
        {
            List<StateValue> states = StateDB.GetAllStates();
            cbxState.DataSource = states;
            cbxState.DisplayMember = "StateName"; //the property used as the data displayed on the combobox.
            cbxState.ValueMember = "StateCode"; //The hidden property

        }
    }
}
