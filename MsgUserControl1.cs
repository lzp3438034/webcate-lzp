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

namespace WebCate
{
    public partial class MsgUserControl1 : UIUserControl
    {
        public MsgUserControl1()
        {
            InitializeComponent();
        }

        private void uiPanel1_MouseHover(object sender, EventArgs e)
        {
            //SerHobe();
        }

        private void uiPanel1_MouseLeave(object sender, EventArgs e)
        {
           // SetLeave();
        }

        private void SetLeave() {
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));

            
            //this.txtMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
        }
        private void SerHobe()
        {
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));

         
          //  this.txtMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
           // SetLeave();
        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
           // SerHobe();
        }

        private void txtMsg_MouseHover(object sender, EventArgs e)
        {
           // SerHobe();
        }

        private void txtMsg_MouseLeave(object sender, EventArgs e)
        {
          //  SetLeave();
        }

        private void txtimg_MouseHover(object sender, EventArgs e)
        {
           // SerHobe();
        }

        private void txtimg_MouseLeave(object sender, EventArgs e)
        {
            //SetLeave();
        }


        public void SetMsg(string msg)
        {
            this.txtMsg.Text = msg;
            var heg= (this.txtMsg.Text.Length / 50 + 1) * 30;
            if (heg <= 46)
            {
                this.uiPanel2.Height = 46;
                this.Height = 70;
                return;
            }
            this.uiPanel2.Height = heg;
            this.Height = heg;
        }

        private void txtMsg_MouseHover_1(object sender, EventArgs e)
        {
            this.txtMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(240)))), ((int)(((byte)(110)))));
        }

        private void txtMsg_MouseLeave_1(object sender, EventArgs e)
        {
            this.txtMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(236)))), ((int)(((byte)(105)))));
        }
    }
}
