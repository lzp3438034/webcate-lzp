using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WebCate.Message;

namespace WebCate
{
    public partial class MainForm : UIForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.penlHY.AutoScroll = true;
            this.uiPanelMsg.AutoScroll = true;
        }

        private void uiPanel20_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("OK");
        }

        protected override void OnLoad(EventArgs e)
        {
           
            for (int i = 0; i < 20; i++)
            {
                UserControl1 m = new UserControl1();
                m.SetName("帅哥" + i.ToString());
                this.penlHY.Controls.Add(m);
                m.Dock = DockStyle.Top;
                m.CLick += M_Click;
            }
  
        }

        private void M_Click(object sender, EventArgs e)
        {
            this.uiPanelMsg.Controls.Clear();
            this.txtName.Text = sender.ToString();
        }

        #region 窗体移动
        Point mPoint;

        private void uiPanel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        private void uiPanel4_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void uiPanel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void uiPanel5_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void uiPanel12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 当前消息气泡起始位置
        /// </summary>
        private int top = 10;

        /// <summary>
        /// 当前消息气泡高度
        /// </summary>
        private int height = 0;
        List<UIPanel> p = new List<UIPanel>() { 
      
        };

        int i = 0;
        private void uiButton1_Click(object sender, EventArgs e)
        {
            string content = i.ToString() + txtSendMsg.Text;
            MsgUserControl1 msgUserControl1 = new MsgUserControl1();
            msgUserControl1.Name = i.ToString();
            msgUserControl1.SetMsg(content);
            msgUserControl1.Dock = DockStyle.Bottom;
            uiPanelMsg.Controls.Add(msgUserControl1);
            //if (i < 6)
            //{
            //    msgUserControl1.Dock = DockStyle.Fill;
            //    p[i].Controls.Add(msgUserControl1);
            //    p[i].Height = msgUserControl1.Height;
            //}
            //else
            //{
            //    height = height + msgUserControl1.Height;
            //    msgUserControl1.Focus();
            //    msgUserControl1.Select();
            //    uiPanelMsg.ScrollControlIntoView(msgUserControl1);
            //    uiPanelMsg.VerticalScroll.Value = uiPanelMsg.VerticalScroll.Maximum;
            //}
            height = height + msgUserControl1.Height;
            msgUserControl1.Focus();
            msgUserControl1.Select();
            uiPanelMsg.ScrollControlIntoView(msgUserControl1);
            uiPanelMsg.VerticalScroll.Value = uiPanelMsg.VerticalScroll.Maximum;
            this.txtSendMsg.Text = ""; 
            i++;
        }


        private void uiPanelMsg_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void uiImageButton6_Click(object sender, EventArgs e)
        {
          //  this.penBQB.Visible = true;
        }

        private void txtSendMsg_Click(object sender, EventArgs e)
        {
            //this.penBQB.Visible = false;
        }

        private void uiPanelMsg_Click(object sender, EventArgs e)
        {
            //this.penBQB.Visible = false;
        }

        private void penlHY_Click(object sender, EventArgs e)
        {
           // this.penBQB.Visible = false;
        }
    }
}
