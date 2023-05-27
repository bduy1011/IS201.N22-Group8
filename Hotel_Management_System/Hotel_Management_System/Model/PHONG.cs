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
    using Hotel_Management_System.ViewModel;
    using Hotel_Management_System.ViewModel.Other;
    using System;
    using System.Collections.Generic;

    public partial class PHONG : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            this.PHIEUDATPHONGs = new HashSet<PHIEUDATPHONG>();
        }

        public PHONG(string maPhong, string maLoaiPhong, string trangThai, string ghiChu, LOAIPHONG lOAIPHONG, ICollection<PHIEUDATPHONG> pHIEUDATPHONGs)
        {
            _maPhong = maPhong;
            _maLoaiPhong = maLoaiPhong;
            _trangThai = trangThai;
            _ghiChu = ghiChu;
            LOAIPHONG = lOAIPHONG;
            PHIEUDATPHONGs = pHIEUDATPHONGs;
        }

        private string _maPhong { get; set; }
        private string _maLoaiPhong { get; set; }
        private string _trangThai { get; set; }
        private string _ghiChu { get; set; }
        private string _stateColor { get; set; }

        public string MaPhong { get => _maPhong; set { _maPhong = value; OnPropertyChanged(); } }
        public string MaLoaiPhong { get => _maLoaiPhong; set { _maLoaiPhong = value; OnPropertyChanged(); } }
        public string TrangThai { get => _trangThai; set { _trangThai = value; OnPropertyChanged(); } }
        public string GhiChu { get => _ghiChu; set { _ghiChu = value; OnPropertyChanged(); } }
        public string StateColor { get => _stateColor; set { _stateColor = value; OnPropertyChanged(); } }

        public virtual LOAIPHONG LOAIPHONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }
    }
}
