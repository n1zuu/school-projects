namespace GrabHub
{
    partial class Grab1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            mainBtn = new Button();
            msgLbl = new Label();
            welcomeLbl = new Label();
            actionPanel = new Panel();
            returnMainPnlBtn = new Button();
            checkoutBtnLbl = new Label();
            checkoutBtn = new Button();
            viewBtn = new Button();
            viewBtnLbl = new Label();
            removeBtnLbl = new Label();
            removeBtn = new Button();
            addBtnLbl = new Label();
            addBtn = new Button();
            actionPanelMsg = new Label();
            remveItemPnlPriceIcon = new Panel();
            mainPanel.SuspendLayout();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(mainBtn);
            mainPanel.Controls.Add(msgLbl);
            mainPanel.Controls.Add(welcomeLbl);
            mainPanel.Location = new Point(62, 43);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(668, 381);
            mainPanel.TabIndex = 0;
            // 
            // mainBtn
            // 
            mainBtn.BackColor = Color.Transparent;
            mainBtn.FlatStyle = FlatStyle.Popup;
            mainBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainBtn.ForeColor = SystemColors.Control;
            mainBtn.Location = new Point(203, 260);
            mainBtn.Name = "mainBtn";
            mainBtn.Size = new Size(284, 48);
            mainBtn.TabIndex = 2;
            mainBtn.Text = "Grab Now!";
            mainBtn.UseVisualStyleBackColor = false;
            mainBtn.Click += mainBtn_Click;
            mainBtn.Paint += mainBtn_Paint;
            // 
            // msgLbl
            // 
            msgLbl.AutoSize = true;
            msgLbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msgLbl.ForeColor = SystemColors.Control;
            msgLbl.Location = new Point(171, 125);
            msgLbl.Name = "msgLbl";
            msgLbl.Size = new Size(350, 45);
            msgLbl.TabIndex = 1;
            msgLbl.Text = "Welcome to Grab Hub! We're so excited to serve you with quick, \r\n       convenient, and delightful experiences. Your satisfaction \r\n                            is our passion—enjoy the ride! ";
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.ForeColor = SystemColors.Control;
            welcomeLbl.Location = new Point(140, 37);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(420, 50);
            welcomeLbl.TabIndex = 0;
            welcomeLbl.Text = "Welcome to Grab Hub!";
            // 
            // actionPanel
            // 
            actionPanel.Controls.Add(returnMainPnlBtn);
            actionPanel.Controls.Add(checkoutBtnLbl);
            actionPanel.Controls.Add(checkoutBtn);
            actionPanel.Controls.Add(viewBtn);
            actionPanel.Controls.Add(viewBtnLbl);
            actionPanel.Controls.Add(removeBtnLbl);
            actionPanel.Controls.Add(removeBtn);
            actionPanel.Controls.Add(addBtnLbl);
            actionPanel.Controls.Add(addBtn);
            actionPanel.Controls.Add(actionPanelMsg);
            actionPanel.Location = new Point(62, 46);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(703, 461);
            actionPanel.TabIndex = 1;
            actionPanel.Visible = false;
            actionPanel.Paint += actionPanel_Paint;
            // 
            // returnMainPnlBtn
            // 
            returnMainPnlBtn.BackColor = Color.Transparent;
            returnMainPnlBtn.FlatStyle = FlatStyle.Popup;
            returnMainPnlBtn.Image = Properties.Resources.left_arrow;
            returnMainPnlBtn.Location = new Point(603, 398);
            returnMainPnlBtn.Name = "returnMainPnlBtn";
            returnMainPnlBtn.Size = new Size(65, 37);
            returnMainPnlBtn.TabIndex = 9;
            returnMainPnlBtn.UseVisualStyleBackColor = false;
            returnMainPnlBtn.Click += returnMainBtn_Click;
            // 
            // checkoutBtnLbl
            // 
            checkoutBtnLbl.AutoSize = true;
            checkoutBtnLbl.ForeColor = SystemColors.Control;
            checkoutBtnLbl.Location = new Point(552, 333);
            checkoutBtnLbl.Name = "checkoutBtnLbl";
            checkoutBtnLbl.Size = new Size(61, 17);
            checkoutBtnLbl.TabIndex = 8;
            checkoutBtnLbl.Text = "Checkout";
            // 
            // checkoutBtn
            // 
            checkoutBtn.BackColor = Color.Transparent;
            checkoutBtn.FlatStyle = FlatStyle.Popup;
            checkoutBtn.Image = Properties.Resources.shopping_bag__6_;
            checkoutBtn.Location = new Point(539, 233);
            checkoutBtn.Name = "checkoutBtn";
            checkoutBtn.Size = new Size(89, 96);
            checkoutBtn.TabIndex = 7;
            checkoutBtn.UseVisualStyleBackColor = false;
            checkoutBtn.Click += checkoutBtn_Click;
            // 
            // viewBtn
            // 
            viewBtn.BackColor = Color.Transparent;
            viewBtn.FlatStyle = FlatStyle.Popup;
            viewBtn.Image = Properties.Resources.shopping_bag__7_;
            viewBtn.Location = new Point(408, 233);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(89, 96);
            viewBtn.TabIndex = 6;
            viewBtn.UseVisualStyleBackColor = false;
            viewBtn.Click += viewBtn_Click;
            // 
            // viewBtnLbl
            // 
            viewBtnLbl.AutoSize = true;
            viewBtnLbl.ForeColor = SystemColors.Control;
            viewBtnLbl.Location = new Point(435, 333);
            viewBtnLbl.Name = "viewBtnLbl";
            viewBtnLbl.Size = new Size(35, 17);
            viewBtnLbl.TabIndex = 5;
            viewBtnLbl.Text = "View";
            viewBtnLbl.Click += label1_Click_1;
            // 
            // removeBtnLbl
            // 
            removeBtnLbl.AutoSize = true;
            removeBtnLbl.ForeColor = SystemColors.Control;
            removeBtnLbl.Location = new Point(560, 194);
            removeBtnLbl.Name = "removeBtnLbl";
            removeBtnLbl.Size = new Size(55, 17);
            removeBtnLbl.TabIndex = 4;
            removeBtnLbl.Text = "Remove";
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.Transparent;
            removeBtn.FlatStyle = FlatStyle.Popup;
            removeBtn.Image = Properties.Resources.minus;
            removeBtn.Location = new Point(539, 94);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(89, 96);
            removeBtn.TabIndex = 3;
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // addBtnLbl
            // 
            addBtnLbl.AutoSize = true;
            addBtnLbl.ForeColor = SystemColors.Control;
            addBtnLbl.Location = new Point(438, 194);
            addBtnLbl.Name = "addBtnLbl";
            addBtnLbl.Size = new Size(32, 17);
            addBtnLbl.TabIndex = 2;
            addBtnLbl.Text = "Add";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Transparent;
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.Image = Properties.Resources.add_to_cart__3_;
            addBtn.Location = new Point(408, 91);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(89, 96);
            addBtn.TabIndex = 1;
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click_1;
            // 
            // actionPanelMsg
            // 
            actionPanelMsg.AutoSize = true;
            actionPanelMsg.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            actionPanelMsg.ForeColor = SystemColors.Control;
            actionPanelMsg.Location = new Point(38, 175);
            actionPanelMsg.Name = "actionPanelMsg";
            actionPanelMsg.Size = new Size(299, 80);
            actionPanelMsg.TabIndex = 0;
            actionPanelMsg.Text = "What would you like\r\nto do today?";
            actionPanelMsg.Click += label1_Click;
            // 
            // remveItemPnlPriceIcon
            // 
            remveItemPnlPriceIcon.Location = new Point(0, 0);
            remveItemPnlPriceIcon.Name = "remveItemPnlPriceIcon";
            remveItemPnlPriceIcon.Size = new Size(200, 100);
            remveItemPnlPriceIcon.TabIndex = 0;
            // 
            // Grab1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 510);
            Controls.Add(actionPanel);
            Controls.Add(mainPanel);
            Name = "Grab1";
            Text = "Grab Hub";
            Load += Grab1_Load_1;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            actionPanel.ResumeLayout(false);
            actionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label welcomeLbl;
        private Button mainBtn;
        private Label msgLbl;
        private Panel actionPanel;
        private Label actionPanelMsg;
        private Label addBtnLbl;
        private Button addBtn;
        private Button viewBtn;
        private Label viewBtnLbl;
        private Label removeBtnLbl;
        private Button removeBtn;
        private Label checkoutBtnLbl;
        private Button checkoutBtn;
        private Button returnMainPnlBtn;
        private NumericUpDown numericUpDown2;
        private Panel panel2;
        private Panel remveItemPnlPriceIcon;
    }
}
