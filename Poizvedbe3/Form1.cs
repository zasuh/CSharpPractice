using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Poizvedbe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.northwindDataSet.DataTable1);
            //ustvarimo novo, povsem dinamično poizvedbo za polnjenje ComboBoxov

            //deluje, če imamo zgoraj using System.Data.SqlClient;

            //naredimo nov SqlConnection in nastavimo ConnectionString

            SqlConnection mySqlConnection = new SqlConnection();

            mySqlConnection.ConnectionString = Properties.Settings.Default.NorthwindConnectionString;

            //naredimo nov Sql ukaz in ga nastavimo na željeno poizvedbo

            SqlCommand mySQLCommand = mySqlConnection.CreateCommand();

            mySQLCommand.CommandText = "SELECT CategoryName FROM Categories";

            //naredimo nov DataAdapter (podobno TableAdapterju, ki ga dinamično ne moremo kreirati) in mu nastavimo poizvedbo,

            //ki se uporabi pri metodi Fill

            SqlDataAdapter myDataAdapter = new SqlDataAdapter();

            myDataAdapter.SelectCommand = mySQLCommand;

            //ustvarimo novo tabelo, ki bo dobila podatke od DataAdapterja

            DataTable myDataTable = new DataTable();

            try

            {

                //odpremo povezavo z bazo

                mySqlConnection.Open();

                //napolnimo tabelo

                myDataAdapter.Fill(myDataTable);

                //zapremo povezavo

                mySqlConnection.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Napaka pri povezavi z bazo: " + ex.Message, "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            //napolnimo categoryNameCmb

            categoryNameCmb.Items.Add("-- all --");

            for (int i = 0; i < myDataTable.Rows.Count; i++)

            {

                categoryNameCmb.Items.Add(myDataTable.Rows[i]["CategoryName"]);

            }

            //napolnimo supplierNameCmb

            //izvedli bomo drug SQL stavek

            myDataAdapter.SelectCommand.CommandText = "SELECT CompanyName FROM Suppliers";

            try

            {

                //spet odpremo povezavo z bazo

                mySqlConnection.Open();

                //počistimo vse iz tabele

                myDataTable.Clear();

                //napolnimo tabelo

                myDataAdapter.Fill(myDataTable);

                //spet zapremo povezavo z bazo

                mySqlConnection.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Napaka pri povezavi z bazo: " + ex.Message, "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            //napolnimo supplierNameCmb

            supplierNameCmb.Items.Clear();

            supplierNameCmb.Items.Add("-- all --");

            for (int i = 0; i < myDataTable.Rows.Count; i++)

            {

                supplierNameCmb.Items.Add(myDataTable.Rows[i]["CompanyName"]);

            }

            //naložimo podatke o vseh izdelkih

            try

            {

                this.productsTableAdapter.Fill(this.northwindDataSet.Products);

                SQL = productsTableAdapter.Adapter.SelectCommand.CommandText;

                SQLTxt.Text = SQL;

            }

            catch (Exception ex)

            {

                MessageBox.Show("Napaka pri povezavi z bazo: " + ex.Message, "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            //nastavimo oba comboboxa na vrednost – all --

            categoryNameCmb.SelectedIndex = 0;

            supplierNameCmb.SelectedIndex = 0;
        }
    }
}
