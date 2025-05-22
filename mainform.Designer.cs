namespace VeterinaryClinicApp
{
    partial class mainform
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
            panelContent = new Panel();
            linkAdmin = new LinkLabel();
            lblQAdmin = new Label();
            lblWelcome = new Label();
            panelLogo = new Panel();
            lblClin = new Label();
            pbLogo = new PictureBox();
            lblVet = new Label();
            panelContent.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(0, 61, 83);
            panelContent.Controls.Add(linkAdmin);
            panelContent.Controls.Add(lblQAdmin);
            panelContent.Controls.Add(lblWelcome);
            panelContent.Controls.Add(panelLogo);
            panelContent.Location = new Point(0, 0);
            panelContent.Margin = new Padding(4, 3, 4, 3);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1265, 681);
            panelContent.TabIndex = 1;
            // 
            // linkAdmin
            // 
            linkAdmin.AutoSize = true;
            linkAdmin.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkAdmin.LinkColor = Color.Red;
            linkAdmin.Location = new Point(731, 619);
            linkAdmin.Margin = new Padding(4, 0, 4, 0);
            linkAdmin.Name = "linkAdmin";
            linkAdmin.Size = new Size(79, 32);
            linkAdmin.TabIndex = 24;
            linkAdmin.TabStop = true;
            linkAdmin.Text = "Admin";
            linkAdmin.LinkClicked += linkAdmin_LinkClicked;
            // 
            // lblQAdmin
            // 
            lblQAdmin.AutoSize = true;
            lblQAdmin.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQAdmin.ForeColor = SystemColors.ControlLight;
            lblQAdmin.Location = new Point(434, 619);
            lblQAdmin.Margin = new Padding(4, 0, 4, 0);
            lblQAdmin.Name = "lblQAdmin";
            lblQAdmin.Size = new Size(248, 32);
            lblQAdmin.TabIndex = 22;
            lblQAdmin.Text = "Sign Up or Sign In here:";
            lblQAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Sans Serif Collection", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ControlLight;
            lblWelcome.Location = new Point(299, 272);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(632, 67);
            lblWelcome.TabIndex = 21;
            lblWelcome.Text = "Welcome to Veterinary Clinic";
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Controls.Add(lblClin);
            panelLogo.Controls.Add(pbLogo);
            panelLogo.Controls.Add(lblVet);
            panelLogo.Location = new Point(551, 34);
            panelLogo.Margin = new Padding(4, 3, 4, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(215, 202);
            panelLogo.TabIndex = 20;
            // 
            // lblClin
            // 
            lblClin.AutoSize = true;
            lblClin.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClin.ForeColor = SystemColors.ControlLight;
            lblClin.Location = new Point(66, 31);
            lblClin.Margin = new Padding(4, 0, 4, 0);
            lblClin.Name = "lblClin";
            lblClin.Size = new Size(75, 27);
            lblClin.TabIndex = 9;
            lblClin.Text = "CLINIC";
            lblClin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo1;
            pbLogo.Location = new Point(0, 55);
            pbLogo.Margin = new Padding(4, 3, 4, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(215, 147);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lblVet
            // 
            lblVet.AutoSize = true;
            lblVet.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVet.ForeColor = SystemColors.ControlLight;
            lblVet.Location = new Point(28, 0);
            lblVet.Margin = new Padding(4, 0, 4, 0);
            lblVet.Name = "lblVet";
            lblVet.Size = new Size(137, 27);
            lblVet.TabIndex = 0;
            lblVet.Text = "VETERINARY";
            lblVet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veterinary Clinic";
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.LinkLabel linkAdmin;
        private System.Windows.Forms.Label lblQAdmin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblClin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblVet;
    }
}

