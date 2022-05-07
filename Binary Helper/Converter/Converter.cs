using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Helper
{
    public partial class Converter
    {
        public string TextToBin(string text)
        {
            // Convert Text to Binary
            string result = "";
            foreach(char letter in text)
            {
                result += Convert.ToString(letter, 2).PadLeft(8, '0')+" ";
            }
            return result;
        }

        public string BinToText(string data)
        {
            data = data.Replace(" ", "");
            List<Byte> byteList = new List<Byte>();
            for(int i = 0; i<data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
    }

}