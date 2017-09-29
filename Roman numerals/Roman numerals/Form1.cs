using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roman_numerals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbxNumbers.Text);
            ConvertNumberToRoman(number);
            tbxRoman.Text = ConvertNumberToRoman(number);
        }

        public string ConvertNumberToRoman(int number)
        {
            if (number >= 1000)
            {
                return "M" + ConvertNumberToRoman(number - 1000);
            }

            if (number >= 900)
            {
                
            }

            if (number == 0)
            {
                return "";
            }
            return number.ToString();
        }
    }
}
