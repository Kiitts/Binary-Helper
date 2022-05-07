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
    public partial class Form1 : Form
    {
        Converter converter = new Converter();
        public int lastToSelected = 1;
        public int lastFromSelected = 0;
        public bool recentChange = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fromConvertList.SelectedIndex = 0;
            toConvertList.SelectedIndex = 1;
        }

        // Start of Clear Buttons
        private void fromClearButton_Click(object sender, EventArgs e)
        {
            fromConvertText.Text = "";
        }

        private void toClearButton_Click(object sender, EventArgs e)
        {
            toConvertText.Text = "";
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            ClearTexts();
        }
            // Start Clear Buttons: Support function
        private void ClearTexts()
        {
            fromConvertText.Text = "";
            toConvertText.Text = "";
        }
            // End Clear Buttons: Support function
        // End of Clear Buttons

        // Start of Copy Button
        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(toConvertText.Text);
        }
        // End of Copy Button

        // Start of ComboBox functions
        private void fromConvertList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recentChange)
            {
                recentChange = false;
            }
            else
            {
                if (toConvertList.SelectedIndex == fromConvertList.SelectedIndex)
                {
                    SwapText();
                    toConvertList.SelectedIndex = lastFromSelected;
                }
                else
                {
                    ClearTexts();
                }
            }
            lastFromSelected = fromConvertList.SelectedIndex;
        }

        private void toConvertList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recentChange)
            {
                recentChange = false;
            }
            else
            {
                if (toConvertList.SelectedIndex == fromConvertList.SelectedIndex)
                {
                    SwapText();
                    fromConvertList.SelectedIndex = lastToSelected;
                }
                else
                {
                    ClearTexts();
                }
            }
            lastToSelected = toConvertList.SelectedIndex;
        }

            // Start Convert Button: Supporting Function
        private void SwapText()
        {
            recentChange = true;
            if (toConvertText.Text.Length != 0 && fromConvertText.Text.Length != 0)
            {
                string textHolder = fromConvertText.Text.ToString();
                fromConvertText.Text = toConvertText.Text;
                toConvertText.Text = textHolder;
            }
            else
            {
                ClearTexts();
            }
        }
            // End Convert Button: Supporting Function

        // End of Combo Box functions

        // Start of Convert Button
        private void convertButton_Click(object sender, EventArgs e)
        {
            if (fromConvertList.SelectedIndex == 0 && toConvertList.SelectedIndex == 1)
            {
                // convert text to binary
                toConvertText.Text = converter.TextToBin(fromConvertText.Text, 2);
            }
            else if (fromConvertList.SelectedIndex == 0 && toConvertList.SelectedIndex == 2)
            {
                // convert text to octal
                toConvertText.Text = converter.TextToBin(fromConvertText.Text, 8, 3);
            }
            else if (fromConvertList.SelectedIndex == 1 && toConvertList.SelectedIndex == 0)
            {
                // convert binary to text
                try
                {
                    toConvertText.Text = converter.BinToText(fromConvertText.Text, 2);
                }
                catch(System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("You did not input proper binary.", "Error Box");
                    fromConvertText.Text = "";
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("Your binary has a letter or other number other than 1 and 0",
                        "Error Box");
                }
            }
            else if (fromConvertList.SelectedIndex == 2 && toConvertList.SelectedIndex == 0)
            {
                try
                {
                    toConvertText.Text = converter.BinToText(fromConvertText.Text, 8, 3);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("You did not input proper octal.", "Error Box");
                    fromConvertText.Text = "";
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Your octal number has exceed 8 or it has letter on it",
                        "Error Box");
                }
            }
        }
        // End of Convert Button

    }
}
