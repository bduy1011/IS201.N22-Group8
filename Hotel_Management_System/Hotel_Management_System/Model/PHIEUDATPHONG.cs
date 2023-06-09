//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Management_System.Model
{
    using Hotel_Management_System.ViewModel.Other;
    using System;
    using System.Collections.Generic;

    public partial class PHIEUDATPHONG : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDATPHONG()
        {
            this.CT_HOADON = new HashSet<CT_HOADON>();
            this.KHACHHANGs = new HashSet<KHACHHANG>();
        }

        private int _stt;
        public int STT
        {
            get { return _stt; }
            set { _stt = value; OnPropertyChanged(); }
        }

        private string _maPhieuDatPhong;
        public string MaPhieuDatPhong
        {
            get { return _maPhieuDatPhong; }
            set { _maPhieuDatPhong = value; OnPropertyChanged(); }
        }

        private string _maPhieuSuDung;
        public string MaPhieuSuDung
        {
            get { return _maPhieuSuDung; }
            set { _maPhieuSuDung = value; OnPropertyChanged(); }
        }

        private string _maPhong;
        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; OnPropertyChanged(); }
        }

        private short? _soNguoi;
        public short? SoNguoi
        {
            get { return _soNguoi; }
            set { _soNguoi = value; OnPropertyChanged(); }
        }

        private DateTime? _ngayDen;
        public DateTime? NgayDen
        {
            get { return _ngayDen; }
            set { _ngayDen = value; OnPropertyChanged(); }
        }

        private DateTime? _ngayDi;
        public DateTime? NgayDi
        {
            get { return _ngayDi; }
            set { _ngayDi = value; OnPropertyChanged(); }
        }

        private int? _donGia;
        public int? DonGia
        {
            get { return _donGia; }
            set { _donGia = value; OnPropertyChanged(); }
        }

        private int? _tienCoc;
        public int? TienCoc
        {
            get { return _tienCoc; }
            set { _tienCoc = value; OnPropertyChanged(); }
        }

        private DateTime? _ngayLap;
        public DateTime? NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; OnPropertyChanged(); }
        }

        private string _trangThai;
        public string TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; OnPropertyChanged(); }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }
        public virtual PHONG PHONG { get; set; }
        public virtual PHIEUSUDUNG PHIEUSUDUNG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
    }
}
