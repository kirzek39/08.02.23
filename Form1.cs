using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getInfo();
        }

        private void getInfo()
        {
            string query = (" select items.id_items as '№', items.item_name as 'Название', category.cat_name as'Категория', warehouse.warehouse_adress as 'Адрес склада' from items join category on items.item_cat  = category.id_cat join warehouse on items.item_warehose = warehouse.id_warehouse;");
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }











        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string query = (" select items.id_items, items.item_name, category.cat_name, warehouse.warehouse_adress from items join category on items.item_cat  = category.id_cat join warehouse on items.item_warehose = warehouse.id_warehouse order by item_name ");
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string query = (" select items.id_items, items.item_name, category.cat_name, warehouse.warehouse_adress from items join category on items.item_cat  = category.id_cat join warehouse on items.item_warehose = warehouse.id_warehouse order by item_name desc ");
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string query = (" select items.id_items, items.item_name, category.cat_name, warehouse.warehouse_adress from items join category on items.item_cat  = category.id_cat join warehouse on items.item_warehose = warehouse.id_warehouse where item_name like '%" + textBox1.Text + "%' ");
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Win = new Form2();
            Win.Show();
        }
    }
}
