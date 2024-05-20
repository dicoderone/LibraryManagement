using Npgsql;
using System.Data;

namespace LibraryManagment
{
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=loginTabel;User Id=postgres;Password=hayraton2023");
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select Id, std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name," +
                "book_issue_date,NULL AS book_return_date from IRBook";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            cmd.CommandText = "select * from IRBook";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];

        }
    }
}
