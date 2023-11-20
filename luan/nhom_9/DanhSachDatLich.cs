using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace nhom_9
{
    [Serializable]
    internal class DanhSachDatLich
    {
        private List<DatLich> _danhSachDatLich;
        
        public DanhSachDatLich()
        {
            _danhSachDatLich = new List<DatLich>();
        }
        public List<DatLich> danhSachDatLich
        {
            get { return this._danhSachDatLich.ToList(); }
            set { this._danhSachDatLich = value; }
        }
        public void AddDanhSachDatLich(DatLich dsdt)
        {
            dsdt.id = tao_ID(dsdt);
            this._danhSachDatLich.Add(dsdt);
        }
        public int tao_ID(DatLich datlich)
        {
            int id = 1;
            foreach (DatLich d in this._danhSachDatLich)
                id++;
            return id;
        }
        public bool timTG(DatLich dl)
        {
            foreach (DatLich d in this._danhSachDatLich)
            {
                if (d.thoigian.Equals(dl.thoigian))
                {
                    return true;
                }
            }
            return false;
        }
        public DatLich TimTheoID(int id)
        {
            return _danhSachDatLich.FirstOrDefault(d => d.id == id);
        }
        public void SuaDanhSachDatLich(int id, DatLich datLichMoi)
        {
           
            DatLich datLichCanSua = _danhSachDatLich.FirstOrDefault(d => d.id == id);

            if (datLichCanSua != null)
            {
                
                datLichCanSua.tieude = datLichMoi.tieude;
                datLichCanSua.noidung = datLichMoi.noidung;
                datLichCanSua.thoigian = datLichMoi.thoigian;
                datLichCanSua.trangthai = datLichMoi.trangthai;
            }
            int index = _danhSachDatLich.FindIndex(d => d.id == id);

            if (index != -1)
            {

                _danhSachDatLich[index] = datLichMoi;
            }
        }

        public void XoaDanhSachDatLich(int id)
        {
            
            DatLich datLichCanXoa = _danhSachDatLich.FirstOrDefault(d => d.id == id);

            if (datLichCanXoa != null)
            {
            
                _danhSachDatLich.Remove(datLichCanXoa);
                UpdateIDs();
            }
        }
        public void UpdateIDs()
        {
            for (int i = 0; i < _danhSachDatLich.Count; i++)
            {
                _danhSachDatLich[i].id = i + 1;
            }
        }
    }
    }


