namespace VeterinaryClinicApp
{
    public partial class mainform : Form
    {
        public string LoggedInAdminFullname { get; set; }
        public string LoggedInAdminEmail { get; set; }
        public adminformuc adminForm;
        public mainform()
        {
            InitializeComponent();
            
            
        }
        public Panel MainPanelContent
        {
            get { return panelContent; }
        } 
        public void ShowAdminDashboard(string fullname, string email, string rfid)
        {
            admindashuc adminDashboard = new admindashuc(fullname, email, rfid);
            panelContent.Controls.Clear();
            adminDashboard.Dock = DockStyle.Fill;
            panelContent.Controls.Add(adminDashboard);
        }
        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelContent.Controls.Clear();
            adminformuc adminForm = new adminformuc(this);
            panelContent.Controls.Add(adminForm);
            adminForm.Show();
        }
    }
}
