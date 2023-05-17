using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLBH.Classes
{
    internal class CommonFunction
    {
        public static string sql;
        public void FillCombobox(ComboBox comboName,DataTable data ,string displayMember, string valueMember)
        {
            comboName.DataSource = data;
            comboName.DisplayMember = displayMember;
            comboName.ValueMember = valueMember;
        }
     
    }
}
