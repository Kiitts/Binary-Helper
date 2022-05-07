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
            fromConvertText.Text = "";
            toConvertText.Text = "";
        }
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
            if(toConvertList.SelectedIndex == fromConvertList.SelectedIndex)
            {
                toConvertList.SelectedIndex = lastFromSelected;
            }
            lastFromSelected = fromConvertList.SelectedIndex;
        }

        private void toConvertList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toConvertList.SelectedIndex == fromConvertList.SelectedIndex)
            {
                fromConvertList.SelectedIndex = lastToSelected;
            }
            lastToSelected = toConvertList.SelectedIndex;
        }
        // End of Combo Box functions

    }
}
