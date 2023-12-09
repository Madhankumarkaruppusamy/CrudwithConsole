using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccessLayer
{
    public class Cricketer
    {
        public long CricketerId { get; set; }
        public string CricketerName { get; set; }
        public long TotalODI  { get; set; }
        public long TotalScore { get; set; }
        public long Fifties{ get; set; }
        public long Hundreds { get; set; }
    }
}
