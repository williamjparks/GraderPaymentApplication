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
    public partial class Form1 : Form
    {
        ClientValue selectedClient; //null

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            ClientValue client = null;
            int clientId = int.Parse(txtClentId.Text);
            try
            {
                client = ClientDB.GetClient(clientId);
                if (client != null)
                {
                    txtName.Text = client.Name;
                    txtAddress.Text = client.Address;
                    txtCity.Text = client.City;
                    txtState.Text = client.State;
                    txtZipCode.Text = client.ZipCode;
                }
                else
                {
                    MessageBox.Show("Invalid client Id.");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Database Error:" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ClientValue> list = ClientDB.GetAllClients();
            dgvClients.DataSource = list;


            List<StateValue> listStates = StateDB.GetAllStates();
            cbxState.DataSource = listStates;     
            cbxState.DisplayMember = "StateName"; //the property used as the data displayed on the combobox.
            cbxState.ValueMember = "StateCode"; //The hidden property
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            int id = (int) dgvClients.CurrentRow.Cells[0].Value;
            //Client client = ClientDB.GetClient(id);
            selectedClient = ClientDB.GetClient(id); //the client rememberred by the form object
            if (selectedClient != null)
            {
                txtClentId.Text = selectedClient.ClientId.ToString();
                txtName.Text = selectedClient.Name;
                txtAddress.Text = selectedClient.Address;
                txtCity.Text = selectedClient.City;
                txtState.Text = selectedClient.State;
                txtZipCode.Text = selectedClient.ZipCode;
            }
            else
            {
                //MessageBox.Show("Invalid client Id.");
            }

        }

        private void btnGetSelection_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbxSelection.Text);
            MessageBox.Show("State: " + cbxState.SelectedValue);
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            frmNewClient form = new frmNewClient();
            form.ShowDialog();

            //Refresh
            List<ClientValue> list = ClientDB.GetAllClients();
            dgvClients.DataSource = list;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = ClientDB.DeleteClient(selectedClient);
                if (flag)
                {
                    MessageBox.Show("It was successful");
                    //Refresh
                    List<ClientValue> list = ClientDB.GetAllClients();
                    dgvClients.DataSource = list;
                } else
                {
                    MessageBox.Show("The client does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error:" + ex.Message);
            }
        }
    }
}
