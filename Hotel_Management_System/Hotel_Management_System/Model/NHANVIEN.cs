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
    using System.Windows.Media;

    public partial class NHANVIEN : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.HOADONs = new HashSet<HOADON>();
            this.PHIEUNHAPHANGs = new HashSet<PHIEUNHAPHANG>();
        }

        private string _stt;
        public string STT
        {
            get { return _stt; }
            set { _stt = value; OnPropertyChanged(); }
        }

        private string _character;
        public string Character
        {
            get { return _character; }
            set { _character = value; OnPropertyChanged(); }
        }

        private Brush _bgColor;
        public Brush BgColor
        {
            get { return _bgColor; }
            set { _bgColor = value; OnPropertyChanged(); }
        }

        private string _maNhanVien;
        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; OnPropertyChanged(); }
        }

        private string _tenNhanVien;
        public string TenNhanVien
        {
            get { return _tenNhanVien; }
            set { _tenNhanVien = value; OnPropertyChanged(); }
        }

        private string _cccd;
        public string CCCD
        {
            get { return _cccd; }
            set { _cccd = value; OnPropertyChanged(); }
        }

        private string _gioiTinh;
        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; OnPropertyChanged(); }
        }

        private string _soDienThoai;
        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; OnPropertyChanged(); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        private string _boPhan;
        public string BoPhan
        {
            get { return _boPhan; }
            set { _boPhan = value; OnPropertyChanged(); }
        }

        private string _chucVu;
        public string ChucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; OnPropertyChanged(); }
        }

        private string _tinhTrang;
        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; OnPropertyChanged(); }
        }

        private Nullable<System.DateTime> _ngaySinh;
        public Nullable<System.DateTime> NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; OnPropertyChanged(); }
        }

        private string _tenTaiKhoan;
        public string TenTaiKhoan
        {
            get { return _tenTaiKhoan; }
            set { _tenTaiKhoan = value; OnPropertyChanged(); }
        }

        private string _matKhau;
        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; OnPropertyChanged(); }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAPHANG> PHIEUNHAPHANGs { get; set; }
    }
}
