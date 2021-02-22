using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentPattern
{
    public class Data
    {
        public DataTable TableData { get; set; }

        public Data()
        {
            TableData.Columns.Add("Modifications");
        }
        public Data(string linha , bool isAdd = true)
        {
            if (isAdd) TableData.Rows.Add(linha);
            else TableData.Rows.Add(linha);
        }
    }
}
