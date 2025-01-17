﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torder
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0; Data Source=2jo.accdb;Mode=ReadWrite";
        //데이터 저장 배열
        List<string> fName = new List<string>();
        List<string> fId = new List<string>();
        List<int> fPrice = new List<int>();

        List<Panel> cPanel = new List<Panel>();
        List<Label> clblName = new List<Label>();
        List<Label> clblNum = new List<Label>();
        List<Label> clblSum = new List<Label>();
        List<Button> cBDelete = new List<Button>();
        List<Button> cBMinus = new List<Button>();
        List<Button> cBPlus = new List<Button>();
        int foodSelect = 0;
        int foodSum = 0;
        int foodPrice = 0;


        private void btn_call_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void btn_bill_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btn_oList_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cart_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_cart.Checked == true)
            {
                if (pCart_list.Controls.Count > 0)
                {
                    pCart_sum.Visible = true;
                    pCart_price.Visible = true;
                }
                panel_cart.Visible = true;
            }
            else
                panel_cart.Visible = false;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void btn_left_menu1_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 0);
            if (this.btn_left_menu1.Checked == false)
                this.btn_left_menu1.Checked = true;

            this.btn_left_menu2.Checked = false;
            this.btn_left_menu3.Checked = false;

            this.btn_top_menu1.Checked = true;
            this.btn_top_menu2.Checked = false;
            this.btn_top_menu3.Checked = false;
            this.btn_top_menu4.Checked = false;
            this.btn_top_menu5.Checked = false;

            this.btn_top_menu1.Visible = true;
            this.btn_top_menu2.Visible = true;
            this.btn_top_menu3.Visible = true;
            this.btn_top_menu4.Visible = false;
            this.btn_top_menu5.Visible = false;
        }

        private void btn_top_menu1_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 0);
            if (this.btn_top_menu1.Checked == false)
                this.btn_top_menu1.Checked = true;

            this.btn_top_menu2.Checked = false;
            this.btn_top_menu3.Checked = false;
        }

        private void btn_top_menu2_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 580);
            if (this.btn_top_menu2.Checked == false)
                this.btn_top_menu2.Checked = true;

            this.btn_top_menu1.Checked = false;
            this.btn_top_menu3.Checked = false;
        }

        private void btn_top_menu3_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 1160);
            if (this.btn_top_menu3.Checked == false)
                this.btn_top_menu3.Checked = true;
            
            this.btn_top_menu1.Checked = false;
            this.btn_top_menu2.Checked = false;
        }

        private void btn_left_menu2_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 1740);
            if (this.btn_left_menu2.Checked == false)
                this.btn_left_menu2.Checked = true;

            this.btn_left_menu1.Checked = false;
            this.btn_left_menu3.Checked = false;

            this.btn_top_menu1.Checked = false;
            this.btn_top_menu2.Checked = false;
            this.btn_top_menu3.Checked = false;
            this.btn_top_menu4.Checked = true;
            this.btn_top_menu5.Checked = false;

            this.btn_top_menu1.Visible = false;
            this.btn_top_menu2.Visible = false;
            this.btn_top_menu3.Visible = false;
            this.btn_top_menu4.Visible = true;
            this.btn_top_menu5.Visible = true;
        }

        private void btn_left_menu3_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 2900);
            if (this.btn_left_menu3.Checked == false)
                this.btn_left_menu3.Checked = true;

            this.btn_left_menu1.Checked = false;
            this.btn_left_menu2.Checked = false;

            this.btn_top_menu1.Checked = false;
            this.btn_top_menu2.Checked = false;
            this.btn_top_menu3.Checked = false;
            this.btn_top_menu4.Checked = false;
            this.btn_top_menu5.Checked = false;

            this.btn_top_menu1.Visible = false;
            this.btn_top_menu2.Visible = false;
            this.btn_top_menu3.Visible = false;
            this.btn_top_menu4.Visible = false;
            this.btn_top_menu5.Visible = false;
        }

        private void btn_top_menu4_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 1740);
            if (this.btn_top_menu4.Checked == false)
                this.btn_top_menu4.Checked = true;

            this.btn_top_menu5.Checked = false;
        }
        private void btn_top_menu5_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 2320);
            if (this.btn_top_menu5.Checked == false)
                this.btn_top_menu5.Checked = true;

            this.btn_top_menu4.Checked = false;
        }

        private void btn_food_click(object sender, EventArgs e)
        {
            String foodAdd = ((Control)sender).Name.ToString();
            if(((Control)sender).Tag == "notP")
            {
                foodAdd = ((Control)sender).Parent.Name.ToString();
                fId.Add(foodAdd);
            }
            else
                fId.Add(foodAdd);
            
            for (int i = 0; i < fName.Count; i++)
            {
                if (foodAdd == fId[i])
                {
                    fId.RemoveAt(i);
                    return;
                }
            }
            
            
            
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            string sql = "SELECT [prod_name], [prod_price] FROM [product] WHERE [prod_id] = '" + foodAdd + "'";
            var Comm = new OleDbCommand(sql, Conn);
            var myRead = Comm.ExecuteReader();
            myRead.Read();
            fName.Add(myRead[0].ToString());
            fPrice.Add(Convert.ToInt32(myRead[1].ToString()));
            myRead.Close();
            Conn.Close();

            pCart_list.AutoScrollPosition = new Point(0, 0);

                cPanel.Add(new Panel());
                clblName.Add(new Label());
                clblNum.Add(new Label());
                clblSum.Add(new Label());
                cBDelete.Add(new Button());
                cBMinus.Add(new Button());
                cBPlus.Add(new Button());

                cPanel[foodSelect].Name = String.Format("cPanel_{0}", foodSelect);
                cPanel[foodSelect].Size = new Size(238, 66);
                cPanel[foodSelect].Location = new Point(0, 66 * foodSelect);

                clblName[foodSelect].Name = String.Format("clblName_{0}", foodSelect);
                clblName[foodSelect].Text = String.Format("{0}", fName[foodSelect]);
                clblName[foodSelect].Font = new Font("맑은 고딕", 13, FontStyle.Bold);
                clblName[foodSelect].AutoSize = true;
                clblName[foodSelect].Location = new Point(-1, 1);

                clblNum[foodSelect].Name = String.Format("clblNum_{0}", foodSelect);
                clblNum[foodSelect].Text = "1";
                clblNum[foodSelect].Font = new Font("맑은 고딕", 10, FontStyle.Bold);
                clblNum[foodSelect].AutoSize = true;
                clblNum[foodSelect].Location = new Point(36, 39);

                clblSum[foodSelect].Name = String.Format("clblSum_{0}", foodSelect);
                clblSum[foodSelect].Text = String.Format("{0}원", fPrice[foodSelect]);
                clblSum[foodSelect].Font = new Font("맑은 고딕", 15, FontStyle.Bold);
                clblSum[foodSelect].AutoSize = false;
                clblSum[foodSelect].Size = new Size(145, 30);
                clblSum[foodSelect].TextAlign = ContentAlignment.MiddleRight;
                clblSum[foodSelect].Location = new Point(92, 32);

                cBDelete[foodSelect].Name = String.Format("cBDelete_{0}", foodSelect);
                cBDelete[foodSelect].Text = "삭제";
                cBDelete[foodSelect].Font = new Font("맑은 고딕", 9);
                cBDelete[foodSelect].Size = new Size(49, 23);
                cBDelete[foodSelect].Location = new Point(179, 0);
                cBDelete[foodSelect].Click += new System.EventHandler(btnD_Click);

                cBMinus[foodSelect].Name = String.Format("cBMinus_{0}", foodSelect);
                cBMinus[foodSelect].Text = "-";
                cBMinus[foodSelect].Font = new Font("맑은 고딕", 9);
                cBMinus[foodSelect].Size = new Size(25, 23);
                cBMinus[foodSelect].Location = new Point(5, 38);
                cBMinus[foodSelect].Enabled = false;
                cBMinus[foodSelect].Click += new System.EventHandler(btnM_Click);

                cBPlus[foodSelect].Name = String.Format("cBPlus_{0}", foodSelect);
                cBPlus[foodSelect].Text = "+";
                cBPlus[foodSelect].Font = new Font("맑은 고딕", 9);
                cBPlus[foodSelect].Size = new Size(25, 23);
                cBPlus[foodSelect].Location = new Point(61, 38);
                cBPlus[foodSelect].Click += new System.EventHandler(btnP_Click);


                cPanel[foodSelect].Controls.Add(clblName[foodSelect]);
                cPanel[foodSelect].Controls.Add(clblNum[foodSelect]);
                cPanel[foodSelect].Controls.Add(clblSum[foodSelect]);
                cPanel[foodSelect].Controls.Add(cBDelete[foodSelect]);
                cPanel[foodSelect].Controls.Add(cBMinus[foodSelect]);
                cPanel[foodSelect].Controls.Add(cBPlus[foodSelect]);
                pCart_list.Controls.Add(cPanel[foodSelect]);

            if (pCart_list.Controls.Count > 0)
            {
                foodSum += int.Parse(clblNum[foodSelect].Text);
                foodPrice += fPrice[foodSelect];
                pCart_sum.Text = String.Format("{0}가지 {1}개", foodSelect + 1, foodSum);
                pCart_price.Text = String.Format("{0}원", foodPrice);
                pCart_sum.Visible = true;
                pCart_price.Visible = true;
            }

            foodSelect++;

            panel_cart.Visible = true;
            btn_cart.Checked = true;
        }
        
        private void btnD_Click(object sender, EventArgs e)
        {
            pCart_list.AutoScrollPosition = new Point(0, 0);
            Button delete = sender as Button;
            for(int i = 0; i < fId.Count; i++)
            {
                if(delete.Parent.Name.ToString() == cPanel[i].Name.ToString())
                {
                    foodSum -= int.Parse(clblNum[i].Text);
                    foodPrice -= fPrice[i] * int.Parse(clblNum[i].Text);
                    fId.RemoveAt(i);
                    fName.RemoveAt(i);
                    fPrice.RemoveAt(i);
                    clblName.RemoveAt(i);
                    clblNum.RemoveAt(i);
                    clblSum.RemoveAt(i);
                    //cBDelete[i].Click -= new System.EventHandler(btnD_Click);
                    //cBMinus[i].Click -= new System.EventHandler(btnM_Click);
                    //cBPlus[i].Click -= new System.EventHandler(btnP_Click);
                    cBDelete.RemoveAt(i);
                    cBMinus.RemoveAt(i);
                    cBPlus.RemoveAt(i);
                    cPanel.RemoveAt(i);
                    pCart_list.Controls.RemoveAt(i);
                    pCart_sum.Text = String.Format("{0}가지 {1}개", foodSelect - 1, foodSum);
                    pCart_price.Text = String.Format("{0}원", foodPrice);
                    foodSelect--;
                }
            }

            for (int i = 0; i < cPanel.Count; i++)
            {
                cPanel[i].Location = new Point(0, 66 * i);
                cPanel[i].Name = String.Format("cPanel_{0}", i);
                clblName[i].Name = String.Format("clblName_{0}", i);
                clblNum[i].Name = String.Format("clblNum_{0}", i);
                clblSum[i].Name = String.Format("clblSum_{0}", i);
                cBDelete[i].Name = String.Format("cBDelete_{0}", i);
                cBMinus[i].Name = String.Format("cBMinus_{0}", i);
                cBPlus[i].Name = String.Format("cBPlus_{0}", i);
                pCart_list.Controls.Add(cPanel[i]);
            }

            if (pCart_list.Controls.Count < 1)
            {
                pCart_sum.Visible = false;
                pCart_price.Visible = false;
            }


        }

        private void btnM_Click(object sender, EventArgs e)
        {
            Button minus = sender as Button;
            for (int i = 0; i < fId.Count; i++)
            {
                if (minus.Parent.Name.ToString() == cPanel[i].Name.ToString())
                {
                    foreach(Control con in cPanel[i].Controls)
                    {
                        if(con.Name == String.Format("clblNum_{0}", i))
                        {
                            clblNum[i].Text = (int.Parse(clblNum[i].Text) - 1).ToString();
                            con.Text = clblNum[i].Text;
                            foodSum--;
                            pCart_sum.Text = String.Format("{0}가지 {1}개", foodSelect, foodSum);
                            foodPrice -= fPrice[i];
                            pCart_price.Text = String.Format("{0}원", foodPrice);
                            clblSum[i].Text = String.Format("{0}원", fPrice[i] * int.Parse(clblNum[i].Text));
                        }

                        if (con.Name == String.Format("cBMinus_{0}", i))
                        {
                            if (int.Parse(clblNum[i].Text) <= 1)
                                con.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Button plus = sender as Button;
            for (int i = 0; i < fId.Count; i++)
            {
                if (plus.Parent.Name.ToString() == cPanel[i].Name.ToString())
                {
                    foreach (Control con in cPanel[i].Controls)
                    {
                        if (con.Name == String.Format("clblNum_{0}", i))
                        {
                            clblNum[i].Text = (int.Parse(clblNum[i].Text) + 1).ToString();
                            con.Text = clblNum[i].Text;
                            foodSum++;
                            pCart_sum.Text = String.Format("{0}가지 {1}개", foodSelect, foodSum);
                            foodPrice += fPrice[i];
                            pCart_price.Text = String.Format("{0}원", foodPrice);
                            clblSum[i].Text = String.Format("{0}원", fPrice[i] * int.Parse(clblNum[i].Text));
                        }
                        
                        if (con.Name == String.Format("cBMinus_{0}", i))
                        {
                            if (int.Parse(clblNum[i].Text) > 1)
                                con.Enabled = true;
                        }
                    }
                }
            }
        }

        private void pCart_order_Click(object sender, EventArgs e)
        {
            Button order = sender as Button;
            DialogResult yes = MessageBox.Show("이대로 주문하시겠습니까??", "메뉴 주문", MessageBoxButtons.YesNo);
            if(yes == DialogResult.Yes)
            {
                if(pCart_list.Controls.Count < 1)
                {
                    MessageBox.Show("상품을 선택 후 주문해주세요.", "상품 없음", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    panel_cart.Visible = false;
                }
                else
                {
                    /* 엑세스 전용 코드 */
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    // 여기에서 db 반복문 입력
                    for (int i = 0; i < fPrice.Count; i++)
                    {
                        int cnt = Convert.ToInt32(this.clblNum[i].Text);
                        string sql = "INSERT INTO [order]([order_table], [order_prod], [order_count], [order_date], [order_total_price]) VALUES (";
                        sql += 1 + ",'" + fId[i] + "' ," + cnt + ", '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' , " + cnt * fPrice[i] + ")";
                        var Comm = new OleDbCommand(sql, Conn);
                        var result = Comm.ExecuteNonQuery();
                    }
                    
                    // --------------------------------------------------------

                    pCart_list.Controls.Clear();
                    fId.Clear();
                    fName.Clear();
                    fPrice.Clear();
                    cPanel.Clear();
                    clblName.Clear();
                    clblNum.Clear();
                    clblSum.Clear();
                    cBDelete.Clear();
                    cBMinus.Clear();
                    cBPlus.Clear();
                    foodSelect = 0;
                    foodSum = 0;
                    foodPrice = 0;
                    pCart_sum.Text = String.Format("0가지 0개");
                    pCart_price.Text = String.Format("0원");
                    pCart_sum.Visible = false;
                    pCart_price.Visible = false;

                    DialogResult ok = MessageBox.Show("주문이 완료되었습니다.", "주문 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (ok == DialogResult.OK)
                    {
                        panel_cart.Visible = false;
                        btn_cart.Checked = false;
                    }
                    
                }
            }

        }
        
    }
}
