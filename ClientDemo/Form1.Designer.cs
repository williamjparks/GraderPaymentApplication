namespace ClientDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFindClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClentId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.cbxSelection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetSelection = new System.Windows.Forms.Button();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(641, 413);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(111, 42);
            this.btnFindClient.TabIndex = 0;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "ZIP Code:";
            // 
            // txtClentId
            // 
            this.txtClentId.Location = new System.Drawing.Point(156, 221);
            this.txtClentId.Name = "txtClentId";
            this.txtClentId.Size = new System.Drawing.Size(100, 22);
            this.txtClentId.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 263);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(166, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(156, 318);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(198, 22);
            this.txtAddress.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(156, 359);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 10;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(156, 403);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(100, 22);
            this.txtState.TabIndex = 11;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(156, 450);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.ReadOnly = true;
            this.txtZipCode.Size = new System.Drawing.Size(114, 22);
            this.txtZipCode.TabIndex = 12;
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(53, 12);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(625, 178);
            this.dgvClients.TabIndex = 13;
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);
            // 
            // cbxSelection
            // 
            this.cbxSelection.FormattingEnabled = true;
            this.cbxSelection.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxSelection.Location = new System.Drawing.Point(577, 215);
            this.cbxSelection.Name = "cbxSelection";
            this.cbxSelection.Size = new System.Drawing.Size(121, 24);
            this.cbxSelection.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(724, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 51);
            this.label7.TabIndex = 15;
            this.label7.Text = "0: residential\r\n1: commercial\r\n\r\n";
            // 
            // btnGetSelection
            // 
            this.btnGetSelection.Location = new System.Drawing.Point(600, 272);
            this.btnGetSelection.Name = "btnGetSelection";
            this.btnGetSelection.Size = new System.Drawing.Size(121, 37);
            this.btnGetSelection.TabIndex = 16;
            this.btnGetSelection.Text = "Get Selection";
            this.btnGetSelection.UseVisualStyleBackColor = true;
            this.btnGetSelection.Click += new System.EventHandler(this.btnGetSelection_Click);
            // 
            // cbxState
            // 
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Location = new System.Drawing.Point(674, 336);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(121, 24);
            this.cbxState.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "State:";
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(395, 413);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(98, 54);
            this.btnNewClient.TabIndex = 19;
            this.btnNewClient.Text = "New Client";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(395, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 54);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 485);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.btnGetSelection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxSelection);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtClentId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClentId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.ComboBox cbxSelection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetSelection;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnDelete;
    }
}

