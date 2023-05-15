namespace DEMOLISHSHOPEE.Models
{
    public partial class TbUser
    {
        public int MaUser { get; set; }
        public string? HoTen { get; set; }
        public string? Ten { get; set; }
        public string? Gmail { get; set; }
        public string? Sdt { get; set; }
        public string? UserName { get; set; }
        public string? PassWord { get; set; }
        public int? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public byte[]? Avatar { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}