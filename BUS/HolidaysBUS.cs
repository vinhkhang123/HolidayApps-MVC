using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class HolidaysBUS 
    {
        Holidayss HO = new Holidayss();
        HolidayDTO HoDTO= new HolidayDTO();
        public DataTable ReadAll()
        {
            return HO.ReadAll();
        }
        public DataTable ReadItem(HolidayDTO HoDTO)
        {
            return HO.ReadItem(HoDTO);
        }
        public bool Create( HolidayDTO HoDTO)
        {
            return HO.Create(HoDTO);
        }
        public bool Update(HolidayDTO HoDTO)
        {
            return HO.Update(HoDTO);
        }
       public bool Delete( HolidayDTO HoDTO)
        {
            return HO.Delete(HoDTO);
        }
       
    }
}
