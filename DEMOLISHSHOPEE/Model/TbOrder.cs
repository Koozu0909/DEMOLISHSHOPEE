﻿using System;
using System.Collections.Generic;

namespace DEMOLISHSHOPEE.Model
{
    public partial class TbOrder
    {
        public int MaDonHang { get; set; }
        public int? MaUser { get; set; }
        public int? MaPayment { get; set; }
        public int? MaTrangThai { get; set; }
        public string? CreateDay { get; set; }
    }
}
