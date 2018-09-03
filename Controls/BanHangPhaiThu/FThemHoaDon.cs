
using KeToan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class FThemHoaDon : Form
    {
        public FThemHoaDon()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        void LoadCategory()
        {
            List<Category> listCategory = GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "name";
        }

        void LoadFoodListByCategoryId(int id)
        {
            List<Food> listFood = GetFoodByCategoryId(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "name";
        }

        public class Category
        {
            public Category(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

            public Category(DataRow row)
            {
                this.Id = (int)row["id"];
                this.Name = row["name"].ToString();
            }

            private int id;
            private string name;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
        }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            //string query = "SELECT *FROM dbo.FoodCategory";
            //DataTable data = DataProvider.Instance.ExecuteQuery(query);

            //foreach (DataRow item in data.Rows)
            //{
            //    Category category = new Category(item);
            //    list.Add(category);
            //}

            return list;
        }
        public List<Food> GetFoodByCategoryId(int id)
        {
            List<Food> list = new List<Food>();

            //string query = "SELECT * FROM dbo.Food WHERE idCategory= " + id;
            //DataTable data = DataProvider.Instance.ExecuteQuery(query);
            //foreach (DataRow item in data.Rows)
            //{
            //    Food food = new Food(item);
            //    list.Add(food);
            //}

            return list;
        }
        public class Food
        {
            public Food(int id, string name, int idCategory, float price)
            {
                this.Id = id;
                this.Name = name;
                this.IdCategory = idCategory;
                this.Price = price;
            }

            public Food(DataRow row)
            {
                this.Id = (int)row["id"];
                this.Name = row["name"].ToString();
                this.IdCategory = (int)row["idCategory"];
                this.Price = Convert.ToInt32(row["price"]);
            }

            private int id;
            private string name;
            private int idCategory;
            private float price;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
            public int IdCategory { get => idCategory; set => idCategory = value; }
            public float Price { get => price; set => price = value; }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            EDCChiTietNghiepVu u1 = new EDCChiTietNghiepVu();
            u1.Dock = DockStyle.Fill;
            panel3.Controls.Add(u1);
        }
        void LoadTable()
        {
            flpTab.Controls.Clear();

            List<Table> tabbleList = TableDao.Instance.LoadTableList();

            foreach (Table item in tabbleList)
            {
                Button btn = new Button()
                {
                    Height = TableDao.TableHeight,
                    Width = TableDao.TableWidth
                };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.AliceBlue;
                        break;
                    default:
                        btn.BackColor = Color.BlueViolet;
                        break;
                }
                flpTab.Controls.Add(btn);
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            EDCChiTietNghiepVu u1 = new EDCChiTietNghiepVu();
            u1.Dock = DockStyle.Fill;
            panel4.Controls.Add(u1);
        }

        
        #region Table
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvBill.Tag = (sender as Button).Tag;

            //ShowBill(tableID);
        }
        private class Table
        {
            public Table(int id, string name, string status)
            {
                this.Id = id;
                this.Name = name;
                this.Status = status;
            }

            public Table(DataRow row)
            {
                this.Id = (int)row["id"];
                this.Name = row["name"].ToString();
                this.Status = row["status"].ToString();
            }

            private int id;
            private string name;
            private string status;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
            public string Status { get => status; set => status = value; }
        }

        private class TableDao
        {
            
            private static TableDao instance;

            public static TableDao Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new TableDao();
                    };
                    return TableDao.instance;
                }
                private set => instance = value;
            }

            private TableDao()
            {

            }

            public static int TableWidth = 100;
            public static int TableHeight = 70;

            public List<Table> LoadTableList()
            {
                List<Table> tableList = new List<Table>();
                DataTable data = DataProvider.Instance.ExecuteQuery("USP_DMBAN");
                foreach (DataRow item in data.Rows)
                {
                    Table table = new Table(item);
                    tableList.Add(table);
                }
                return tableList;
            }
        }
        #endregion
    }
}
