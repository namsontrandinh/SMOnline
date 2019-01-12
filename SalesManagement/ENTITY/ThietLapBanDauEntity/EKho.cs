using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManagement.ENTITY.ThietLapBanDauEntity
{
   public class EKho
    {
        public int MaKho { get; set; }
        public string Kho { get; set; }
        public EKho() { }
        public EKho(int MaKho, string Kho) 
        {
            this.Kho = Kho;
            this.MaKho = MaKho;
        }
    }
}
