using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Linq;
using static SINHVIEN.QLSV;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SINHVIEN
{
    public class CSDL
    {

        public List<SV> danhSachSV = new List<SV>();
        public void ThemSV(SV sv)
        {
            danhSachSV.Add(sv);
        }
        public DataTable dt { get; set; }


        // Khởi tạo dữ liệu ban đầu cho CSDL
        public SqlConnection connection;
        public SqlConnection _cnn;
        private SqlCommand command,_cnd;
        string str = "";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public void loaddata()
        {
           command = connection.CreateCommand();
           command.CommandText=str;
            adapter.SelectCommand= command;
            table.Clear();
            adapter.Fill(table);
           /* while (r.Read())
            {
                l.Add(new SV
                {

                    MSSV = r["MSSV"].ToString(),
                    Name = r["Name"].ToString(),
                    DiemTB = Convert.ToDouble(r["DiemTB"].ToString()),
                    GioiTinh = r["GioiTinh"].ToString(),
                    NamSinh = Convert.ToInt32(r["NamSinh"].ToString()),
                    AnhThe = Convert.ToBoolean(r["AnhThe"].ToString()),
                    CMND = Convert.ToBoolean(r["CMND"].ToString()),
                    CCCD = Convert.ToBoolean(r["CCCD"].ToString())
                });
            }
            cnn.Close();*/
            
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, _cnn);
            _cnn.Open();
            da.Fill(dt);
            _cnn.Close();
            return dt;
        }
        public CSDL()
        { 

            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
             new DataColumn{ColumnName = "MSSV", DataType =typeof(string)},
             new DataColumn{ColumnName = "Name", DataType =typeof(string)},
             new DataColumn{ColumnName = "LopSH", DataType =typeof(string)},
             new DataColumn{ColumnName = "Nam Sinh", DataType =typeof(int)},
             new DataColumn{ColumnName = "DiemTB", DataType =typeof(double)},
             new DataColumn{ColumnName = "GioiTinh", DataType =typeof(string)},
             new DataColumn{ColumnName = "Anh The", DataType =typeof(bool)},
             new DataColumn{ColumnName = "CCCD", DataType =typeof(bool)},
             new DataColumn{ColumnName = "CMND", DataType =typeof(bool)}

            });
               
                
               
            
        }



        private static CSDL _Instance;
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;
            }
            private set { }
        }

        public void DeleteSV(string mssv)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dataRow = dt.Rows[i];
                if (mssv.CompareTo(dataRow["MSSV"]) == 0)
                {
                    dataRow.Delete();
                }
            }
            dt.AcceptChanges();
        }
        public void UpdateSV(SV x)
        {
            DeleteSV(x.MSSV);
            AddSV(x);
        }



        // Phương thức lấy danh sách sinh viên
        public List<SV> LayDanhSachSV()
        {
            return danhSachSV;
        }
        public List<SV> GetDSSV()
        {
            List<SV> listsv = new List<SV>();
            foreach (DataRow row in dt.Rows)
            {
                listsv.Add(new SV()
                {
                    MSSV = (string)row["MSSV"],
                    Name = (string)row["Name"],
                    LopSH = (string)row["LopSH"],
                    NamSinh = (int)row["Nam Sinh"],
                    DiemTB = (Double)row["DiemTB"],
                    GioiTinh = (string)row["GioiTinh"],
                    AnhThe = (bool)row["Anh The"],
                    CCCD = (bool)row["CCCD"],
                    CMND = (bool)row["CMND"],

                });
            }
            return listsv;
        }
        public void AddSV(SV t)
        {
            dt.Rows.Add(t.MSSV, t.Name, t.LopSH, t.NamSinh, t.DiemTB, t.GioiTinh, t.AnhThe, t.CCCD, t.CMND);
        }
        public List<SV> TimSV(string x, int temp)
        {
            List<SV> t, ds = new List<SV>();
            t = CSDL.Instance.GetDSSV();
            foreach (SV s in t)
            {   

                if (s.Name.Contains(x) == true || s.Name.Contains(x) == true && temp == 0)
                {
                    ds.Add(s);
                }
                if (s.LopSH.Contains(x) == true || s.LopSH.Contains(x) == true && temp == 1)
                {
                    ds.Add(s);
                }
                if (s.MSSV.Contains(x) == true || s.MSSV.Contains(x) == true && temp == 2)

                    ds.Add(s);
            }

            return ds;
        }
        public List<SV> Sort(List<SV> A, Compare cmp)
        {
            //List<SV> t, ds = new List<SV>();
            A= CSDL.Instance.GetDSSV();
            for (int i = 0; i < A.Count - 1; i++)
            {
                for (int j = i + 1; j < A.Count; j++)
                {
                    if (cmp(A[i], A[j]))
                    {
                        SV tmp = A[i]; A[i] = A[j]; A[j] = tmp;
                    }
                }
            }
            return A;
        }

        public  List<SV> SortByMSSV()
        {
            List<SV> t,ds = new List<SV>();
            t = CSDL.Instance.GetDSSV();
            
           // t.Sort((a, b) => b.MSSV.CompareTo(a.MSSV));
           t.OrderBy(t => t.MSSV).ToList();

            foreach (SV s in t)
            { 
                    ds.Add(s);
            }
            return ds;
        }
        public List<SV> SortByName()
        {
            List<SV> t, ds = new List<SV>();

            t = CSDL.Instance.GetDSSV();
            t.Sort((a, b) => b.Name.CompareTo(a.Name));
            //t.OrderBy(t => t.Name).ToList();

            foreach (SV s in t)
            {
                ds.Add(s);
            }
            return ds;
        }
        public List<SV> SortByLop()
        {
            List<SV> t, ds = new List<SV>();
            t = CSDL.Instance.GetDSSV();
            t.OrderBy(t => t.LopSH).ToList();

            foreach (SV s in t)
            {
                ds.Add(s);
            }
            return ds;
        }
        public List<SV> SortByNamSinh()
        {   

            List<SV> t, ds = new List<SV>();
            t = CSDL.Instance.GetDSSV();
            t.OrderBy(t => t.NamSinh).ToList();

            foreach (SV s in t)
            {
                ds.Add(s);
            }
            return ds;
        }


    }
       
}
    

