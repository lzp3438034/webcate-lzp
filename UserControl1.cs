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
    public partial class UserControl1 : UIUserControl
    {
        public  EventHandler CLick;
        public string ID { get; set; }

        public UserControl1()
        {
            InitializeComponent();
           
        }

        private void uiPanel1_MouseHover(object sender, EventArgs e)
        {
            SerHobe();
        }

        private void uiPanel1_MouseLeave(object sender, EventArgs e)
        {
            SetLeave();
        }

        private void SetLeave() {
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));

            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
        }
        private void SerHobe()
        {
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));

            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.txtMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            SetLeave();
        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            SerHobe();
        }

        private void txtMsg_MouseHover(object sender, EventArgs e)
        {
            SerHobe();
        }

        private void txtMsg_MouseLeave(object sender, EventArgs e)
        {
            SetLeave();
        }

        private void txtimg_MouseHover(object sender, EventArgs e)
        {
            SerHobe();
        }

        private void txtimg_MouseLeave(object sender, EventArgs e)
        {
            SetLeave();
        }

        public void SetName(string Name) {

            this.txtName.Text = Name;
        }

        private void txtimg_Click(object sender, EventArgs e)
        {
            this.CLick(this.txtName.Text, e);
        }
    }
}
