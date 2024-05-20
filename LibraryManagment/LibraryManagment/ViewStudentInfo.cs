using Npgsql;
using System.Data;

namespace LibraryManagment
{
    public partial class ViewStudentInfo : Form
    {
        public ViewStudentInfo()
        {
            InitializeComponent();
        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnrollment.Text != "")
            {
                panel2.Visible = false;

                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewStudent where enroll LIKE '" + txtSearchEnrollment.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void ViewStudentInfo_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from NewStudent";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int bId;
        Int64 RowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            panel2.Visible = true;

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from NewStudent where id = " + bId + "";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }


    }
}
