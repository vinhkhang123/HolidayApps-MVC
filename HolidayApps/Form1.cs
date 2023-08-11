using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace HolidayApps
{
    public partial class Form1 : Form
    {
        HolidaysBUS HoBUS= new HolidaysBUS();
        HolidayDTO  HolidayDTO= new HolidayDTO();
        private int indexRow;
      
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = HoBUS.ReadAll();

        }
        private void ClearTextBoxes()
        {
            txt_id.Text = "";
            dateTimePicker1.Text = "";
            txt_name_group.Text = "";
            txt_name_en.Text = "";
            txt_name_vi.Text = "";
            txt_remark.Text = "";
            txt_updated_by.Text = "";
            txt_updated_date.Text = "";
        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dateTimePicker1.Text);
            string holidayDateString = date.ToString("yyyy-MM-dd");

            HolidayDTO.Holiday_date = holidayDateString;
          
            dataGridView1.DataSource = HoBUS.ReadItem(HolidayDTO);
           
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {


            // Set the date format.
            
            DateTime date = DateTime.Parse(dateTimePicker1.Text);
            string holidayDateString = date.ToString("yyyy-MM-dd");
           
            HolidayDTO.Holiday_date = holidayDateString;
            HolidayDTO.Holiday_name_group= txt_name_group.Text;
            HolidayDTO.Holiday_name_en= txt_name_en.Text;
            HolidayDTO.Holiday_name_vi= txt_name_vi.Text;
            HolidayDTO.Remark = txt_remark.Text;
            if(txt_name_group.TextLength == 0||txt_name_en.TextLength == 0|| txt_name_vi.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                dataGridView1.DataSource = HoBUS.ReadAll();
            }
            else
            {
                HoBUS.Create(HolidayDTO);
                ClearTextBoxes();
                dataGridView1.DataSource = HoBUS.ReadAll();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           HolidayDTO.Id1 = Convert.ToInt32(txt_id.Text);
            HolidayDTO.Holiday_name_group = txt_name_group.Text;
            HolidayDTO.Holiday_name_en = txt_name_en.Text;
            HolidayDTO.Holiday_name_vi = txt_name_vi.Text;
             HolidayDTO.Remark = txt_remark.Text;
        
                HoBUS.Update(HolidayDTO);
            ClearTextBoxes();
            dataGridView1.DataSource = HoBUS.ReadAll();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_id.Text = row.Cells[0].Value.ToString();
            dateTimePicker1.Text = row.Cells[1].Value.ToString();
            txt_name_group.Text = row.Cells[2].Value.ToString();
            txt_name_en.Text = row.Cells[3].Value.ToString();
            txt_name_vi.Text = row.Cells[4].Value.ToString();
            txt_remark.Text = row.Cells[5].Value.ToString();
            txt_updated_by.Text = row.Cells[6].Value.ToString();
            txt_updated_date.Text = row.Cells[7].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            
            
           HolidayDTO.Id1 = Convert.ToInt32(txt_id.Text);    
            if (txt_id.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập Id");
            }
            else

            {
                HoBUS.Delete(HolidayDTO);
                MessageBox.Show("Đã xóa thành công");
                ClearTextBoxes();
                dataGridView1.DataSource = HoBUS.ReadAll();
            }

        }

        
    }
}
