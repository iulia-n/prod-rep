// Class containing methods manipulating values stored in controls on the forms

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace ProdRep
{
    
    class HelperMethods
    {
        /* Get a Dictionary with one entry for each row in the given DataGridView. 
         * For each entry, the key will use the column specified by columnKey and the value will use the column specified by columnValue
         */
        public Dictionary<int, double> getDictionaryFromDataGridViewColumns(DataGridView dataGridView, int columnKey, int columnValue)
        {
            Dictionary<int, double> result = new Dictionary<int,double>();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                result.Add(int.Parse(dataGridView.Rows[i].Cells[columnKey].Value.ToString()), 
                            double.Parse(dataGridView.Rows[i].Cells[columnValue].Value.ToString()));
            }
            return result;
        }
    }
}
