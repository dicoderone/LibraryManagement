using Npgsql;
using System.Data;

namespace LibraryManagment
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new NpgsqlCommand("select bName from NewBook", conn);
            NpgsqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(Sdr.GetString(i)); ;
                }
            }
            Sdr.Close();
            conn.Close();
        }
        int count;
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {

            if (txtEnrollement.Text != "")
            {
                String eid = txtEnrollement.Text;
                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewStudent where enroll = '" + eid + "'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmd.CommandText = "select count(std_enroll) from IRBook where std_enroll = '" + eid + "' and book_return_date is null";
                NpgsqlDataAdapter DA1 = new NpgsqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                DA1.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSemestr.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmal.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDepartment.Clear();
                    txtSemestr.Clear();
                    txtContact.Clear();
                    txtEmal.Clear();
                    MessageBox.Show("Invalid Enrollement No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (comboBoxBooks.SelectedIndex != -1 && count <= 2)
                {
                    MessageBox.Show("Hello i am in");
                }
            }
        }
    }
}
