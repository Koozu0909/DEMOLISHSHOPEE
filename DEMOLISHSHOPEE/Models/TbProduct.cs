﻿namespace DEMOLISHSHOPEE.Models
{
    public partial class TbProduct
    {
        public int MaSp { get; set; }
        public string? TenSp { get; set; }
        public string? SeoName { get; set; }
        public int? MaLoaiSp { get; set; }
        public int? MaThuongHieu { get; set; }
        public int? MaLoaiBaoHanh { get; set; }
        public int? MaHanBaoHanh { get; set; }
        public int? MaXuatXu { get; set; }
        public double? TotalRate { get; set; }
        public decimal? GiaSp { get; set; }
        public DateTime? CreateDay { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? UpdateDay { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? DeleteDay { get; set; }
        public int? DeleteBy { get; set; }
    }
}