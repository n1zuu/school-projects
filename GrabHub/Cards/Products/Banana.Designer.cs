namespace GrabHub.Cards
{
    partial class Banana
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banana));
            cancelItemPanel = new Panel();
            PriceIconCnclItmePnl = new Panel();
            backBtnRmveItemPnl = new Button();
            cancelItemBtnCnclItemPnl = new Button();
            qtyDisplayCnclItemPnl = new Label();
            qtyLblCnclItmePnl = new Label();
            cancelPriceLbl = new Label();
            cancelItemLblCnclItemPnl = new Label();
            cancelPic = new PictureBox();
            cancelItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cancelPic).BeginInit();
            SuspendLayout();
            // 
            // cancelItemPanel
            // 
            cancelItemPanel.BackColor = Color.FromArgb(64, 64, 64);
            cancelItemPanel.Controls.Add(PriceIconCnclItmePnl);
            cancelItemPanel.Controls.Add(backBtnRmveItemPnl);
            cancelItemPanel.Controls.Add(cancelItemBtnCnclItemPnl);
            cancelItemPanel.Controls.Add(qtyDisplayCnclItemPnl);
            cancelItemPanel.Controls.Add(qtyLblCnclItmePnl);
            cancelItemPanel.Controls.Add(cancelPriceLbl);
            cancelItemPanel.Controls.Add(cancelItemLblCnclItemPnl);
            cancelItemPanel.Controls.Add(cancelPic);
            cancelItemPanel.Dock = DockStyle.Fill;
            cancelItemPanel.Location = new Point(0, 0);
            cancelItemPanel.Name = "cancelItemPanel";
            cancelItemPanel.Size = new Size(509, 368);
            cancelItemPanel.TabIndex = 10;
            cancelItemPanel.Visible = false;
            // 
            // PriceIconCnclItmePnl
            // 
            PriceIconCnclItmePnl.BackColor = Color.Transparent;
            PriceIconCnclItmePnl.BackgroundImage = (Image)resources.GetObject("PriceIconCnclItmePnl.BackgroundImage");
            PriceIconCnclItmePnl.BackgroundImageLayout = ImageLayout.Center;
            PriceIconCnclItmePnl.Location = new Point(282, 78);
            PriceIconCnclItmePnl.Name = "PriceIconCnclItmePnl";
            PriceIconCnclItmePnl.Size = new Size(79, 85);
            PriceIconCnclItmePnl.TabIndex = 9;
            // 
            // backBtnRmveItemPnl
            // 
            backBtnRmveItemPnl.BackColor = Color.Transparent;
            backBtnRmveItemPnl.FlatStyle = FlatStyle.Popup;
            backBtnRmveItemPnl.ForeColor = SystemColors.Control;
            backBtnRmveItemPnl.Location = new Point(395, 262);
            backBtnRmveItemPnl.Name = "backBtnRmveItemPnl";
            backBtnRmveItemPnl.Size = new Size(78, 32);
            backBtnRmveItemPnl.TabIndex = 7;
            backBtnRmveItemPnl.Text = "Back";
            backBtnRmveItemPnl.UseVisualStyleBackColor = false;
            // 
            // cancelItemBtnCnclItemPnl
            // 
            cancelItemBtnCnclItemPnl.BackColor = Color.Transparent;
            cancelItemBtnCnclItemPnl.FlatStyle = FlatStyle.Popup;
            cancelItemBtnCnclItemPnl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelItemBtnCnclItemPnl.ForeColor = SystemColors.Control;
            cancelItemBtnCnclItemPnl.Location = new Point(284, 262);
            cancelItemBtnCnclItemPnl.Name = "cancelItemBtnCnclItemPnl";
            cancelItemBtnCnclItemPnl.Size = new Size(99, 32);
            cancelItemBtnCnclItemPnl.TabIndex = 6;
            cancelItemBtnCnclItemPnl.Text = "Cancel Item...";
            cancelItemBtnCnclItemPnl.UseVisualStyleBackColor = false;
            // 
            // qtyDisplayCnclItemPnl
            // 
            qtyDisplayCnclItemPnl.AutoSize = true;
            qtyDisplayCnclItemPnl.BackColor = Color.Transparent;
            qtyDisplayCnclItemPnl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qtyDisplayCnclItemPnl.ForeColor = SystemColors.Control;
            qtyDisplayCnclItemPnl.Location = new Point(360, 197);
            qtyDisplayCnclItemPnl.Name = "qtyDisplayCnclItemPnl";
            qtyDisplayCnclItemPnl.Size = new Size(19, 21);
            qtyDisplayCnclItemPnl.TabIndex = 8;
            qtyDisplayCnclItemPnl.Text = "0";
            // 
            // qtyLblCnclItmePnl
            // 
            qtyLblCnclItmePnl.AutoSize = true;
            qtyLblCnclItmePnl.BackColor = Color.Transparent;
            qtyLblCnclItmePnl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qtyLblCnclItmePnl.ForeColor = SystemColors.Control;
            qtyLblCnclItmePnl.Location = new Point(284, 197);
            qtyLblCnclItmePnl.Name = "qtyLblCnclItmePnl";
            qtyLblCnclItmePnl.Size = new Size(76, 21);
            qtyLblCnclItmePnl.TabIndex = 5;
            qtyLblCnclItmePnl.Text = "Quantity:";
            // 
            // cancelPriceLbl
            // 
            cancelPriceLbl.AutoSize = true;
            cancelPriceLbl.BackColor = Color.Transparent;
            cancelPriceLbl.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelPriceLbl.ForeColor = SystemColors.Control;
            cancelPriceLbl.Location = new Point(357, 111);
            cancelPriceLbl.Name = "cancelPriceLbl";
            cancelPriceLbl.Size = new Size(59, 32);
            cancelPriceLbl.TabIndex = 2;
            cancelPriceLbl.Text = "0.75";
            // 
            // cancelItemLblCnclItemPnl
            // 
            cancelItemLblCnclItemPnl.AutoSize = true;
            cancelItemLblCnclItemPnl.BackColor = Color.Transparent;
            cancelItemLblCnclItemPnl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelItemLblCnclItemPnl.ForeColor = SystemColors.Control;
            cancelItemLblCnclItemPnl.Location = new Point(284, 31);
            cancelItemLblCnclItemPnl.Name = "cancelItemLblCnclItemPnl";
            cancelItemLblCnclItemPnl.Size = new Size(83, 30);
            cancelItemLblCnclItemPnl.TabIndex = 1;
            cancelItemLblCnclItemPnl.Text = "Banana";
            // 
            // cancelPic
            // 
            cancelPic.BackColor = Color.RosyBrown;
            cancelPic.Location = new Point(15, 19);
            cancelPic.Name = "cancelPic";
            cancelPic.Size = new Size(250, 329);
            cancelPic.TabIndex = 0;
            cancelPic.TabStop = false;
            // 
            // Banana
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(cancelItemPanel);
            Name = "Banana";
            Size = new Size(509, 368);
            cancelItemPanel.ResumeLayout(false);
            cancelItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cancelPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel cancelItemPanel;
        private Panel PriceIconCnclItmePnl;
        private Button backBtnRmveItemPnl;
        private Button cancelItemBtnCnclItemPnl;
        private Label qtyDisplayCnclItemPnl;
        private Label qtyLblCnclItmePnl;
        private Label cancelPriceLbl;
        private Label cancelItemLblCnclItemPnl;
        private PictureBox cancelPic;
    }
}
