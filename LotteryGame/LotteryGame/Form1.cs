using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LotteryGame
{
    public partial class frmMain : Form
    {
        List<Button> listButton = new List<Button>();
        List<int> listSelectNum = new List<int>();
        List<int> listRandNum = new List<int>();
        List<int> listResult = new List<int>();
        int currentMyComboBoxIndex = 0;
        List<int> tempNum = new List<int>();
        
        private System.Timers.Timer timerTick = new System.Timers.Timer();
        private System.Timers.Timer timerGameResult = new System.Timers.Timer();
        List<Label> listLabel = new List<Label>();

        bool isMaximize = false;
        private Image normalImage;
        private Image maximizedImage;

        public frmMain()
        {
            InitializeComponent();
            normalImage = Properties.Resources.icons8_restore_down_24;
            maximizedImage = Properties.Resources.icons8_maximize_button_24;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnCreate(10, 8);

            cboGamePlayState.Items.Add("十星");
            cboGamePlayState.Items.Add("九星");
            cboGamePlayState.Items.Add("八星");
            cboGamePlayState.Items.Add("七星");
            cboGamePlayState.Items.Add("六星");
            cboGamePlayState.Items.Add("五星");
            cboGamePlayState.Items.Add("四星");
            cboGamePlayState.Items.Add("三星");
            cboGamePlayState.Items.Add("二星");
            cboGamePlayState.Items.Add("一星");

            timerTick = new System.Timers.Timer();
            timerTick.Elapsed += timerTick_Elapsed;

            timerGameResult = new System.Timers.Timer(5000);
            timerGameResult.Elapsed += timerGameResult_Elapsed;

            listLabel.Add(lblNumOne);
            listLabel.Add(lblNumTwo);
            listLabel.Add(lblNumThree);
            listLabel.Add(lblNumFour);
            listLabel.Add(lblNumFive);
            listLabel.Add(lblNumSix);
            listLabel.Add(lblNumSeven);
            listLabel.Add(lblNumEight);
            listLabel.Add(lblNumNine);
            listLabel.Add(lblNumTen);
            
            timerTick.Start();
            timerGameResult.Start();
        }

        void btnCreate(int intColumn, int intRow)
        {
            int bNum = 0;

            for(int i = 0; i < intRow; i++)
            {
                for(int j = 0; j < intColumn; j++)
                {
                    bNum++;
                    Button dButton = new Button();
                    dButton.BackColor = Color.Orange;
                    dButton.ForeColor = Color.DarkRed;
                    dButton.Font = new Font("微軟正黑體", 18);
                    dButton.Text = bNum.ToString();
                    dButton.Location = new Point(20 + 62 * j, 60 + 42 * i);
                    dButton.Size = new Size(60, 40);
                    dButton.Click += dButton_Click;
                    Controls.Add(dButton);
                    listButton.Add(dButton);
                }
            }

        }

        void dButton_Click(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;
            int intNum = Convert.ToInt32(myBtn.Text);

            //if (myBtn.BackColor == Color.Orange && listNum.Count < 10)
            //{
            //    myBtn.BackColor = Color.LightGoldenrodYellow;

            //    listNum.Add(intNum);

            //}
            if(cboGamePlayState.Text == string.Empty)
            {
                MessageBox.Show("請選擇玩法");
            }

            if (myBtn.BackColor == Color.Orange && cboGamePlayState.Text != string.Empty)
            {
                int maxCount = 10 - currentMyComboBoxIndex;
                if (listSelectNum.Count < maxCount)
                {
                    myBtn.BackColor = Color.LightGoldenrodYellow;
                    listSelectNum.Add(intNum);
                }
                else
                {
                    MessageBox.Show("超出玩法規定號碼數");
                }
            }
            else
            {
                myBtn.BackColor = Color.Orange;
                listSelectNum.Remove(intNum);
            }
        }

        private void btnQuickNum_Click(object sender, EventArgs e)
        {
            if(cboGamePlayState.SelectedItem == null)
            {
                MessageBox.Show("請選擇玩法");
            }
            else
            {
                for (int i = 0; i < listButton.Count; i++)
                {
                    listButton[i].Enabled = false;
                }
                btnNumConfirm.Enabled = false;
                ClearNum();
                QuickNum();
            }
        }

        private void btnNumConfirm_Click(object sender, EventArgs e)
        {
            btnQuickNum.Enabled = false;
            if (listSelectNum.Count < 1)
            {
                MessageBox.Show("請選擇號碼");
            }
            else
            {
                listBoxNum.Items.Clear();
                NumComfirm();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listButton.Count; i++)
            {
                listButton[i].Enabled = true;
            }
            btnNumConfirm.Enabled = true;
            btnQuickNum.Enabled = true;
            ClearNum();
        }

        void NumComfirm()
        {
            tempNum.Clear();
            string strMsg = string.Empty;

            listSelectNum.Sort();
            int count = listSelectNum.Count;
            int gameRoleNum = 10 - currentMyComboBoxIndex;

            if(gameRoleNum == count)
            {
                //for (int i = 0; i < count; i++)
                //{
                //    strMsg += listSelectNum[i].ToString();
                //    tempNum.Add(listSelectNum[i]);
                //    if (i < count - 1)
                //    {
                //        strMsg += ", ";
                //    }
                //}
                //listBoxNum.Items.Add(strMsg);
                strMsg = string.Join(", ", listSelectNum);
                
                tempNum.AddRange(listSelectNum);
                listBoxNum.Items.Add(strMsg);
            }
            else
            {
                MessageBox.Show("請繼續選擇");
            }
        }


        void QuickNum()
        {
            Random randNum = new Random();
            string strMsg = string.Empty;
            tempNum.Clear();
            // method 1 需加入其他方法時使用
            //do
            //{
            //    int Num = randNum.Next(1, 81);
            //    int dup = listRandNum.IndexOf(Num);
            //    if (dup < 0)
            //    {
            //        listRandNum.Add(Num);
            //        listButton[Num].BackColor = Color.LightGoldenrodYellow;
            //    }
            //}
            //while (listRandNum.Count < 10);

            // Method 2 單純只產生隨機碼
            int maxCount = 10 - currentMyComboBoxIndex;
            listRandNum = Enumerable.Range(0, 80)
                .OrderBy(x => randNum.Next())
                .Take(maxCount)
                .ToList();
            listRandNum.Sort();
            foreach (int Num in listRandNum)
            {
                listButton[Num].BackColor = Color.LightGoldenrodYellow;
                strMsg += (Num + 1) + ", ";
                tempNum.Add(Num + 1);
            }
            if (!string.IsNullOrEmpty(strMsg))
            {
                //strMsg = strMsg.TrimEnd(','); // 刪除最後一個逗號
                strMsg = strMsg.Substring(0, strMsg.Length - 2); // 刪除最後的逗號和空格, (擷取要的值)
                Console.WriteLine(strMsg);
            }
            
            listBoxNum.Items.Add(strMsg);
        }

        void ClearNum()
        {
            for (int i = 0; i < listButton.Count; i++)
            {
                listButton[i].BackColor = Color.Orange;
            }

            listBoxNum.Items.Clear();
            listRandNum.Clear();
            listSelectNum.Clear();
        }

        private void cboGamePlayState_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMyComboBoxIndex = cboGamePlayState.FindStringExact(cboGamePlayState.Text);
            ClearNum();
            Console.WriteLine(currentMyComboBoxIndex);
            //current = (string)cboGamePlayState.SelectedItem;
            //Console.WriteLine(current);
        }

        void timerTick_Elapsed(object sender, ElapsedEventArgs e)
        {
            timerTick.Stop();

            try
            {
                setText_Label(lblTIme, string.Format(DateTime.Now.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                timerTick.Start();
            }
        }

        void timerGameResult_Elapsed(object sender, ElapsedEventArgs e)
        {
            timerGameResult.Stop();

            try
            {
                Random randNum = new Random();
                string strResult = string.Empty;
                
                listResult = Enumerable.Range(1, 80).OrderBy(x => randNum.Next()).Take(10).ToList();
                for (int i = 0; i < listResult.Count; i++)
                {
                    setText_Label(listLabel[i], string.Format(listResult[i].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                timerGameResult.Start();
            }
        }

        private void setText_Label(Label _lbl, string txt)
        {
            Action setText = () =>
            {
                _lbl.Text = string.Format(txt);
            };

            if (_lbl.InvokeRequired)
            {
                _lbl.Invoke(setText);
            }
            else
            {
                setText();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (isMaximize)
            {
                isMaximize = false;
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Image = Properties.Resources.icons8_maximize_button_24;
            }
            else
            {
                isMaximize= true;
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Properties.Resources.icons8_restore_down_24;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            StringBuilder messageBuilder = new StringBuilder();

            string strNum = string.Empty;
            string strLabel = string.Empty;
            int LabelCount = listLabel.Count;
            int NumCount = tempNum.Count;
            int commonCount = 0;
            //for (int i = 0; i < NumCount; i++)
            //{
            //    strNum += tempNum[i];
            //    if(i < NumCount - 1)
            //    {
            //        strNum += ", ";
            //    }
            //}
            //messageBuilder.AppendLine(strNum);

            //for (int i = 0; i < LabelCount; i++) 
            //{
            //    strLabel += listLabel[i].Text;
            //    if(i < LabelCount - 1)
            //    {
            //        strLabel += ", ";
            //    }
            //}
            //messageBuilder.AppendLine(strLabel);

            tempNum.Sort();
            listLabel.Sort((label1, label2) => int.Parse(label1.Text).CompareTo(int.Parse(label2.Text)));

            if (cboGamePlayState.SelectedIndex != -1 && listBoxNum.Items.Count != 0)
            {
                foreach (var number in tempNum)
                {
                    foreach (var label in listLabel)
                    {
                        if (int.TryParse(label.Text, out int labelText) && labelText == number)
                        {
                            commonCount++;
                            break; // 找到相同的數字後跳出內層迴圈，進入下一個數字的比較
                        }
                    }
                }

                messageBuilder.AppendLine("tempNum 內容: " + string.Join(", ", tempNum));
                messageBuilder.AppendLine("listLabel 內容: " + string.Join(", ", listLabel.Select(label => label.Text)));
                messageBuilder.AppendLine("相同的數字有: " + commonCount);

                MessageBox.Show(messageBuilder.ToString());
            }
        }
    }
}
