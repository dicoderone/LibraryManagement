using Npgsql;
using System.Data;

namespace LibraryManagment
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from NewBook";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        int id;
        Int64 RowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from NewBook where id = " + id + "";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            RowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtBName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthorName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPubliaction.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPDate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtBookPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtBookQuantity.Text = ds.Tables[0].Rows[0][6].ToString();


        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text != "")
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewBook where bName Like '" + txtBookName.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewBook";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bname = txtBookName.Text;
                String bauthor = txtAuthorName.Text;
                String publiaction = txtPubliaction.Text;
                String pdate = txtPDate.Text;
                Int64 price = Int64.Parse(txtBookPrice.Text);
                Int64 quan = Int64.Parse(txtBookQuantity.Text);

                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "update NewBook set bName = '" + bname + "',bAuthor = '" + bauthor + "',bPubl = '" + publiaction + "',bPDate ='" + pdate + "',bPrice =" + price + ",bQuan =" + quan + " where id=" + RowId + "";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Deleted. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "delete from NewBook where id=" + RowId + "";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

    }
}
