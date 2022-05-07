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
        /// <summary>
        /// This will convert any string text to binary, octal, hexadecimal
        /// </summary>
        /// <param name="text">this is the text that will be converted</param>
        /// <param name="toBase">what number system output user want</param>
        /// <param name="padLength">fill the resulting output with a 0 to the left if
        /// the length of the result is not equal to pad length and equalize it.
        /// default value is 8 for binary</param>
        /// <returns>the converted text to defined output</returns>
        public string TextToBin(string text, int toBase, int padLength = 8)
        {
            // Convert Text to Binary
            string result = "";
            foreach(char letter in text)
            {
                result += Convert.ToString(letter, toBase).PadLeft(padLength, '0')+" ";
            }
            return result;
        }

        /// <summary>
        /// convert binary, octal, or hexadecimal to text
        /// </summary>
        /// <param name="data">the data that will be converted to text</param>
        /// <param name="fromBase">what is the data number system</param>
        /// <param name="increment">increment of for loop so it will know where to break
        /// the given data for convertion, default value is 8</param>
        /// <returns>string of binary, octal, or hexadecimal depending on the user</returns>
        public string BinToText(string data, int fromBase, int increment = 8)
        {
            data = data.Replace(" ", "");
            List<Byte> byteList = new List<Byte>();
            for(int i = 0; i<data.Length; i += increment)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, increment), fromBase));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        /// <summary>
        /// Convert other number system other than decimal to other number system other than
        /// decimal
        /// </summary>
        /// <param name="data">data to convert</param>
        /// <param name="fromBase">what is the data number system</param>
        /// <param name="toBase">what number system output user want</param>
        /// <param name="increment">increment of for loop so it will know where to break
        /// the given data for convertion, default value is 8</param>
        /// <param name="padLength">fill the resulting output with a 0 to the left if
        /// the length of the result is not equal to pad length and equalize it.
        /// default value is 8 for binary</param>
        /// <returns>string of number system he want the data to be converted with</returns>
        public string NumberSytemConvert(string data, int fromBase, int toBase,
            int increment = 8, int padLength = 8)
        {
            return TextToBin(BinToText(data, fromBase, increment), toBase, padLength);
        }
    }

}