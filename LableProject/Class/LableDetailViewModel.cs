using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LableProject.Class
{
    public class LableDetailViewModel
    {
        public int Lable_Id { get; set; }
        public string LD_Name { get; set; }
        public bool LD_Barcode { get; set; }
        public bool LD_PrintTitle { get; set; }
        public bool LD_Scan { get; set; }
        public int LD_Excell { get; set; }
    }
}
