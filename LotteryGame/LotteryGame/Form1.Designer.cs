namespace LotteryGame
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNumConfirm = new System.Windows.Forms.Button();
            this.listBoxNum = new System.Windows.Forms.ListBox();
            this.btnQuickNum = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboGamePlayState = new System.Windows.Forms.ComboBox();
            this.lblNumOne = new System.Windows.Forms.Label();
            this.lblNumTwo = new System.Windows.Forms.Label();
            this.lblNumThree = new System.Windows.Forms.Label();
            this.lblNumFour = new System.Windows.Forms.Label();
            this.lblNumFive = new System.Windows.Forms.Label();
            this.lblNumSix = new System.Windows.Forms.Label();
            this.lblNumSeven = new System.Windows.Forms.Label();
            this.lblNumEight = new System.Windows.Forms.Label();
            this.lblNumNine = new System.Windows.Forms.Label();
            this.lblNumTen = new System.Windows.Forms.Label();
            this.lblTIme = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNumConfirm
            // 
            this.btnNumConfirm.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumConfirm.Location = new System.Drawing.Point(536, 3);
            this.btnNumConfirm.Name = "btnNumConfirm";
            this.btnNumConfirm.Size = new System.Drawing.Size(102, 51);
            this.btnNumConfirm.TabIndex = 0;
            this.btnNumConfirm.Text = "選號確認";
            this.btnNumConfirm.UseVisualStyleBackColor = true;
            this.btnNumConfirm.Click += new System.EventHandler(this.btnNumConfirm_Click);
            // 
            // listBoxNum
            // 
            this.listBoxNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNum.FormattingEnabled = true;
            this.listBoxNum.ItemHeight = 31;
            this.listBoxNum.Location = new System.Drawing.Point(0, 0);
            this.listBoxNum.Name = "listBoxNum";
            this.listBoxNum.Size = new System.Drawing.Size(488, 73);
            this.listBoxNum.TabIndex = 1;
            // 
            // btnQuickNum
            // 
            this.btnQuickNum.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickNum.Location = new System.Drawing.Point(662, 3);
            this.btnQuickNum.Name = "btnQuickNum";
            this.btnQuickNum.Size = new System.Drawing.Size(102, 51);
            this.btnQuickNum.TabIndex = 0;
            this.btnQuickNum.Text = "快選號碼";
            this.btnQuickNum.UseVisualStyleBackColor = true;
            this.btnQuickNum.Click += new System.EventHandler(this.btnQuickNum_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(782, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 51);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清除號碼";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboGamePlayState
            // 
            this.cboGamePlayState.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboGamePlayState.FormattingEnabled = true;
            this.cboGamePlayState.Location = new System.Drawing.Point(1036, 19);
            this.cboGamePlayState.Name = "cboGamePlayState";
            this.cboGamePlayState.Size = new System.Drawing.Size(121, 31);
            this.cboGamePlayState.TabIndex = 2;
            this.cboGamePlayState.SelectedIndexChanged += new System.EventHandler(this.cboGamePlayState_SelectedIndexChanged);
            // 
            // lblNumOne
            // 
            this.lblNumOne.AutoSize = true;
            this.lblNumOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOne.Location = new System.Drawing.Point(25, 60);
            this.lblNumOne.Name = "lblNumOne";
            this.lblNumOne.Size = new System.Drawing.Size(49, 36);
            this.lblNumOne.TabIndex = 3;
            this.lblNumOne.Text = "00";
            // 
            // lblNumTwo
            // 
            this.lblNumTwo.AutoSize = true;
            this.lblNumTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTwo.Location = new System.Drawing.Point(100, 60);
            this.lblNumTwo.Name = "lblNumTwo";
            this.lblNumTwo.Size = new System.Drawing.Size(49, 36);
            this.lblNumTwo.TabIndex = 3;
            this.lblNumTwo.Text = "00";
            // 
            // lblNumThree
            // 
            this.lblNumThree.AutoSize = true;
            this.lblNumThree.Location = new System.Drawing.Point(175, 60);
            this.lblNumThree.Name = "lblNumThree";
            this.lblNumThree.Size = new System.Drawing.Size(49, 36);
            this.lblNumThree.TabIndex = 3;
            this.lblNumThree.Text = "00";
            // 
            // lblNumFour
            // 
            this.lblNumFour.AutoSize = true;
            this.lblNumFour.Location = new System.Drawing.Point(250, 60);
            this.lblNumFour.Name = "lblNumFour";
            this.lblNumFour.Size = new System.Drawing.Size(49, 36);
            this.lblNumFour.TabIndex = 3;
            this.lblNumFour.Text = "00";
            // 
            // lblNumFive
            // 
            this.lblNumFive.AutoSize = true;
            this.lblNumFive.Location = new System.Drawing.Point(325, 60);
            this.lblNumFive.Name = "lblNumFive";
            this.lblNumFive.Size = new System.Drawing.Size(49, 36);
            this.lblNumFive.TabIndex = 3;
            this.lblNumFive.Text = "00";
            // 
            // lblNumSix
            // 
            this.lblNumSix.AutoSize = true;
            this.lblNumSix.Location = new System.Drawing.Point(25, 130);
            this.lblNumSix.Name = "lblNumSix";
            this.lblNumSix.Size = new System.Drawing.Size(49, 36);
            this.lblNumSix.TabIndex = 3;
            this.lblNumSix.Text = "00";
            // 
            // lblNumSeven
            // 
            this.lblNumSeven.AutoSize = true;
            this.lblNumSeven.Location = new System.Drawing.Point(100, 130);
            this.lblNumSeven.Name = "lblNumSeven";
            this.lblNumSeven.Size = new System.Drawing.Size(49, 36);
            this.lblNumSeven.TabIndex = 3;
            this.lblNumSeven.Text = "00";
            // 
            // lblNumEight
            // 
            this.lblNumEight.AutoSize = true;
            this.lblNumEight.Location = new System.Drawing.Point(175, 130);
            this.lblNumEight.Name = "lblNumEight";
            this.lblNumEight.Size = new System.Drawing.Size(49, 36);
            this.lblNumEight.TabIndex = 3;
            this.lblNumEight.Text = "00";
            // 
            // lblNumNine
            // 
            this.lblNumNine.AutoSize = true;
            this.lblNumNine.Location = new System.Drawing.Point(250, 130);
            this.lblNumNine.Name = "lblNumNine";
            this.lblNumNine.Size = new System.Drawing.Size(49, 36);
            this.lblNumNine.TabIndex = 3;
            this.lblNumNine.Text = "00";
            // 
            // lblNumTen
            // 
            this.lblNumTen.AutoSize = true;
            this.lblNumTen.Location = new System.Drawing.Point(325, 130);
            this.lblNumTen.Name = "lblNumTen";
            this.lblNumTen.Size = new System.Drawing.Size(49, 36);
            this.lblNumTen.TabIndex = 3;
            this.lblNumTen.Text = "00";
            // 
            // lblTIme
            // 
            this.lblTIme.AutoSize = true;
            this.lblTIme.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTIme.Location = new System.Drawing.Point(29, 24);
            this.lblTIme.Name = "lblTIme";
            this.lblTIme.Size = new System.Drawing.Size(74, 28);
            this.lblTIme.TabIndex = 4;
            this.lblTIme.Text = "Time:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblTIme);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 76);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnMinimize);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnMaximize);
            this.groupBox1.Location = new System.Drawing.Point(1098, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 48);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::LotteryGame.Properties.Resources.icons8_horizontal_line_24;
            this.btnMinimize.Location = new System.Drawing.Point(6, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 28);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LotteryGame.Properties.Resources.icons8_close_24;
            this.btnClose.Location = new System.Drawing.Point(118, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LotteryGame.Properties.Resources.icons8_maximize_button_24;
            this.btnMaximize.Location = new System.Drawing.Point(62, 10);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(50, 28);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumOne);
            this.groupBox2.Controls.Add(this.lblNumTwo);
            this.groupBox2.Controls.Add(this.lblNumTen);
            this.groupBox2.Controls.Add(this.lblNumThree);
            this.groupBox2.Controls.Add(this.lblNumNine);
            this.groupBox2.Controls.Add(this.lblNumFour);
            this.groupBox2.Controls.Add(this.lblNumEight);
            this.groupBox2.Controls.Add(this.lblNumFive);
            this.groupBox2.Controls.Add(this.lblNumSeven);
            this.groupBox2.Controls.Add(this.lblNumSix);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(855, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 194);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxNum);
            this.panel2.Controls.Add(this.btnNumConfirm);
            this.panel2.Controls.Add(this.btnQuickNum);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.cboGamePlayState);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1285, 73);
            this.panel2.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSend.Location = new System.Drawing.Point(902, 10);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(102, 51);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "送出號碼";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumConfirm;
        private System.Windows.Forms.ListBox listBoxNum;
        private System.Windows.Forms.Button btnQuickNum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboGamePlayState;
        private System.Windows.Forms.Label lblNumOne;
        private System.Windows.Forms.Label lblNumTwo;
        private System.Windows.Forms.Label lblNumThree;
        private System.Windows.Forms.Label lblNumFour;
        private System.Windows.Forms.Label lblNumFive;
        private System.Windows.Forms.Label lblNumSix;
        private System.Windows.Forms.Label lblNumSeven;
        private System.Windows.Forms.Label lblNumEight;
        private System.Windows.Forms.Label lblNumNine;
        private System.Windows.Forms.Label lblNumTen;
        private System.Windows.Forms.Label lblTIme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSend;
    }
}

