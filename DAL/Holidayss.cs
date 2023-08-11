using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Collections;

namespace DAL
{
    public class Holidayss 
    {
        DBAccess objDBAccess = new DBAccess();
        private static string _table = "holidays";
        private static string _files = "ID, holiday_date, holiday_name_group, holiday_name_en, holiday_name_vi, remark, updated_by, updated_date";
        private static string _filesd = "holiday_date, holiday_name_group, holiday_name_en, holiday_name_vi, remark";
        DataTable dtWS = new DataTable();

        public DataTable ReadAll(string col = null)
        {
          
            string query = "SELECT " + _files + " FROM " + _table + ";";
            if (col != null)
            {
                query = "SELECT " + _files + " FROM " + _table + " ORDER BY  " + col + "  ASC;";
            }
            return objDBAccess.ExecuteDataTable(query);
        }
        public DataTable ReadItem(HolidayDTO Item)
        {
            string query = "SELECT " + _files + " FROM " + _table + " WHERE holiday_date = '" + Item.Holiday_date + "';";
            return objDBAccess.ExecuteDataTable(query);
        }
        public bool Create (HolidayDTO Item)
        {   
            string query = "INSERT INTO "+_table+"("+_filesd+ ")VALUES ('{0}',N'{1}',N'{2}',N'{3}',N'{4}')";
            string Query = string.Format(query, (Item.Holiday_date).ToString().Replace("\'", "\\\'"), (Item.Holiday_name_group).ToString().Replace("\'", "\\\'"), (Item.Holiday_name_en).ToString().Replace("\'", "\\\'"),
                (Item.Holiday_name_vi).ToString().Replace("\'", "\\\'"), (Item.Remark).ToString().Replace("\'", "\\\'"));
            return (objDBAccess.ExecuteNonQuery(Query) > 0) ? true : false;
         
           
        }
        public bool Update(HolidayDTO Item)
        {

                
            string query = "UPDATE " + _table + " SET holiday_name_group=N'{1}', holiday_name_en=N'{2}', holiday_name_vi=N'{3}', remark=N'{4}'" +
                " WHERE ID='{0}' ";
            string Query = string.Format(query,
               (Item.Id1),
               
                (Item.Holiday_name_group).ToString().Replace("\'", "\\\'"),
                (Item.Holiday_name_en).ToString().Replace("\'", "\\\'"),
                (Item.Holiday_name_vi).ToString().Replace("\'", "\\\'"),
                (Item.Remark).ToString().Replace("\'", "\\\'")
               
            );

            return (objDBAccess.ExecuteNonQuery(Query) > 0) ? true : false;
        }
        public bool Delete(HolidayDTO Item)
        {
            


            string query = "DELETE FROM " + _table + " WHERE Id ='{0}'   ";
            string Query = string.Format(query, Item.Id1);

            return (objDBAccess.ExecuteNonQuery(Query) > 0) ? true : false;
           

        }




    }
}
