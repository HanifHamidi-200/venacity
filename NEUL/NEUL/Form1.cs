using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEUL
{
    public partial class Form1 : Form
    {
        private int mnSelect1, mnSelect2;
        private bool mbSelectFirst;
        private List<bool> T1_null = new List<bool> { false,false,false,false,false,false };
        private List<int> T1_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T1_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T2_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T2_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T2_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T3_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T3_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T3_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T4_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T4_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T4_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T5_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T5_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T5_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T6_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T6_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T6_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T7_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T7_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T7_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T8_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T8_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T8_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A1_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A1_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A1_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A2_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A2_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A2_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A3_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A3_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A3_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A4_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A4_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A4_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A5_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A5_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A5_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A6_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A6_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A6_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B1_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B1_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B1_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B2_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B2_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B2_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B3_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B3_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B3_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B4_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B4_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B4_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B5_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B5_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B5_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B6_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B6_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B6_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> C1_null = new List<bool> { false, false, false, false};
        private List<int> C1_method = new List<int> { 0, 0, 0, 0 };
        private List<int> C1_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> C2_null = new List<bool> { false, false, false, false};
        private List<int> C2_method = new List<int> { 0, 0, 0, 0};
        private List<int> C2_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> C3_null = new List<bool> { false, false, false, false};
        private List<int> C3_method = new List<int> { 0, 0, 0, 0 };
        private List<int> C3_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> C4_null = new List<bool> { false, false, false, false};
        private List<int> C4_method = new List<int> { 0, 0, 0, 0 };
        private List<int> C4_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> C5_null = new List<bool> { false, false, false, false};
        private List<int> C5_method = new List<int> { 0, 0, 0, 0 };
        private List<int> C5_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> C6_null = new List<bool> { false, false, false, false };
        private List<int> C6_method = new List<int> { 0, 0, 0, 0 };
        private List<int> C6_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> E1_null = new List<bool> { false };
        private List<int> E1_method = new List<int> { 0 };
        private List<int> E1_index = new List<int> { 0 };
        private List<bool> E2_null = new List<bool> { false};
        private List<int> E2_method = new List<int> { 0 };
        private List<int> E2_index = new List<int> { 0 };
        private List<bool> E3_null = new List<bool> { false };
        private List<int> E3_method = new List<int> { 0 };
        private List<int> E3_index = new List<int> { 0 };
        private List<bool> E4_null = new List<bool> { false};
        private List<int> E4_method = new List<int> { 0 };
        private List<int> E4_index = new List<int> { 0 };

        private void fReset()
        {
            mbSelectFirst = true;
            mnSelect1 = 11;
            mnSelect2 = 11;

            fUpdateDisplay();
        }

        private String fCell(int nCell)
        {
            switch (nCell)
            {
                case 11:
                    return "T1";
                case 12:
                    return "T2";
                case 13:
                    return "T3";
                case 14:
                    return "T4";
                case 15:
                    return "T5";
                case 16:
                    return "T6";
                case 17:
                    return "T7";
                case 18:
                    return "T8";
                case 21:
                    return "A1";
                case 22:
                    return "A2";
                case 23:
                    return "A3";
                case 24:
                    return "A4";
                case 25:
                    return "A5";
                case 26:
                    return "A6";
                case 31:
                    return "B1";
                case 32:
                    return "B2";
                case 33:
                    return "B3";
                case 34:
                    return "B4";
                case 35:
                    return "B5";
                case 36:
                    return "B6";
                case 41:
                    return "C1";
                case 42:
                    return "C2";
                case 43:
                    return "C3";
                case 44:
                    return "C4";
                case 45:
                    return "C5";
                case 46:
                    return "C6";
                case 51:
                    return "E1";
                case 52:
                    return "E2";
                case 53:
                    return "E3";
                default:
                    return "E4";

            }
        }
        private void fUpdateDisplay()
        {
            String sText1 = fCell(mnSelect1);
            String sText2 = fCell(mnSelect2);
            String sText = sText1 + " (" + sText2 + ")";

            lblItem.Text = sText;
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 11;
            }
            else
            {
                mnSelect2 = 11;
            }
            fUpdateDisplay();
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 12;
            }
            else
            {
                mnSelect2 = 12;
            }
            fUpdateDisplay();

        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 13;
            }
            else
            { 
                mnSelect2 = 13;
            }
            fUpdateDisplay();

        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 14;
            }
            else
            {
                mnSelect2 = 14;
            }
            fUpdateDisplay();

        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 15;
            }
            else
            {
                mnSelect2 = 15;
            }
            fUpdateDisplay();

        }

        private void btnT6_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 16;
            }
            else
            {
                mnSelect2 = 16;
            }
            fUpdateDisplay();

        }

        private void btnT7_Click(object sender, EventArgs e)
        {

            if (mbSelectFirst)
            {
                mnSelect1 = 17;
            }
            else
            {
                mnSelect2 = 17;
            }
            fUpdateDisplay();
        }



        private void btnSelect1_Click(object sender, EventArgs e)
        {
            mbSelectFirst = true;

        }

        private void btnT8_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 18;
            }
            else
            {
                mnSelect2 = 18;
            }
            fUpdateDisplay();

        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 21;
            }
            else
            {
                mnSelect2 = 21;
            }
            fUpdateDisplay();

        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 22;
            }
            else
            {
                mnSelect2 = 22;
            }
            fUpdateDisplay();

        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 23;
            }
            else
            {
                mnSelect2 = 23;
            }
            fUpdateDisplay();

        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 24;
            }
            else
            {
                mnSelect2 = 24;
            }
            fUpdateDisplay();

        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 25;
            }
            else
            {
                mnSelect2 = 25;
            }
            fUpdateDisplay();

        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 26;
            }
            else
            {
                mnSelect2 = 26;
            }
            fUpdateDisplay();

        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 31;
            }
            else
            {
                mnSelect2 = 31;
            }
            fUpdateDisplay();

        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 32;
            }
            else
            {
                mnSelect2 = 32;
            }
            fUpdateDisplay();

        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 33;
            }
            else
            {
                mnSelect2 = 33;
            }
            fUpdateDisplay();

        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 34;
            }
            else
            {
                mnSelect2 = 34;
            }
            fUpdateDisplay();

        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 35;
            }
            else
            {
                mnSelect2 = 35;
            }
            fUpdateDisplay();

        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 36;
            }
            else
            {
                mnSelect2 = 36;
            }
            fUpdateDisplay();

        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 41;
            }
            else
            {
                mnSelect2 = 41;
            }
            fUpdateDisplay();

        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 42;
            }
            else
            {
                mnSelect2 = 42;
            }
            fUpdateDisplay();

        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 43;
            }
            else
            {
                mnSelect2 = 43;
            }
            fUpdateDisplay();

        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 44;
            }
            else
            {
                mnSelect2 = 44;
            }
            fUpdateDisplay();

        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 45;
            }
            else
            {
                mnSelect2 = 45;
            }
            fUpdateDisplay();

        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 46;
            }
            else
            {
                mnSelect2 = 46;
            }
            fUpdateDisplay();

        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 51;
            }
            else
            {
                mnSelect2 = 51;
            }
            fUpdateDisplay();

        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 52;
            }
            else
            {
                mnSelect2 = 52;
            }
            fUpdateDisplay();

        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 53;
            }
            else
            {
                mnSelect2 = 53;
            }
            fUpdateDisplay();

        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 54;
            }
            else
            {
                mnSelect2 = 54;
            }
            fUpdateDisplay();

        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            {
                mbSelectFirst = false;
            }
        }
    }
}
