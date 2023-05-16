namespace DEMOLISHSHOPEE.Alias
{
    public class CategoriesImage
    {
        public int? Parent { get; set; }
        public int? Role { get; set; }
        public string? TenLoaiSp { get; set; }
        public int MaLoaiSp { get; set; }

        public IFormFile Image { get; set; }
    }
}
