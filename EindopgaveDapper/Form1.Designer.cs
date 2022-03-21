namespace EindopgaveDapper
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
            this.lblSelectCampus = new System.Windows.Forms.Label();
            this.cmbSelectCampus = new System.Windows.Forms.ComboBox();
            this.lblSelectDocent = new System.Windows.Forms.Label();
            this.lstSelectDocent = new System.Windows.Forms.ListBox();
            this.lblDocentCampus = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblWedde = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtWedde = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDetailsOfDocent = new System.Windows.Forms.Label();
            this.lblDetailsFirstName = new System.Windows.Forms.Label();
            this.lblDetailsLastName = new System.Windows.Forms.Label();
            this.lblDetailsWedde = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectCampus
            // 
            this.lblSelectCampus.AutoSize = true;
            this.lblSelectCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCampus.Location = new System.Drawing.Point(25, 91);
            this.lblSelectCampus.Name = "lblSelectCampus";
            this.lblSelectCampus.Size = new System.Drawing.Size(152, 20);
            this.lblSelectCampus.TabIndex = 0;
            this.lblSelectCampus.Text = "Select a Campus";
            // 
            // cmbSelectCampus
            // 
            this.cmbSelectCampus.FormattingEnabled = true;
            this.cmbSelectCampus.Location = new System.Drawing.Point(29, 123);
            this.cmbSelectCampus.Name = "cmbSelectCampus";
            this.cmbSelectCampus.Size = new System.Drawing.Size(293, 24);
            this.cmbSelectCampus.TabIndex = 1;
            this.cmbSelectCampus.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCampus_SelectedIndexChanged);
            // 
            // lblSelectDocent
            // 
            this.lblSelectDocent.AutoSize = true;
            this.lblSelectDocent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDocent.Location = new System.Drawing.Point(25, 165);
            this.lblSelectDocent.Name = "lblSelectDocent";
            this.lblSelectDocent.Size = new System.Drawing.Size(128, 20);
            this.lblSelectDocent.TabIndex = 2;
            this.lblSelectDocent.Text = "Select Docent";
            // 
            // lstSelectDocent
            // 
            this.lstSelectDocent.FormattingEnabled = true;
            this.lstSelectDocent.ItemHeight = 16;
            this.lstSelectDocent.Location = new System.Drawing.Point(29, 197);
            this.lstSelectDocent.Name = "lstSelectDocent";
            this.lstSelectDocent.Size = new System.Drawing.Size(290, 84);
            this.lstSelectDocent.TabIndex = 3;
            this.lstSelectDocent.SelectedIndexChanged += new System.EventHandler(this.lstSelectDocent_SelectedIndexChanged);
            // 
            // lblDocentCampus
            // 
            this.lblDocentCampus.AutoSize = true;
            this.lblDocentCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocentCampus.Location = new System.Drawing.Point(25, 334);
            this.lblDocentCampus.Name = "lblDocentCampus";
            this.lblDocentCampus.Size = new System.Drawing.Size(206, 20);
            this.lblDocentCampus.TabIndex = 4;
            this.lblDocentCampus.Text = "Add Docent to campus ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(28, 375);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(28, 419);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // lblWedde
            // 
            this.lblWedde.AutoSize = true;
            this.lblWedde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedde.Location = new System.Drawing.Point(31, 458);
            this.lblWedde.Name = "lblWedde";
            this.lblWedde.Size = new System.Drawing.Size(52, 16);
            this.lblWedde.TabIndex = 7;
            this.lblWedde.Text = "Wedde";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(142, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(142, 375);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 22);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(142, 419);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(176, 22);
            this.txtLastName.TabIndex = 10;
            // 
            // txtWedde
            // 
            this.txtWedde.Location = new System.Drawing.Point(142, 460);
            this.txtWedde.Name = "txtWedde";
            this.txtWedde.Size = new System.Drawing.Size(176, 22);
            this.txtWedde.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(29, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 26);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Campusses and Docents";
            // 
            // lblDetailsOfDocent
            // 
            this.lblDetailsOfDocent.AutoSize = true;
            this.lblDetailsOfDocent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsOfDocent.Location = new System.Drawing.Point(491, 91);
            this.lblDetailsOfDocent.Name = "lblDetailsOfDocent";
            this.lblDetailsOfDocent.Size = new System.Drawing.Size(185, 20);
            this.lblDetailsOfDocent.TabIndex = 13;
            this.lblDetailsOfDocent.Text = "Details of a Docent :";
            // 
            // lblDetailsFirstName
            // 
            this.lblDetailsFirstName.AutoSize = true;
            this.lblDetailsFirstName.Location = new System.Drawing.Point(491, 143);
            this.lblDetailsFirstName.Name = "lblDetailsFirstName";
            this.lblDetailsFirstName.Size = new System.Drawing.Size(78, 16);
            this.lblDetailsFirstName.TabIndex = 15;
            this.lblDetailsFirstName.Text = "First Name :";
            // 
            // lblDetailsLastName
            // 
            this.lblDetailsLastName.AutoSize = true;
            this.lblDetailsLastName.Location = new System.Drawing.Point(491, 186);
            this.lblDetailsLastName.Name = "lblDetailsLastName";
            this.lblDetailsLastName.Size = new System.Drawing.Size(78, 16);
            this.lblDetailsLastName.TabIndex = 16;
            this.lblDetailsLastName.Text = "Last Name :";
            // 
            // lblDetailsWedde
            // 
            this.lblDetailsWedde.AutoSize = true;
            this.lblDetailsWedde.Location = new System.Drawing.Point(491, 231);
            this.lblDetailsWedde.Name = "lblDetailsWedde";
            this.lblDetailsWedde.Size = new System.Drawing.Size(58, 16);
            this.lblDetailsWedde.TabIndex = 17;
            this.lblDetailsWedde.Text = "Wedde :";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(495, 277);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(228, 36);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 580);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblDetailsWedde);
            this.Controls.Add(this.lblDetailsLastName);
            this.Controls.Add(this.lblDetailsFirstName);
            this.Controls.Add(this.lblDetailsOfDocent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtWedde);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblWedde);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblDocentCampus);
            this.Controls.Add(this.lstSelectDocent);
            this.Controls.Add(this.lblSelectDocent);
            this.Controls.Add(this.cmbSelectCampus);
            this.Controls.Add(this.lblSelectCampus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCampus;
        private System.Windows.Forms.ComboBox cmbSelectCampus;
        private System.Windows.Forms.Label lblSelectDocent;
        private System.Windows.Forms.ListBox lstSelectDocent;
        private System.Windows.Forms.Label lblDocentCampus;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblWedde;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtWedde;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDetailsOfDocent;
        private System.Windows.Forms.Label lblDetailsFirstName;
        private System.Windows.Forms.Label lblDetailsLastName;
        private System.Windows.Forms.Label lblDetailsWedde;
        private System.Windows.Forms.Button btnRemove;
    }
}

