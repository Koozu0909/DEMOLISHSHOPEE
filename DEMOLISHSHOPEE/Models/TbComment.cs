using System;
using System.Collections.Generic;

namespace DEMOLISHSHOPEE.Models
{
    public partial class TbComment
    {
        public int MaComment { get; set; }
        public int? MaUser { get; set; }
        public int? MaSp { get; set; }
        public int? Rate { get; set; }
        public int? Idreply { get; set; }
        public string? NoiDung { get; set; }
        public DateTime? CreateDay { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? UpdateDay { get; set; }
        public int? UpdateBy { get; set; }
    }
}
