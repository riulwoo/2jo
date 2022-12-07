﻿namespace Torder
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lv_bill = new System.Windows.Forms.ListView();
            this.gbSum = new System.Windows.Forms.GroupBox();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lblTextSum = new System.Windows.Forms.Label();
            this.gbDut = new System.Windows.Forms.GroupBox();
            this.lblDutCost = new System.Windows.Forms.Label();
            this.lblDutNum = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTextDut = new System.Windows.Forms.Label();
            this.time_close = new System.Windows.Forms.Timer(this.components);
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSum.SuspendLayout();
            this.gbDut.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.lblBill.Location = new System.Drawing.Point(21, 14);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(98, 37);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "계산서";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblTimer.Location = new System.Drawing.Point(471, 32);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(136, 19);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "30초 후에 닫힙니다.";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btnClose.Location = new System.Drawing.Point(613, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lv_bill
            // 
            this.lv_bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.count,
            this.tprice});
            this.lv_bill.GridLines = true;
            this.lv_bill.HideSelection = false;
            this.lv_bill.Location = new System.Drawing.Point(23, 60);
            this.lv_bill.Name = "lv_bill";
            this.lv_bill.Size = new System.Drawing.Size(442, 210);
            this.lv_bill.TabIndex = 3;
            this.lv_bill.UseCompatibleStateImageBehavior = false;
            // 
            // gbSum
            // 
            this.gbSum.Controls.Add(this.lb_amount);
            this.gbSum.Controls.Add(this.lblTextSum);
            this.gbSum.Location = new System.Drawing.Point(23, 276);
            this.gbSum.Name = "gbSum";
            this.gbSum.Size = new System.Drawing.Size(442, 56);
            this.gbSum.TabIndex = 4;
            this.gbSum.TabStop = false;
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lb_amount.Location = new System.Drawing.Point(400, 27);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(19, 15);
            this.lb_amount.TabIndex = 1;
            this.lb_amount.Text = "원";
            // 
            // lblTextSum
            // 
            this.lblTextSum.AutoSize = true;
            this.lblTextSum.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblTextSum.Location = new System.Drawing.Point(15, 27);
            this.lblTextSum.Name = "lblTextSum";
            this.lblTextSum.Size = new System.Drawing.Size(31, 15);
            this.lblTextSum.TabIndex = 0;
            this.lblTextSum.Text = "합계";
            // 
            // gbDut
            // 
            this.gbDut.Controls.Add(this.lblDutCost);
            this.gbDut.Controls.Add(this.lblDutNum);
            this.gbDut.Controls.Add(this.btnPlus);
            this.gbDut.Controls.Add(this.btnMinus);
            this.gbDut.Controls.Add(this.lblNum);
            this.gbDut.Controls.Add(this.lblTextDut);
            this.gbDut.Location = new System.Drawing.Point(481, 55);
            this.gbDut.Name = "gbDut";
            this.gbDut.Size = new System.Drawing.Size(200, 277);
            this.gbDut.TabIndex = 5;
            this.gbDut.TabStop = false;
            // 
            // lblDutCost
            // 
            this.lblDutCost.AutoSize = true;
            this.lblDutCost.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblDutCost.Location = new System.Drawing.Point(94, 221);
            this.lblDutCost.Name = "lblDutCost";
            this.lblDutCost.Size = new System.Drawing.Size(19, 15);
            this.lblDutCost.TabIndex = 11;
            this.lblDutCost.Text = "원";
            this.lblDutCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDutNum
            // 
            this.lblDutNum.AutoSize = true;
            this.lblDutNum.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblDutNum.Location = new System.Drawing.Point(81, 175);
            this.lblDutNum.Name = "lblDutNum";
            this.lblDutNum.Size = new System.Drawing.Size(42, 15);
            this.lblDutNum.TabIndex = 10;
            this.lblDutNum.Text = "1 인당";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Location = new System.Drawing.Point(147, 93);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 23);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Location = new System.Drawing.Point(24, 93);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 23);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblNum.Location = new System.Drawing.Point(94, 98);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(14, 15);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "1";
            // 
            // lblTextDut
            // 
            this.lblTextDut.AutoSize = true;
            this.lblTextDut.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblTextDut.Location = new System.Drawing.Point(71, 36);
            this.lblTextDut.Name = "lblTextDut";
            this.lblTextDut.Size = new System.Drawing.Size(55, 15);
            this.lblTextDut.TabIndex = 6;
            this.lblTextDut.Text = "더치페이";
            // 
            // time_close
            // 
            this.time_close.Interval = 1000;
            this.time_close.Tick += new System.EventHandler(this.time_close_Tick);
            // 
            // name
            // 
            this.name.Text = "상품명";
            this.name.Width = 150;
            // 
            // count
            // 
            this.count.Text = "수량";
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tprice
            // 
            this.tprice.Text = "가격";
            this.tprice.Width = 100;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.ControlBox = false;
            this.Controls.Add(this.gbDut);
            this.Controls.Add(this.gbSum);
            this.Controls.Add(this.lv_bill);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblBill);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "계산서";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbSum.ResumeLayout(false);
            this.gbSum.PerformLayout();
            this.gbDut.ResumeLayout(false);
            this.gbDut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lv_bill;
        private System.Windows.Forms.GroupBox gbSum;
        private System.Windows.Forms.GroupBox gbDut;
        private System.Windows.Forms.Label lblDutCost;
        private System.Windows.Forms.Label lblDutNum;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblTextDut;
        private System.Windows.Forms.Label lblTextSum;
        private System.Windows.Forms.Timer time_close;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader tprice;
    }
}