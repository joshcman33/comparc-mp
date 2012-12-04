using System;
using System.IO;
using System.Windows.Forms;

namespace miniMIPS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[0].Cells[0].Value = "R1";
            this.dataGridView1.Rows[1].Cells[0].Value = "R2";
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[2].Cells[0].Value = "R3";
            this.dataGridView1.Rows[3].Cells[0].Value = "R4";
            this.dataGridView1.Rows[4].Cells[0].Value = "R5";
            this.dataGridView1.Rows[5].Cells[0].Value = "R6";
            this.dataGridView1.Rows[6].Cells[0].Value = "R7";
            this.dataGridView1.Rows[7].Cells[0].Value = "R8";
            this.dataGridView1.Rows[8].Cells[0].Value = "R9";
            this.dataGridView1.Rows[9].Cells[0].Value = "R10";
            this.dataGridView1.Rows[10].Cells[0].Value = "R11";
            this.dataGridView1.Rows[11].Cells[0].Value = "R12";
            this.dataGridView1.Rows[12].Cells[0].Value = "R13";
            this.dataGridView1.Rows[13].Cells[0].Value = "R14";
            this.dataGridView1.Rows[14].Cells[0].Value = "R15";
            this.dataGridView1.Rows[15].Cells[0].Value = "R16";
            this.dataGridView1.Rows[16].Cells[0].Value = "R17";
            this.dataGridView1.Rows[17].Cells[0].Value = "R18";
            this.dataGridView1.Rows[18].Cells[0].Value = "R19";
            this.dataGridView1.Rows[19].Cells[0].Value = "R20";
            this.dataGridView1.Rows[20].Cells[0].Value = "R21";
            this.dataGridView1.Rows[21].Cells[0].Value = "R22";
            this.dataGridView1.Rows[22].Cells[0].Value = "R23";
            this.dataGridView1.Rows[23].Cells[0].Value = "R24";
            this.dataGridView1.Rows[24].Cells[0].Value = "R25";
            this.dataGridView1.Rows[25].Cells[0].Value = "R26";
            this.dataGridView1.Rows[26].Cells[0].Value = "R27";
            this.dataGridView1.Rows[27].Cells[0].Value = "R28";
            this.dataGridView1.Rows[28].Cells[0].Value = "R29";
            this.dataGridView1.Rows[29].Cells[0].Value = "R30";
            this.dataGridView1.Rows[30].Cells[0].Value = "R31";
            for (int i = 0; i < 31; i++ )
                this.dataGridView1.Rows[i].Cells[1].Value = "0000000000000000";
            for (int i = 0; i < 500; i++)
            {
                this.dataGridView2.Rows.Add();
                this.dataGridView2.Rows[i].Cells[0].Value = Convert.ToString(i,16).PadLeft(4,'0');
                this.dataGridView2.Rows[i].Cells[1].Value = "00";
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void operations(string oper, string destination, string sourceA, string sourceB, string offset, string immediate) 
        {
            int dest = Convert.ToInt32(destination);
            int sA = Convert.ToInt32(sourceA);
            int sB = Convert.ToInt32(sourceB);
            int off;
            if (offset == null)
            {
                off = 0;
            }
            else
            {
                off = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);
            }
            int imm;
            if (immediate != null)
            {
                imm = int.Parse(immediate, System.Globalization.NumberStyles.HexNumber);
            }
            else
                imm = 0;
            Int64 sAval;
            Int64 sBval;
            if (sA == 0)
                sAval = 0;
            else
                dataGridView1.Rows[sA - 1].Cells[1].Value = dataGridView1.Rows[sA - 1].Cells[1].Value.ToString().PadLeft(16, '0');
            try
            {
                sAval = Int64.Parse(dataGridView1.Rows[sA - 1].Cells[1].Value.ToString(), System.Globalization.NumberStyles.HexNumber);
            }
            catch
            {
                this.textBox1.Text = "Source Value Invalid" + Environment.NewLine;
                sAval = 0;
            }
            if (sB == 0|| sB==null)
                sBval = 0;
            else
                try
                {
                    sBval = Int64.Parse(dataGridView1.Rows[sB - 1].Cells[1].Value.ToString(), System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    sBval = 0;
                }
               Int64 desti;
            //int dest = int.Parse(offset, System.Globalization.NumberStyles.HexNumber); 
            switch (oper)
            {
                
                case "DADD":
                    desti = sAval + sBval;
                    
                    dataGridView1.Rows[dest - 1].Cells[1].Value = Convert.ToString(desti,16).PadLeft(16,'0').ToUpper();
                    
                    break;
                case "SLT":
                    if (sAval < sBval)
                        dataGridView1.Rows[dest - 1].Cells[1].Value = "0000000000000001";
                    else
                        dataGridView1.Rows[dest - 1].Cells[1].Value = "0000000000000000";
                    
                    break;
                case "DADDI":
                    desti = sAval + imm;
                    dataGridView1.Rows[dest - 1].Cells[1].Value = Convert.ToString(desti, 16).PadLeft(16,'0').ToUpper();
                    
                    break;
                case "LD":
                    desti = off + sAval;
                    int destin = Convert.ToInt32(desti);
                    string output;
                    output = dataGridView2.Rows[destin].Cells[1].Value.ToString();
                    output += dataGridView2.Rows[destin+1].Cells[1].Value.ToString();
                    output += dataGridView2.Rows[destin+2].Cells[1].Value.ToString();
                    output += dataGridView2.Rows[destin+3].Cells[1].Value.ToString();
                    output += dataGridView2.Rows[destin + 4].Cells[1].Value.ToString();
                    output += dataGridView2.Rows[destin + 5].Cells[1].Value.ToString();
                    output += dataGridView2.Rows[destin + 6].Cells[1].Value.ToString();
                    output += dataGridView2.Rows[destin + 7].Cells[1].Value.ToString();
                    dataGridView1.Rows[dest - 1].Cells[1].Value =output;
                    
                    break;
                case "SD":
                    desti = off + sAval;
                    int destina = Convert.ToInt32(desti);
                    string val;
                    dataGridView1.Rows[dest - 1].Cells[1].Value = dataGridView1.Rows[dest - 1].Cells[1].Value.ToString().PadLeft(16, '0');
                    //dataGridView2.Rows[destina].Cells[1].Value = dataGridView1.Rows[dest - 1].Cells[1].Value.ToString()[0];
                    //dataGridView2.Rows[destina].Cells[1].Value += dataGridView1.Rows[dest - 1].Cells[1].Value.ToString()[1];
                    val = dataGridView1.Rows[dest - 1].Cells[1].Value.ToString().Substring(0,2);
                    dataGridView2.Rows[destina].Cells[1].Value = val;
                    val = dataGridView1.Rows[dest - 1].Cells[1].Value.ToString().Substring(2,2);
                    dataGridView2.Rows[destina+1].Cells[1].Value = val;
                    val = dataGridView1.Rows[dest - 1].Cells[1].Value.ToString().Substring(4,2);
                    dataGridView2.Rows[destina+2].Cells[1].Value = val;
                    val = dataGridView1.Rows[dest - 1].Cells[1].Value.ToString().Substring(6,2);
                    dataGridView2.Rows[destina+3].Cells[1].Value = val;
                    val = dataGridView1.Rows[dest - 1].Cells[1].Value.ToString().Substring(8,2);
                    dataGridView2.Rows[destina+4].Cells[1].Value = val;
                    val = dataGridView1.Rows[dest - 1].Cells[1].Value.ToString().Substring(10,2);
                    dataGridView2.Rows[destina+5].Cells[1].Value = val;
                    val = dataGridView1.Rows[dest - 1].Cells[1].Value.ToString().Substring(12,2);
                    dataGridView2.Rows[destina+6].Cells[1].Value = val;
                    val = dataGridView1.Rows[dest - 1].Cells[1].Value.ToString().Substring(14,2);
                    dataGridView2.Rows[destina+7].Cells[1].Value = val;
                    break;
                case "XOR":
                    desti = sAval ^ sBval;
                    dataGridView1.Rows[dest - 1].Cells[1].Value = Convert.ToString(desti, 16).PadLeft(16, '0').ToUpper();
                    
                    break;
                case "OR":
                    desti = sAval | sBval;
                    dataGridView1.Rows[dest - 1].Cells[1].Value = Convert.ToString(desti, 16).PadLeft(16, '0').ToUpper();
                    
                    break;
                case "DSUB":
                    desti = sAval - sBval;
                    if(desti<0)
                        dataGridView1.Rows[dest - 1].Cells[1].Value = Convert.ToString(desti, 16).PadLeft(16, 'F').ToUpper();
                    else
                        dataGridView1.Rows[dest - 1].Cells[1].Value = Convert.ToString(desti, 16).PadLeft(16, '0').ToUpper();
                    break;

            }
        }
        private void IFconversion(string oper, string destination, string sourceA, string sourceB, string offset, string immediate)
        {
            string opcode = null;
            string RD = null;
            string RS = null;
            string RT = null;
            string Offset = null;
            string IMM = null;
            int x = Convert.ToInt32(destination);
            int y = Convert.ToInt32(sourceA);
            int z = Convert.ToInt32(sourceB);
            

            switch (oper)
            {
               
                case "DADD":
                opcode = "000000 ";
                    if (x >= 8)
                    {
                        opcode += "0";
                    }
                    else if (x >= 4)
                    {
                        opcode += "00";
                    }
                    else if (x >= 2)
                    {
                        opcode += "000";
                    }
                    else if (x >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(x,2);
                    opcode += " ";
                    if (y >= 8)
                    {
                        opcode += "0";
                    }
                    else if (y >= 4)
                    {
                        opcode += "00";
                    }
                    else if (y >= 2)
                    {
                        opcode += "000";
                    }
                    else if (y >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(y, 2);
                    opcode += " ";
                    if (z >= 8)
                    {
                        opcode += "0";
                    }
                    else if (z >= 4)
                    {
                        opcode += "00";
                    }
                    else if (z >= 2)
                    {
                        opcode += "000";
                    }
                    else if (z >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(z, 2);
                    opcode += " ";
                    opcode += "00000 ";
                    opcode += "101100";
                    break;

                case "DSUB":
                    opcode = "000000 ";
                    if (x >= 8)
                    {
                        opcode += "0";
                    }
                    else if (x >= 4)
                    {
                        opcode += "00";
                    }
                    else if (x >= 2)
                    {
                        opcode += "000";
                    }
                    else if (x >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(x, 2);
                    opcode += " ";
                    if (y >= 8)
                    {
                        opcode += "0";
                    }
                    else if (y >= 4)
                    {
                        opcode += "00";
                    }
                    else if (y >= 2)
                    {
                        opcode += "000";
                    }
                    else if (y >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(y, 2);
                    opcode += " ";
                    if (z >= 8)
                    {
                        opcode += "0";
                    }
                    else if (z >= 4)
                    {
                        opcode += "00";
                    }
                    else if (z >= 2)
                    {
                        opcode += "000";
                    }
                    else if (z >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(z, 2);
                    opcode += " ";
                    opcode += "00000 ";
                    opcode += "101110";
                    break;
                case "OR":
                    opcode = "000000 ";
                    if (x >= 8)
                    {
                        opcode += "0";
                    }
                    else if (x >= 4)
                    {
                        opcode += "00";
                    }
                    else if (x >= 2)
                    {
                        opcode += "000";
                    }
                    else if (x >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(x, 2);
                    opcode += " ";
                    if (y >= 8)
                    {
                        opcode += "0";
                    }
                    else if (y >= 4)
                    {
                        opcode += "00";
                    }
                    else if (y >= 2)
                    {
                        opcode += "000";
                    }
                    else if (y >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(y, 2);
                    opcode += " ";
                    if (z >= 8)
                    {
                        opcode += "0";
                    }
                    else if (z >= 4)
                    {
                        opcode += "00";
                    }
                    else if (z >= 2)
                    {
                        opcode += "000";
                    }
                    else if (z >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(z, 2);
                    opcode += " ";
                    opcode += "00000 ";
                    opcode += "100101";
                    break;
                case "XOR":
                    opcode = "000000 ";
                    if (x >= 8)
                    {
                        opcode += "0";
                    }
                    else if (x >= 4)
                    {
                        opcode += "00";
                    }
                    else if (x >= 2)
                    {
                        opcode += "000";
                    }
                    else if (x >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(x, 2);
                    opcode += " ";
                    if (y >= 8)
                    {
                        opcode += "0";
                    }
                    else if (y >= 4)
                    {
                        opcode += "00";
                    }
                    else if (y >= 2)
                    {
                        opcode += "000";
                    }
                    else if (y >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(y, 2);
                    opcode += " ";
                    if (z >= 8)
                    {
                        opcode += "0";
                    }
                    else if (z >= 4)
                    {
                        opcode += "00";
                    }
                    else if (z >= 2)
                    {
                        opcode += "000";
                    }
                    else if (z >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(z, 2);
                    opcode += " ";
                    opcode += "00000 ";
                    opcode += "100110";
                    break;
                case "SLT":
                    opcode = "000000 ";
                    if (x >= 8)
                    {
                        opcode += "0";
                    }
                    else if (x >= 4)
                    {
                        opcode += "00";
                    }
                    else if (x >= 2)
                    {
                        opcode += "000";
                    }
                    else if (x >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(x,2);
                    opcode += " ";
                    if (y >= 8)
                    {
                        opcode += "0";
                    }
                    else if (y >= 4)
                    {
                        opcode += "00";
                    }
                    else if (y >= 2)
                    {
                        opcode += "000";
                    }
                    else if (y >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(y, 2);
                    opcode += " ";
                    if (z >= 8)
                    {
                        opcode += "0";
                    }
                    else if (z >= 4)
                    {
                        opcode += "00";
                    }
                    else if (z >= 2)
                    {
                        opcode += "000";
                    }
                    else if (z >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(z, 2);
                    opcode += " ";
                    opcode += "00000 ";
                    opcode += "101010";
                    break;
                case "BNEZ":
                    opcode = "000101";
                    break;
                case "LD":
                    opcode = "110111 ";
                    if (x >= 8)
                    {
                        opcode += "0";
                    }
                    else if (x >= 4)
                    {
                        opcode += "00";
                    }
                    else if (x >= 2)
                    {
                        opcode += "000";
                    }
                    else if (x >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(x,2);
                    opcode += " ";
                    if (y >= 8)
                    {
                        opcode += "0";
                    }
                    else if (y >= 4)
                    {
                        opcode += "00";
                    }
                    else if (y >= 2)
                    {
                        opcode += "000";
                    }
                    else if (y >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(y, 2);
                    opcode += " ";
                    int num = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);
                    opcode += Convert.ToString(num, 2).PadLeft(16, '0');
                    break;
                case "SD":
                    opcode = "111111 ";
                    if (x >= 8)
                    {
                        opcode += "0";
                    }
                    else if (x >= 4)
                    {
                        opcode += "00";
                    }
                    else if (x >= 2)
                    {
                        opcode += "000";
                    }
                    else if (x >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(x,2);
                    opcode += " ";
                    if (y >= 8)
                    {
                        opcode += "0";
                    }
                    else if (y >= 4)
                    {
                        opcode += "00";
                    }
                    else if (y >= 2)
                    {
                        opcode += "000";
                    }
                    else if (y >= 1)
                    {
                        opcode += "0000";
                    }
                    opcode += Convert.ToString(y, 2);
                    opcode += " ";
                    num = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);
                    opcode += Convert.ToString(num, 2).PadLeft(16,'0');
                    break;
                    
                case "DADDI":
                    opcode = "011000";
                    break;
                case "J":
                    opcode = "000010";
                    break;
            }

            RD =

            Output.Text += "Opcode: " + opcode + Environment.NewLine;
        }
        private void checkSyntax(string[] line, int ctr)
        {
            int check = 1;
            int counter = 0;
            string[] oper = new string[10];
            string[] destination = new string[10];
            string[] destReg = new string[10];
            string[] sourceA = new string[10];
            string[] sourceAReg = new string[10];
            string[] sourceB = new string[10];
            string[] sourceBReg = new string[10];
            string[] offset = new string[10];
            string[] immediate = new string[10];
            string[] imm = new string[10];
            int magic = 0;
            int[] alecmagic = new int[1000];
            alecmagic[magic] = -4;
            while (counter < ctr)
            {
                string compare = line[counter];
                int ic = 0;
                try
                {
                    while (compare[ic] != ' ')
                    {
                        oper[counter] += compare[ic];
                        ic++;
                    }

                    oper[counter] = oper[counter].ToUpper();
                    ic++;
                }
                catch
                {
                    check--;
                }
                switch (oper[counter])
                {
                    case "DADD":
                        {
                            while (compare[ic] != ',')
                            {
                                destination[counter] += compare[ic];
                                ic++;
                            }

                            destination[counter] = destination[counter].ToUpper();
                            if (destination[counter][0] == 'R')
                            {
                                int x = destination[counter].IndexOf("R") + 1;

                                destReg[counter] = destination[counter].Substring(x);
                                int y = Convert.ToInt32(destReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (destReg[counter][0] == '0')
                                {
                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }
                            }
                            else
                            {
                                check--;
                                break;

                            }

                            while (compare[ic] != ',')
                            {
                                sourceA[counter] += compare[ic];
                                ic++;
                            }

                            sourceA[counter] = sourceA[counter].ToUpper();
                            if (sourceA[counter][0] == 'R')
                            {
                                int x = sourceA[counter].IndexOf("R") + 1;
                                sourceAReg[counter] = sourceA[counter].Substring(x);
                                int y = Convert.ToInt32(sourceAReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceAReg[counter].Length == 2 && sourceAReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }

                            while (ic != compare.Length)
                            {
                                sourceB[counter] += compare[ic];
                                ic++;
                            }

                            sourceB[counter] = sourceB[counter].ToUpper();
                            if (sourceB[counter][0] == 'R')
                            {
                                int x = sourceB[counter].IndexOf("R") + 1;
                                sourceBReg[counter] = sourceB[counter].Substring(x);
                                int y = Convert.ToInt32(sourceBReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceBReg[counter].Length == 2 && sourceBReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }
                        }
                        break;
                    case "BNEZ":
                        {
                            while (compare[ic] != ',')
                            {
                                sourceA[counter] += compare[ic];
                                ic++;
                            }

                            sourceA[counter] = sourceA[counter].ToUpper();
                            if (sourceA[counter][0] == 'R')
                            {
                                ic += 2;
                            }
                            else
                            {
                                check--;
                                break;
                            }



                            while (ic != compare.Length)
                            {
                                offset[counter] += compare[ic];

                                ic++;
                            }

                            offset[counter] = offset[counter].ToUpper();
                            if (offset[counter][0] == 'L')
                            {
                            }
                            else
                            {
                                check--;
                                break;
                            }
                        }
                        break;
                    case "DSUB":
                        {
                            while (compare[ic] != ',')
                            {
                                destination[counter] += compare[ic];
                                ic++;
                            }

                            destination[counter] = destination[counter].ToUpper();
                            if (destination[counter][0] == 'R')
                            {
                                int x = destination[counter].IndexOf("R") + 1;

                                destReg[counter] = destination[counter].Substring(x);
                                int y = Convert.ToInt32(destReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (destReg[counter][0] == '0')
                                {
                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }
                            }
                            else
                            {
                                check--;
                                break;

                            }

                            while (compare[ic] != ',')
                            {
                                sourceA[counter] += compare[ic];
                                ic++;
                            }

                            sourceA[counter] = sourceA[counter].ToUpper();
                            if (sourceA[counter][0] == 'R')
                            {
                                int x = sourceA[counter].IndexOf("R") + 1;
                                sourceAReg[counter] = sourceA[counter].Substring(x);
                                int y = Convert.ToInt32(sourceAReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceAReg[counter].Length == 2 && sourceAReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }

                            while (ic != compare.Length)
                            {
                                sourceB[counter] += compare[ic];
                                ic++;
                            }

                            sourceB[counter] = sourceB[counter].ToUpper();
                            if (sourceB[counter][0] == 'R')
                            {
                                int x = sourceB[counter].IndexOf("R") + 1;
                                sourceBReg[counter] = sourceB[counter].Substring(x);
                                int y = Convert.ToInt32(sourceBReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceBReg[counter].Length == 2 && sourceBReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }
                        }
                        break;
                    case "OR":
                        {
                            while (compare[ic] != ',')
                            {
                                destination[counter] += compare[ic];
                                ic++;
                            }

                            destination[counter] = destination[counter].ToUpper();
                            if (destination[counter][0] == 'R')
                            {
                                int x = destination[counter].IndexOf("R") + 1;

                                destReg[counter] = destination[counter].Substring(x);
                                int y = Convert.ToInt32(destReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (destReg[counter][0] == '0')
                                {
                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }
                            }
                            else
                            {
                                check--;
                                break;

                            }

                            while (compare[ic] != ',')
                            {
                                sourceA[counter] += compare[ic];
                                ic++;
                            }

                            sourceA[counter] = sourceA[counter].ToUpper();
                            if (sourceA[counter][0] == 'R')
                            {
                                int x = sourceA[counter].IndexOf("R") + 1;
                                sourceAReg[counter] = sourceA[counter].Substring(x);
                                int y = Convert.ToInt32(sourceAReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceAReg[counter].Length == 2 && sourceAReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }

                            while (ic != compare.Length)
                            {
                                sourceB[counter] += compare[ic];
                                ic++;
                            }

                            sourceB[counter] = sourceB[counter].ToUpper();
                            if (sourceB[counter][0] == 'R')
                            {
                                int x = sourceB[counter].IndexOf("R") + 1;
                                sourceBReg[counter] = sourceB[counter].Substring(x);
                                int y = Convert.ToInt32(sourceBReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceBReg[counter].Length == 2 && sourceBReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }
                        }
                        break;
                    case "XOR":
                        {
                            while (compare[ic] != ',')
                            {
                                destination[counter] += compare[ic];
                                ic++;
                            }

                            destination[counter] = destination[counter].ToUpper();
                            if (destination[counter][0] == 'R')
                            {
                                int x = destination[counter].IndexOf("R") + 1;

                                destReg[counter] = destination[counter].Substring(x);
                                int y = Convert.ToInt32(destReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (destReg[counter][0] == '0')
                                {
                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }
                            }
                            else
                            {
                                check--;
                                break;

                            }

                            while (compare[ic] != ',')
                            {
                                sourceA[counter] += compare[ic];
                                ic++;
                            }

                            sourceA[counter] = sourceA[counter].ToUpper();
                            if (sourceA[counter][0] == 'R')
                            {
                                int x = sourceA[counter].IndexOf("R") + 1;
                                sourceAReg[counter] = sourceA[counter].Substring(x);
                                int y = Convert.ToInt32(sourceAReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceAReg[counter].Length == 2 && sourceAReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }

                            while (ic != compare.Length)
                            {
                                sourceB[counter] += compare[ic];
                                ic++;
                            }

                            sourceB[counter] = sourceB[counter].ToUpper();
                            if (sourceB[counter][0] == 'R')
                            {
                                int x = sourceB[counter].IndexOf("R") + 1;
                                sourceBReg[counter] = sourceB[counter].Substring(x);
                                int y = Convert.ToInt32(sourceBReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceBReg[counter].Length == 2 && sourceBReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }
                        }
                        break;
                    case "SLT":
                        {
                            while (compare[ic] != ',')
                            {
                                destination[counter] += compare[ic];
                                ic++;
                            }

                            destination[counter] = destination[counter].ToUpper();
                            if (destination[counter][0] == 'R')
                            {
                                int x = destination[counter].IndexOf("R") + 1;

                                destReg[counter] = destination[counter].Substring(x);
                                int y = Convert.ToInt32(destReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (destReg[counter][0] == '0')
                                {
                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }
                            }
                            else
                            {
                                check--;
                                break;

                            }

                            while (compare[ic] != ',')
                            {
                                sourceA[counter] += compare[ic];
                                ic++;
                            }

                            sourceA[counter] = sourceA[counter].ToUpper();
                            if (sourceA[counter][0] == 'R')
                            {
                                int x = sourceA[counter].IndexOf("R") + 1;
                                sourceAReg[counter] = sourceA[counter].Substring(x);
                                int y = Convert.ToInt32(sourceAReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceAReg[counter].Length == 2 && sourceAReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }

                            while (ic != compare.Length)
                            {
                                sourceB[counter] += compare[ic];
                                ic++;
                            }

                            sourceB[counter] = sourceB[counter].ToUpper();
                            if (sourceB[counter][0] == 'R')
                            {
                                int x = sourceB[counter].IndexOf("R") + 1;
                                sourceBReg[counter] = sourceB[counter].Substring(x);
                                int y = Convert.ToInt32(sourceBReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceBReg[counter].Length == 2 && sourceBReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }
                        }
                        break;
                    case "LD":
                        {
                            while (compare[ic] != ',')
                            {
                                destination[counter] += compare[ic];
                                ic++;
                            }

                            destination[counter] = destination[counter].ToUpper();
                            if (destination[counter][0] == 'R')
                            {
                                int x = destination[counter].IndexOf("R") + 1;

                                destReg[counter] = destination[counter].Substring(x);
                                int y = Convert.ToInt32(destReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (destReg[counter][0] == '0')
                                {
                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }
                            }
                            else
                            {
                                check--;
                                break;

                            }
                            try
                            {
                                while (compare[ic] != '(')
                                {
                                    offset[counter] += compare[ic];
                                    ic++;
                                }
                                if (offset[counter].Length != 4)
                                {
                                    check--;
                                }
                            }
                            catch
                            {
                                check--;
                            }

                            offset[counter] = offset[counter].ToUpper();

                            offset[counter] = offset[counter];
                            try
                            {
                                int a = int.Parse(offset[counter], System.Globalization.NumberStyles.HexNumber);

                                if (a >= 65536)
                                {
                                    check--;
                                    break;
                                }

                                else
                                {
                                    ic++;
                                }
                            }
                            catch
                            {
                                check--;
                            }


                            try
                            {
                                while (compare[ic] != ')')
                                {
                                    sourceA[counter] += compare[ic];
                                    ic++;
                                }
                            }
                            catch
                            {
                                check--;
                            }

                            sourceA[counter] = sourceA[counter].ToUpper();
                            if (sourceA[counter][0] == 'R')
                            {
                                int x = sourceA[counter].IndexOf("R") + 1;
                                sourceAReg[counter] = sourceA[counter].Substring(x);
                                int y = Convert.ToInt32(sourceBReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceAReg[counter].Length == 2 && sourceAReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }
                            break;
                        }

                    case "SD":
                        {
                            while (compare[ic] != ',')
                            {
                                destination[counter] += compare[ic];
                                ic++;
                            }

                            destination[counter] = destination[counter].ToUpper();
                            if (destination[counter][0] == 'R')
                            {
                                int x = destination[counter].IndexOf("R") + 1;

                                destReg[counter] = destination[counter].Substring(x);
                                int y = Convert.ToInt32(destReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (destReg[counter][0] == '0')
                                {
                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }
                            }
                            else
                            {
                                check--;
                                break;

                            }
                            try
                            {
                                while (compare[ic] != '(')
                                {
                                    offset[counter] += compare[ic];
                                    ic++;
                                }
                            }
                            catch
                            {
                                check--;
                            }

                            offset[counter] = offset[counter].ToUpper();

                            offset[counter] = offset[counter];
                            try
                            {
                                int a = int.Parse(offset[counter], System.Globalization.NumberStyles.HexNumber);
                                if (a > 16 * 16 * 16 * 16)
                                {
                                    check--;
                                    break;
                                }

                                else
                                {
                                    ic++;
                                }
                            }
                            catch
                            {
                                check--;
                            }


                            try
                            {
                                while (compare[ic] != ')')
                                {
                                    sourceA[counter] += compare[ic];
                                    ic++;
                                }
                            }
                            catch
                            {
                                check--;
                            }

                            sourceA[counter] = sourceA[counter].ToUpper();
                            if (sourceA[counter][0] == 'R')
                            {
                                int x = sourceA[counter].IndexOf("R") + 1;
                                sourceAReg[counter] = sourceA[counter].Substring(x);
                                int y = Convert.ToInt32(sourceBReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceAReg[counter].Length == 2 && sourceAReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }
                            break;
                        }

                    case "DADDI":
                        {
                            while (compare[ic] != ',')
                            {
                                destination[counter] += compare[ic];
                                ic++;
                            }

                            destination[counter] = destination[counter].ToUpper();
                            if (destination[counter][0] == 'R')
                            {
                                int x = destination[counter].IndexOf("R") + 1;

                                destReg[counter] = destination[counter].Substring(x);
                                int y = Convert.ToInt32(destReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (destReg[counter][0] == '0')
                                {
                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }
                            }
                            else
                            {
                                check--;
                                break;

                            }

                            while (compare[ic] != ',')
                            {
                                sourceA[counter] += compare[ic];
                                ic++;
                            }

                            sourceA[counter] = sourceA[counter].ToUpper();
                            if (sourceA[counter][0] == 'R')
                            {
                                int x = sourceA[counter].IndexOf("R") + 1;
                                sourceAReg[counter] = sourceA[counter].Substring(x);
                                int y = Convert.ToInt32(sourceAReg[counter]);
                                if (y > 31)
                                {
                                    check--;
                                    break;
                                }
                                else if (sourceAReg[counter].Length == 2 && sourceAReg[counter][0] == '0')
                                {

                                    check--;
                                    break;
                                }
                                else
                                {
                                    ic += 2;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }

                            while (ic != compare.Length)
                            {
                                immediate[counter] += compare[ic];
                                ic++;
                            }

                            immediate[counter] = immediate[counter].ToUpper();
                            if (immediate[counter][0] == '#')
                            {
                                int x = immediate[counter].IndexOf("#") + 1;
                                imm[counter] = immediate[counter].Substring(x);
                                try
                                {
                                    int y = int.Parse(imm[counter], System.Globalization.NumberStyles.HexNumber);
                                    if (y > 1048575)
                                    {
                                        check--;
                                        break;
                                    }
                                }
                                catch 
                                {
                                    check--;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }
                        }
                        break;
                    case "J":
                        {
                            while (ic != compare.Length)
                            {
                                offset[counter] += compare[ic];
                                ic++;
                            }

                            offset[counter] = offset[counter].ToUpper();
                        }
                        break;
                    default:
                        if (check == 1)
                        {
                            //Output.Text = "ERROR: Not a valid instruction.";
                            MessageBox.Show("Syntax error encountered.");
                        }
                        check--;
                        break;
                }
                //IFconversion(oper[counter], destReg[counter], sourceAReg[counter], sourceBReg[counter], offset[counter], immediate[counter]);
                counter++;
            }


            int i = 0;

            while (i < ctr)
            {
                if (check == 1)
                {
                    alecmagic[magic] += 4;
                    Output.Text += "Operator: " + oper[i] + Environment.NewLine;
                    Output.Text += "RD: " + destination[i] + Environment.NewLine;
                    Output.Text += "RS: " + sourceA[i] + Environment.NewLine;
                    Output.Text += "RT: " + sourceB[i] + Environment.NewLine;
                    Output.Text += "Offset: " + offset[i] + Environment.NewLine;
                    Output.Text += "Immediate: " + immediate[i] + Environment.NewLine;
                    Output.Text += "Destination Register:" + destReg[i] + Environment.NewLine;
                    Output.Text += "Alec's magic:" + alecmagic[magic] + Environment.NewLine;
                    IFconversion(oper[i], destReg[i], sourceAReg[i], sourceBReg[i], offset[i], imm[i]);
                    operations(oper[i], destReg[i], sourceAReg[i], sourceBReg[i], offset[i], imm[i]);
                }

                else
                {
                    int x = i + 1;
                    textBox1.Text += "Syntax error encountered at line" + x + Environment.NewLine;
                }
                i++;

                magic++;

            }
        }
           
           
        

        private void readInput()
        {
            string code = Input.Text;
            int ctr = 0;
            string[] line = code.Split(new char[] {'\n'});
            try
            {
                while (line[ctr] != null)
                {
                    label1.Text = ctr.ToString();
                    ctr++;
                }
            }
            catch
            {
                string count = label1.Text;
                ctr = Convert.ToInt32(count);
                ctr += 1;
                checkSyntax(line,ctr);
            }
        }

        private void Compile_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            textBox1.Text = "";
           
            readInput();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
