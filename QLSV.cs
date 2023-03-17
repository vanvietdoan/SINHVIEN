using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SINHVIEN
{
    public class QLSV
    {
        
        private List<SV> danhSachSV;

        public QLSV()
        {
            danhSachSV = new List<SV>();
        }
        public delegate bool Compare(object o1, object o2);
        public bool CompareMSSV(object o1, object o2)
        {
            if (((SV)o1).MSSV.CompareTo(((SV)o2).MSSV) > 0) 
                return true;
            else 
                return false;
        }
        public bool CompareName(object o1, object o2)
        {
            if (((SV)o1).Name.CompareTo(((SV)o2).Name) > 0) return true;
            else return false;
        }
        public bool CompareLopSH(object o1, object o2)
        {
            if (((SV)o1).LopSH.CompareTo(((SV)o2).LopSH) > 0) return true;
            else return false;
        }
        public bool CompareNamSinh(object o1, object o2)
        {
            if (((SV)o1).NamSinh.CompareTo(((SV)o2).NamSinh) > 0) return true;
            else return false;
        }
        private static QLSV _Instance;
        public static QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLSV();
                }
                return _Instance;
            }
            private set { }
        }

        public void ThemSV(SV sv)
        {
            danhSachSV.Add(sv);
        }
        public bool TimMSSV(string x)
        {
            List<SV> t, ds = new List<SV>();
            t = CSDL.Instance.GetDSSV();
            foreach (SV s in t)
            {
                if (s.MSSV.CompareTo(x) == 0)
                {
                    return true;
                }
            }
            return false;
        }


        public void SuaSV(SV sv)
        {
            
            int index = danhSachSV.FindIndex(x => x.MSSV == sv.MSSV);

            if (index != -1)
            {
               
                danhSachSV[index] = sv;
            }
            
        }

       
        public void XoaSV(string mssv)
        {
            
            int index = danhSachSV.FindIndex(x => x.MSSV == mssv);

            if (index != -1)
            {
                
                danhSachSV.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên cần xóa trong danh sách.");
            }
        }

      
        public List<SV> LayDanhSachSV()
        {
            return danhSachSV;
        }
        
    }
}

