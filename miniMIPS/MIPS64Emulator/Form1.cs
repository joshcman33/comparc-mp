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
        private void wala() 
        { 

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
                    opcode += Convert.ToString(num, 2);
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
                    opcode += Convert.ToString(num, 2);
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

           while (counter < ctr)
           {
               string compare = line[counter];
               int ic = 0;
               while (compare[ic] != ' ')
               {
                    oper[counter] += compare[ic];
                    ic++;
               }

               oper[counter] = oper[counter].ToUpper();
               ic++;

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
                                else if(destReg[counter][0]== '0')
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
                                else if(destReg[counter][0]== '0')
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
                                    ic ++;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }

                            try
                            {
                                while (compare[ic] != ')')
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
                            int a = offset[counter].Length;
                            if (offset[counter].Length != 4)
                            {
                                check--;
                                break;
                            }
                            else
                            {
                            }
                        }
                        break;

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
                                    ic++;
                                }

                            }
                            else
                            {
                                check--;
                                break;
                            }


                            try
                            {
                                while (compare[ic] != ')')
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
                            int a = offset[counter].Length;
                            if (offset[counter].Length != 4)
                            {
                                check--;
                                break;
                            }
                            else
                            {
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
                            ic += 2;

                            while (compare[ic] != ',')
                            {
                                sourceA[counter] += compare[ic];
                                ic++;
                            }

                            sourceA[counter] = sourceA[counter].ToUpper();
                            ic += 2;

                            while (ic != compare.Length)
                            {
                                immediate[counter] += compare[ic];
                                ic++;
                            }

                            immediate[counter] = immediate[counter].ToUpper();
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
           if (check == 1)
           {
               int i = 0;
               while (i < ctr)
               {
                   Output.Text += "Operator: " + oper[i] + Environment.NewLine;
                   Output.Text += "RD: " + destination[i] + Environment.NewLine;
                   Output.Text += "RS: " + sourceA[i] + Environment.NewLine;
                   Output.Text += "RT: " + sourceB[i] + Environment.NewLine;
                   Output.Text += "Offset: " + offset[i] + Environment.NewLine;
                   Output.Text += "Immediate: " + immediate[i] + Environment.NewLine;
                   Output.Text += "Destination Register:" + destReg[i] + Environment.NewLine;
                   IFconversion(oper[i], destReg[i], sourceAReg[i], sourceBReg[i], offset[i], immediate[i]);
                   i++;
               }
               
           }
           else
           {
               MessageBox.Show("Syntax error encountered.");
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
           
            readInput();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
