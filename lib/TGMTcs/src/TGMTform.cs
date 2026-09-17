//CÔNG TY TNHH GIẢI PHÁP THỊ GIÁC MÁY TÍNH
//support@viscomsolution.com
//0939.825.125

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TGMTcs
{
    public class TGMTform
    {
        public static void UnselectDatagridview(DataGridView grid_data)
        {
            if (grid_data.RowCount > 0 && grid_data.ColumnCount > 0)
            {
                grid_data.CurrentCell = grid_data[0, 0];
                grid_data.CurrentCell.Selected = false;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void MoveCaretToEnd(ComboBox cb)
        {
            if (cb.Text != "")
            {
                cb.SelectionStart = cb.Text.Length;
                cb.SelectionLength = 0;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void MoveCaretToEnd(TextBox txt)
        {
            if (txt.Text != "")
            {
                txt.SelectionStart = txt.Text.Length;
                txt.SelectionLength = 0;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void FormatGrid(DataGridView grid, string[] columns)
        {
            foreach (string c in columns)
            {
                grid.Columns[c].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid.Columns[c].DefaultCellStyle.Format = "N0";
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void OnlyInputNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //on key up event
        public static void FormatDelimiter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                return;


            TextBox textbox = (TextBox)sender;
            string text = textbox.Text.Replace(",", "");
            if (text == "")
                return;

            int selectionStart = textbox.SelectionStart;
            long number = Convert.ToInt64(text);
            textbox.Text = number.ToString("N0");

            textbox.SelectionStart = selectionStart;
            textbox.SelectionLength = 0;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void SetDoubleBuffer(DataGridView dgv)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgv, new object[] { true });
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void SetDoubleBuffer(ListView dgv)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgv, new object[] { true });
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void SetDoubleBuffer(FlowLayoutPanel panel)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, panel, new object[] { true });
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void SaveFormLocation(Form form)
        {
            string location = form.Location.X + "," + form.Location.Y + "," + form.Width + "," + form.Height;
            TGMTregistry.GetInstance().SaveValue(form.Name + "_location", location);
            TGMTregistry.GetInstance().SaveValue(form.Name + "_WindowState", form.WindowState);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public static void LoadFormLocation(Form form)
        {
            string state = TGMTregistry.GetInstance().ReadString(form.Name + "_WindowState");
            if(state == "Maximized")
                form.WindowState = FormWindowState.Maximized;
            else if (state == "Minimized")
                form.WindowState = FormWindowState.Minimized;


            string location = TGMTregistry.GetInstance().ReadString(form.Name + "_location");

            string[] splitted = location.Split(',');
            if(splitted.Length == 4)
            {
                int x = int.Parse(splitted[0]);
                int y = int.Parse(splitted[1]);
                if(x <0 || y < 0)
                    return;
                form.Location = new System.Drawing.Point(x, y);
                form.Width = int.Parse(splitted[2]);
                form.Height = int.Parse(splitted[3]);
            }

        }
    }
}