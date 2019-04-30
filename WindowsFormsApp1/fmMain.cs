using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }


        /*
        private void LoadData()
        {
            string connectString = @"Data Source=.\\DESKTOP-4QOMJFL\SQLEXPRESS; Initial Catalog=DataWorkTest; Integrated Security=true;";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM DivisionSet";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }

    */










        private void btAddDivision_Click(object sender, EventArgs e)
        {
            AddDivision fmAddDivision = new AddDivision();
            fmAddDivision.ShowDialog();

            using (Model1Container db = new Model1Container())
            {
                // создаем два объекта User
                Division div1 = new Division { Subdivision = fmAddDivision.GetResult() };
                

                // добавляем их в бд
                db.DivisionSet.Add(div1);
                
                db.SaveChanges();

            }


            label1.Text = fmAddDivision.GetResult();

        }

        private void btChangeDivision_Click(object sender, EventArgs e)
        {
            ChangeDivision fmChangeDivision = new ChangeDivision();
            fmChangeDivision.ShowDialog();
        }

        private void btRemoveDivision_Click(object sender, EventArgs e)
        {
            RemoveDivision fmRemoveDivision = new RemoveDivision();
            fmRemoveDivision.ShowDialog();
        }

        private void btAddWorker_Click(object sender, EventArgs e)
        {
            AddWorker fmAddWorker = new AddWorker();
            fmAddWorker.ShowDialog();
        }

        private void btChangeWorker_Click(object sender, EventArgs e)
        {
            ChangeWorker fmChangeWorker = new ChangeWorker();
            fmChangeWorker.ShowDialog();
        }

        private void btRemoveWorker_Click(object sender, EventArgs e)
        {
            RemoveWorker fmRemoveWorker = new RemoveWorker();
            fmRemoveWorker.ShowDialog();
        }

        private void divisionSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.divisionSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataWorkTestDataSet);

        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataWorkTestDataSet.WorkerSet' table. You can move, or remove it, as needed.
            this.workerSetTableAdapter.Fill(this.dataWorkTestDataSet.WorkerSet);
            // TODO: This line of code loads data into the 'dataWorkTestDataSet.DivisionSet' table. You can move, or remove it, as needed.
            this.divisionSetTableAdapter.Fill(this.dataWorkTestDataSet.DivisionSet);

        }
    }
}
