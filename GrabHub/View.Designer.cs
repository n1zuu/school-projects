namespace GrabHub
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            viewItemPanel = new Panel();
            returnBtnViewItemPnl = new Button();
            viewItemList = new ListBox();
            viewItemMsgLbl = new Label();
            viewItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // viewItemPanel
            // 
            viewItemPanel.Controls.Add(returnBtnViewItemPnl);
            viewItemPanel.Controls.Add(viewItemList);
            viewItemPanel.Controls.Add(viewItemMsgLbl);
            viewItemPanel.Location = new Point(28, -10);
            viewItemPanel.Name = "viewItemPanel";
            viewItemPanel.Size = new Size(744, 471);
            viewItemPanel.TabIndex = 12;
            viewItemPanel.Visible = false;
            // 
            // returnBtnViewItemPnl
            // 
            returnBtnViewItemPnl.BackColor = Color.Transparent;
            returnBtnViewItemPnl.FlatStyle = FlatStyle.Popup;
            returnBtnViewItemPnl.Image = (Image)resources.GetObject("returnBtnViewItemPnl.Image");
            returnBtnViewItemPnl.Location = new Point(635, 413);
            returnBtnViewItemPnl.Name = "returnBtnViewItemPnl";
            returnBtnViewItemPnl.Size = new Size(65, 37);
            returnBtnViewItemPnl.TabIndex = 13;
            returnBtnViewItemPnl.UseVisualStyleBackColor = false;
            // 
            // viewItemList
            // 
            viewItemList.BackColor = Color.FromArgb(30, 30, 30);
            viewItemList.BorderStyle = BorderStyle.None;
            viewItemList.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewItemList.ForeColor = Color.RosyBrown;
            viewItemList.FormattingEnabled = true;
            viewItemList.HorizontalScrollbar = true;
            viewItemList.ItemHeight = 25;
            viewItemList.Location = new Point(435, 35);
            viewItemList.Name = "viewItemList";
            viewItemList.Size = new Size(306, 275);
            viewItemList.TabIndex = 2;
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
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(viewItemPanel);
            Name = "View";
            Text = "View";
            viewItemPanel.ResumeLayout(false);
            viewItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel viewItemPanel;
        private Button returnBtnViewItemPnl;
        private ListBox viewItemList;
        private Label viewItemMsgLbl;
    }
}