using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace SalesManagement
{
    public class FomatNumber
    {
        public static string GetLeftSideString(string strInput, char cSeparate)
        {
            int nIndex = strInput.IndexOf(cSeparate);
            if (nIndex <= 0)
                return "";
            return strInput.Substring(0, nIndex);
        }
        public static void txtMoney_TextChanged(object sender, EventArgs e)
        {
            TextBox txtMoney = (TextBox)sender;
            string strInput = txtMoney.Text.Trim();
            if (strInput != "-" && strInput != "")
            {
                Int64 money = GetTextboxValueInt64(strInput);
                txtMoney.Text = FormatNumberDot(money);
            }
            txtMoney.SelectionStart = txtMoney.Text.Length;
        }
        public static string FormatNumberDot(long nValue)
        {
            if (nValue == 0)
                return "0";
            string strNumber = nValue.ToString("N", CultureInfo.CreateSpecificCulture("en-US"));
            if (isEnUS() == true)
                return GetLeftSideString(strNumber, '.').Replace(',', '.');
            return GetLeftSideString(strNumber, ',');//.Replace(',', '.');
        }
        public static long GetTextboxValueInt64(string strValue)
        {
            if (strValue.Contains("."))
                strValue = strValue.Replace(".", "");
            if (strValue.Contains(","))
            {
                int pos = strValue.IndexOf(",");
                strValue = strValue.Substring(0, pos);
                //strValue = strValue.Replace(",", "");
            }
            long value = 0;
            if (long.TryParse(strValue, out value) == false)
            {
                //MessageBox.Show("Giá trị lớn hơn 2 tỷ là không hợp lệ");
                return 0;
            }
            return value;
        }
        private static bool isEnUS()
        {
            long nValue = 9;
            string strNumber = nValue.ToString("N", CultureInfo.CreateSpecificCulture("en-US"));
            return strNumber.Contains(".");
        }
    }
}
