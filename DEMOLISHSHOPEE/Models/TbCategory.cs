namespace DEMOLISHSHOPEE.Models
{
    public partial class TbCategory
    {
        public int MaLoaiSp { get; set; }
        public int? Parent { get; set; }
        public int? Role { get; set; }
        public string? ImagePath { get; set; }
        public string? TenLoaiSp { get; set; }
    }
}