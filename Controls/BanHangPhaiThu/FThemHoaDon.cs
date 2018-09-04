
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
            cbDMMon.DataSource = listCategory;
            cbDMMon.DisplayMember = "name";
        }

        void LoadFoodListByCategoryId(int id)
        {
            List<Food> listFood = GetFoodByCategoryId(id);
            cbMon.DataSource = listFood;
            cbMon.DisplayMember = "name";
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

            string query = "EXEC dbo.ESP_DMMON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
            
        }
        public List<Food> GetFoodByCategoryId(int id)
        {
            List<Food> list = new List<Food>();

            string query = "EXEC dbo.ESP_MON @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object []{ id});
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public class Food
        {
            public Food(int id, string name, int idCategory)
            {
                this.Id = id;
                this.Name = name;
                this.IdCategory = idCategory;
                //this.Price = price;
            }

            public Food(DataRow row)
            {
                this.Id = (int)row["id"];
                this.Name = row["Ten_Vt"].ToString();
                this.IdCategory = (int)row["DMMon_id"];
                //this.Price = Convert.ToInt32(row["price"]);
            }

            private int id;
            private string name;
            private int idCategory;
            //private float price;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
            public int IdCategory { get => idCategory; set => idCategory = value; }
            //public float Price { get => price; set => price = value; }
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
                        btn.BackColor = Color.Aquamarine;
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

        public class ThucDon
        {
            public ThucDon(string tenMon, int soLuong, float donGia,float giamGia, float totalPrice = 0)
            {
                this.Count = soLuong;
                this.FoodName = tenMon;
                this.GiamGia = giamGia;
                this.Price = donGia;
                this.TotalPrice = totalPrice;
            }

            public ThucDon(DataRow row)
            {
                this.FoodName = row["Ten_Vt"].ToString();
                this.Count = (int)row["So_Luong"];
                this.Price = Convert.ToInt32(row["Thanh_Tien_GB"]);
                this.GiamGia = Convert.ToInt32(row["Tien_Giam_Gia"]);
                this.TotalPrice = Convert.ToInt32(row["TT"]);
            }

            private string foodName;
            private int count;
            private float price;
            private float totalPrice;
            private float giamGia;
            public string FoodName { get => foodName; set => foodName = value; }
            public int Count { get => count; set => count = value; }
            public float Price { get => price; set => price = value; }
            public float TotalPrice { get => totalPrice; set => totalPrice = value; }
            public float GiamGia { get => giamGia; set => giamGia = value; }
        }

        public List<ThucDon> GetListMonByTable(int id)
        {
            string query = "SELECT vt.Ten_Vt,ct.So_Luong,ct.Thanh_Tien_GB,ct.Tien_Giam_Gia,ct.So_Luong*ct.Thanh_Tien_GB AS TT " +
                "FROM dbo.E02CTHD AS ct,dbo.E00DMVT AS vt,dbo.E02HOADON AS hd " +
                "WHERE ct.Ma_Vt = vt.Ma_Vt AND ct.Ma_HD = hd.Ma_HD AND hd.status = 0 and hd.Ma_Ban = " + id;

            List<ThucDon> listMon = new List<ThucDon>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThucDon mon = new ThucDon(item);
                listMon.Add(mon);
            }

            return listMon;
        }

        void ShowBill(int id)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            lsvBill.Items.Clear();

            List<ThucDon> listBillInfo = GetListMonByTable(id);
            float totalPrice = 0;

            foreach (ThucDon item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }



            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);

        }

        #region Table
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvBill.Tag = (sender as Button).Tag;

            ShowBill(tableID);
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

        private void cbDMMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }

            Category selected = cb.SelectedItem as Category;
            id = selected.Id;

            LoadFoodListByCategoryId(id);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = GetUncheckByTableId(table.Id);

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + table.Name + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    ThanhToan(idBill);
                    ShowBill(table.Id);

                    LoadTable();
                }
            }
        }
        public void ThanhToan(int id)
        {
            string query = "UPDATE dbo.E02HOADON SET Status=1 WHERE Stt=" + id;
            Table table = lsvBill.Tag as Table;
            DataProvider.Instance.ExecuteNoneQuery(query);
            DataProvider.Instance.ExecuteNoneQuery("UPDATE dbo.E00DMBAN SET status=N'Trống' WHERE id=" + table.Id);
            
        }
        public int GetUncheckByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.E02HOADON WHERE Ma_Ban = " + id + " AND status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }

        public class Bill
        {
            public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
            {
                this.Id = id;
                this.DateCheckIn = dateCheckIn;
                this.DateCheckOut = dateCheckIn;
                this.Status = status;
            }

            public Bill(DataRow row)
            {
                this.Id = (int)row["stt"];
                this.DateCheckIn = (DateTime)row["Ngay_HD"];

                var dataCheckOutTemp = row["Ngay_TT"];
                if (dataCheckOutTemp.ToString() != "")
                {
                    this.DateCheckOut = (DateTime)dataCheckOutTemp;
                }

                this.Status = (int)row["status"];
            }

            private int id;
            private DateTime? dateCheckIn;
            private DateTime? dateCheckOut;
            private int status;

            public int Id { get => id; set => id = value; }
            public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
            public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
            public int Status { get => status; set => status = value; }
        }
        public void InsertBillInfo(int idBill, int idfood, int count)
        {
            DataProvider.Instance.ExecuteNoneQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idfood, count });
        }
        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteNoneQuery("SELECT MAX(id) FROM dbo.Bill");
            }
            catch (Exception)
            {

                return 1;
            }
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNoneQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            //Table table = lsvBill.Tag as Table;
            //int idBill = GetUncheckByTableId(table.Id);
            //int foodId = (cbMon.SelectedItem as Food).Id;
            //int count = (int)soluongNUD.Value;
            //if (idBill == -1)
            //{
            //    InsertBill(table.Id);
            //    InsertBillInfo(GetMaxIdBill(), foodId, count);
            //}
            //else
            //{
            //    InsertBillInfo(idBill, foodId, count);
            //}

            //ShowBill(table.Id);
            //LoadTable();

            string[] row = { cbMon.Text, soluongNUD.Value.ToString(), "90000", (90000 * soluongNUD.Value).ToString(), "" };
            ListViewItem newitem = new ListViewItem(row);
            lsvBill.Items.Add(newitem);

        }
    }
}
