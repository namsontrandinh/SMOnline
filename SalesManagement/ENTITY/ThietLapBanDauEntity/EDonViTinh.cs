using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManagement.ENTITY.ThietLapBanDauEntity
{
    public class EDonViTinh
    {
        public int MaDVT { get; set; }
        public string DonViTinh { get; set; }

        public EDonViTinh()
        {

        }

        public EDonViTinh(int maDVT, string donViTinh)
        {
            this.MaDVT = maDVT;
            this.DonViTinh = DonViTinh;
        }
    }
}
