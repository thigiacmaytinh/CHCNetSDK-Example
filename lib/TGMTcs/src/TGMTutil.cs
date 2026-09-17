//CÔNG TY TNHH GIẢI PHÁP THỊ GIÁC MÁY TÍNH
//support@viscomsolution.com
//0939.825.125

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TGMTcs
{
    public class TGMTutil
    {
        public static string CorrectPath(string path)
        {
            if (path == "")
                return "";
            if (path[path.Length - 1] != '\\')
            {
                path += '\\';
            }
            return path;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string GetStartupPath()
        {
            string startupPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return CorrectPath(startupPath);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string GetVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            var parts = version.Split('.');
            return $"{parts[0]}.{parts[1]}";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string GetPlaform()
        {
            return IntPtr.Size == 4 ? "x86" : "x64";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string ConvertToAlphanumeric(string str)
        {
            str = Regex.Replace(str, "[^0-9a-zA-Z]+", "");
            return str;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string RemoveSpecialCharacter(string str)
        {
            str= Regex.Replace(str, "[^0-9a-zA-Z]+", "");
            return str;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string ReadMoney(double inputNumber)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "ngàn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            if (sNumber == "" || sNumber == "0")
                return "Không đồng";

            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "mốt " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            result = result[0].ToString().ToUpper() + result.Substring(1);
            return result + " đồng";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public static bool IsUnicodePath(string path)
        {
            return path.Any(c => c > 127);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public static string RemoveVNaccent(string accentedStr)
        {
            if (string.IsNullOrEmpty(accentedStr))
                return accentedStr;

            //Test case: Nguyễn Ngọc Hoàng
            string result = accentedStr;

            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    result = result.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return result;
        }

        private static readonly string[] VietnameseSigns = new string[]
        {

            "aAeEoOuUiIdDyY",

            "áàạảãâấầậẩẫăắằặẳẵ",

            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

            "éèẹẻẽêếềệểễ",

            "ÉÈẸẺẼÊẾỀỆỂỄ",

            "óòọỏõôốồộổỗơớờợởỡ",

            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

            "úùụủũưứừựửữ",

            "ÚÙỤỦŨƯỨỪỰỬỮ",

            "íìịỉĩ",

            "ÍÌỊỈĨ",

            "đ",

            "Đ",

            "ýỳỵỷỹ",

            "ÝỲỴỶỸ"
        };

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string RandomString(int length)
        {
            string random = Guid.NewGuid().ToString("N").Substring(0, length);
            return random;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public static string GetCurrentDateTime(bool removeSpecialCharacter)
        {
            DateTime now = DateTime.Now;
            string format = "yyyy-MM-dd.HH:mm:ss";
            string dateTime = now.ToString(format, CultureInfo.InvariantCulture);

            if (removeSpecialCharacter)
            {
                dateTime = dateTime.Replace(":", "-");
            }

            return dateTime;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
    }
}

    

