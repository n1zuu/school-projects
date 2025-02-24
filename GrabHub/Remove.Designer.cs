namespace GrabHub
{
    partial class Remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove));
            removeItemPanel = new Panel();
            viewItemPanel = new Panel();
            viewItemMsgLbl = new Label();
            returnBtnRmveItemPnl = new Button();
            applyItemBtn = new Button();
            removalItemBtn = new Button();
            removalItemsList = new CheckedListBox();
            removalMsgLbl = new Label();
            returnBtnViewItemPnl = new Button();
            removeItemPanel.SuspendLayout();
            viewItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // removeItemPanel
            // 
            removeItemPanel.Controls.Add(returnBtnViewItemPnl);
            removeItemPanel.Controls.Add(viewItemPanel);
            removeItemPanel.Controls.Add(returnBtnRmveItemPnl);
            removeItemPanel.Controls.Add(applyItemBtn);
            removeItemPanel.Controls.Add(removalItemBtn);
            removeItemPanel.Controls.Add(removalItemsList);
            removeItemPanel.Controls.Add(removalMsgLbl);
            removeItemPanel.ForeColor = SystemColors.Control;
            removeItemPanel.Location = new Point(26, 12);
            removeItemPanel.Name = "removeItemPanel";
            removeItemPanel.Size = new Size(762, 461);
            removeItemPanel.TabIndex = 11;
            // 
            // viewItemPanel
            // 
            viewItemPanel.Controls.Add(viewItemMsgLbl);
            viewItemPanel.Location = new Point(369, 90);
            viewItemPanel.Name = "viewItemPanel";
            viewItemPanel.Size = new Size(744, 471);
            viewItemPanel.TabIndex = 11;
            // 
            // viewItemMsgLbl
            // 
            viewItemMsgLbl.AutoSize = true;
            viewItemMsgLbl.BackColor = Color.Transparent;
            viewItemMsgLbl.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewItemMsgLbl.ForeColor = SystemColors.Control;
            viewItemMsgLbl.Location = new Point(11, 168);
            viewItemMsgLbl.Name = "viewItemMsgLbl";
            viewItemMsgLbl.Size = new Size(381, 64);
            viewItemMsgLbl.TabIndex = 1;
            viewItemMsgLbl.Text = "Here’s your goodies! \r\nReady to check out or grab more!";
            // 
            // returnBtnRmveItemPnl
            // 
            returnBtnRmveItemPnl.BackColor = Color.Transparent;
            returnBtnRmveItemPnl.FlatStyle = FlatStyle.Popup;
            returnBtnRmveItemPnl.Image = (Image)resources.GetObject("returnBtnRmveItemPnl.Image");
            returnBtnRmveItemPnl.Location = new Point(638, 394);
            returnBtnRmveItemPnl.Name = "returnBtnRmveItemPnl";
            returnBtnRmveItemPnl.Size = new Size(65, 37);
            returnBtnRmveItemPnl.TabIndex = 12;
            returnBtnRmveItemPnl.UseVisualStyleBackColor = false;
            // 
            // applyItemBtn
            // 
            applyItemBtn.BackColor = Color.Transparent;
            applyItemBtn.FlatStyle = FlatStyle.Popup;
            applyItemBtn.ForeColor = SystemColors.Control;
            applyItemBtn.Location = new Point(525, 397);
            applyItemBtn.Name = "applyItemBtn";
            applyItemBtn.Size = new Size(78, 32);
            applyItemBtn.TabIndex = 9;
            applyItemBtn.Text = "Apply";
            applyItemBtn.UseVisualStyleBackColor = false;
            // 
            // removalItemBtn
            // 
            removalItemBtn.BackColor = Color.Transparent;
            removalItemBtn.FlatStyle = FlatStyle.Popup;
            removalItemBtn.ForeColor = SystemColors.Control;
            removalItemBtn.Location = new Point(425, 397);
            removalItemBtn.Name = "removalItemBtn";
            removalItemBtn.Size = new Size(78, 32);
            removalItemBtn.TabIndex = 14;
            removalItemBtn.Text = "Remove...";
            removalItemBtn.UseVisualStyleBackColor = false;
            // 
            // removalItemsList
            // 
            removalItemsList.BackColor = Color.FromArgb(30, 30, 30);
            removalItemsList.BorderStyle = BorderStyle.None;
            removalItemsList.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removalItemsList.ForeColor = Color.RosyBrown;
            removalItemsList.FormattingEnabled = true;
            removalItemsList.HorizontalScrollbar = true;
            removalItemsList.Location = new Point(423, 44);
            removalItemsList.Name = "removalItemsList";
            removalItemsList.Size = new Size(295, 210);
            removalItemsList.TabIndex = 13;
            // 
            // removalMsgLbl
            // 
            removalMsgLbl.AutoSize = true;
            removalMsgLbl.BackColor = Color.Transparent;
            removalMsgLbl.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removalMsgLbl.ForeColor = SystemColors.Control;
            removalMsgLbl.Location = new Point(12, 134);
            removalMsgLbl.Name = "removalMsgLbl";
            removalMsgLbl.Size = new Size(370, 64);
            removalMsgLbl.TabIndex = 0;
            removalMsgLbl.Text = "Still thinking about it?\r\nYou can always add it back later!";
            // 
            // returnBtnViewItemPnl
            // 
            returnBtnViewItemPnl.BackColor = Color.Transparent;
            returnBtnViewItemPnl.FlatStyle = FlatStyle.Popup;
            returnBtnViewItemPnl.Image = (Image)resources.GetObject("returnBtnViewItemPnl.Image");
            returnBtnViewItemPnl.Location = new Point(12, 397);
            returnBtnViewItemPnl.Name = "returnBtnViewItemPnl";
            returnBtnViewItemPnl.Size = new Size(65, 37);
            returnBtnViewItemPnl.TabIndex = 14;
            returnBtnViewItemPnl.UseVisualStyleBackColor = false;
            returnBtnViewItemPnl.Click += returnBtnViewItemPnl_Click;
            // 
            // Remove
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 489);
            Controls.Add(removeItemPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Remove";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remove";
            removeItemPanel.ResumeLayout(false);
            removeItemPanel.PerformLayout();
            viewItemPanel.ResumeLayout(false);
            viewItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel removeItemPanel;
        private Panel viewItemPanel;
        private Label viewItemMsgLbl;
        private Button returnBtnRmveItemPnl;
        private Button applyItemBtn;
        private Button removalItemBtn;
        private CheckedListBox removalItemsList;
        private Label removalMsgLbl;
        private Button returnBtnViewItemPnl;
    }
}