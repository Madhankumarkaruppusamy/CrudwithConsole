using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccessLayer
{
    public interface ICricketerRepository
    {
        public void InsertSP(Cricketer details);
        public List<Cricketer> ReadSP();
        public void UpdateSP(long number, Cricketer prd);
        public void DeleteSP(long number);
    }
}
