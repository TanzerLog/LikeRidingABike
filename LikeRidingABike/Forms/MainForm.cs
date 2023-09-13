using LikeRidingABike.Classes;

namespace LikeRidingABike
{
    public partial class MainForm : Form
    {
        private DataAccess dataAccess;

        public MainForm()
        {
            InitializeComponent();

            string connectionString = @"Data Source=C:\Users\User\Documents\SQLiteDBs\tododb.db";
            dataAccess = new DataAccess(connectionString);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (dataAccess != null)
            {
                dataAccess.OpenConnection();
            }
            //load data into the listview
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataAccess.CloseConnection();
        }
    }
}