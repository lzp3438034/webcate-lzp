
namespace WebCate
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtimg = new Sunny.UI.UIImageButton();
            this.txtName = new Sunny.UI.UILabel();
            this.txtMsg = new Sunny.UI.UILabel();
            this.txtTime = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            ((System.ComponentModel.ISupportInitialize)(this.txtimg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtimg
            // 
            this.txtimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtimg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtimg.Image = global::WebCate.Properties.Resources.touxiang;
            this.txtimg.Location = new System.Drawing.Point(14, 11);
            this.txtimg.Name = "txtimg";
            this.txtimg.Size = new System.Drawing.Size(50, 50);
            this.txtimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtimg.Style = Sunny.UI.UIStyle.Custom;
            this.txtimg.TabIndex = 0;
            this.txtimg.TabStop = false;
            this.txtimg.Text = null;
            this.txtimg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtimg.Click += new System.EventHandler(this.txtimg_Click);
            this.txtimg.MouseLeave += new System.EventHandler(this.txtimg_MouseLeave);
            this.txtimg.MouseHover += new System.EventHandler(this.txtimg_MouseHover);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(91, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 36);
            this.txtName.Style = Sunny.UI.UIStyle.Custom;
            this.txtName.TabIndex = 1;
            this.txtName.Text = "帅哥哥";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtName.MouseLeave += new System.EventHandler(this.txtName_MouseLeave);
            this.txtName.MouseHover += new System.EventHandler(this.txtName_MouseHover);
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMsg.Location = new System.Drawing.Point(92, 47);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(225, 32);
            this.txtMsg.Style = Sunny.UI.UIStyle.Custom;
            this.txtMsg.TabIndex = 2;
            this.txtMsg.Text = "帅哥哥";
            this.txtMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMsg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtMsg.MouseLeave += new System.EventHandler(this.txtMsg_MouseLeave);
            this.txtMsg.MouseHover += new System.EventHandler(this.txtMsg_MouseHover);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime.Location = new System.Drawing.Point(254, 11);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(61, 32);
            this.txtTime.Style = Sunny.UI.UIStyle.Custom;
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "17:22";
            this.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.uiPanel1.Size = new System.Drawing.Size(320, 80);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiPanel1.MouseLeave += new System.EventHandler(this.uiPanel1_MouseLeave);
            this.uiPanel1.MouseHover += new System.EventHandler(this.uiPanel1_MouseHover);
            // 
            // UserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtimg);
            this.Controls.Add(this.uiPanel1);
            this.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Name = "UserControl1";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Size = new System.Drawing.Size(320, 80);
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            ((System.ComponentModel.ISupportInitialize)(this.txtimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIImageButton txtimg;
        private Sunny.UI.UILabel txtName;
        private Sunny.UI.UILabel txtMsg;
        private Sunny.UI.UILabel txtTime;
        private Sunny.UI.UIPanel uiPanel1;
    }
}
