using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ketoan.Controls.Danhmuc.Dmnv
{
    public partial class HienThiDMNV : UserControl
    {
        public HienThiDMNV()
        {
            InitializeComponent();
            ExecuteStore();
        }
        SqlDataReader rdr = null;
        //        public delegate SqlDataReader callDMNV();
        SqlConnection conn = null;

        private void ExecuteStore()
        {
            Ketnoi.Ketnoi kn = new Ketnoi.Ketnoi();
            //callDMNV callAll = new callDMNV(kn.showDMNV);
            var dataTable = new DataTable();
            rdr = kn.showDMNV();
                //callAll();
            dataTable.Load(rdr);
            gridControl1.DataSource = dataTable;
            //while (rdr.Read())
            //{
            //    kq.Add(new kqmoi(double.Parse(rdr["nlml2"].ToString()), double.Parse(rdr["kltpmoi"].ToString()), double.Parse(rdr["klnguyenlieumoi"].ToString()), double.Parse(rdr["klthanhphammoi"].ToString()), rdr["mavattu"].ToString(), rdr["mathanhpham"].ToString()));
            //}

        }
    
    }
}
