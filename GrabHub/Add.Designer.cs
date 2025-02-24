namespace GrabHub
{
    partial class Add
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
            itemsSectPanel = new Panel();
            bakedGoodsBtnLbl = new Label();
            bakedGoodsBtn = new Button();
            cannedGoodsBtnLbl = new Label();
            cannedGoodsBtn = new Button();
            dairyItemsBtnLbl = new Label();
            dairyItemsBtn = new Button();
            itemsPanelMsg = new Label();
            beverageBtnLbl = new Label();
            beverageBtn = new Button();
            fruitVegeBtnLbl = new Label();
            fruitVegeBtn = new Button();
            returnActionPnlBtn = new Button();
            itemsSectPanel.SuspendLayout();
            SuspendLayout();
            // 
            // itemsSectPanel
            // 
            itemsSectPanel.Controls.Add(bakedGoodsBtnLbl);
            itemsSectPanel.Controls.Add(bakedGoodsBtn);
            itemsSectPanel.Controls.Add(cannedGoodsBtnLbl);
            itemsSectPanel.Controls.Add(cannedGoodsBtn);
            itemsSectPanel.Controls.Add(dairyItemsBtnLbl);
            itemsSectPanel.Controls.Add(dairyItemsBtn);
            itemsSectPanel.Controls.Add(itemsPanelMsg);
            itemsSectPanel.Controls.Add(beverageBtnLbl);
            itemsSectPanel.Controls.Add(beverageBtn);
            itemsSectPanel.Controls.Add(fruitVegeBtnLbl);
            itemsSectPanel.Controls.Add(fruitVegeBtn);
            itemsSectPanel.Controls.Add(returnActionPnlBtn);
            itemsSectPanel.Dock = DockStyle.Fill;
            itemsSectPanel.Location = new Point(0, 0);
            itemsSectPanel.Name = "itemsSectPanel";
            itemsSectPanel.Size = new Size(800, 450);
            itemsSectPanel.TabIndex = 3;
            itemsSectPanel.Paint += itemsSectPanel_Paint;
            // 
            // bakedGoodsBtnLbl
            // 
            bakedGoodsBtnLbl.AutoSize = true;
            bakedGoodsBtnLbl.ForeColor = SystemColors.Control;
            bakedGoodsBtnLbl.Location = new Point(562, 297);
            bakedGoodsBtnLbl.Name = "bakedGoodsBtnLbl";
            bakedGoodsBtnLbl.Size = new Size(90, 17);
            bakedGoodsBtnLbl.TabIndex = 21;
            bakedGoodsBtnLbl.Text = "Baked Goods ";
            // 
            // bakedGoodsBtn
            // 
            bakedGoodsBtn.BackColor = Color.Transparent;
            bakedGoodsBtn.FlatStyle = FlatStyle.Popup;
            bakedGoodsBtn.Image = Properties.Resources.food__1_;
            bakedGoodsBtn.Location = new Point(552, 197);
            bakedGoodsBtn.Name = "bakedGoodsBtn";
            bakedGoodsBtn.Size = new Size(89, 96);
            bakedGoodsBtn.TabIndex = 20;
            bakedGoodsBtn.UseVisualStyleBackColor = false;
            // 
            // cannedGoodsBtnLbl
            // 
            cannedGoodsBtnLbl.AutoSize = true;
            cannedGoodsBtnLbl.ForeColor = SystemColors.Control;
            cannedGoodsBtnLbl.Location = new Point(608, 154);
            cannedGoodsBtnLbl.Name = "cannedGoodsBtnLbl";
            cannedGoodsBtnLbl.Size = new Size(95, 17);
            cannedGoodsBtnLbl.TabIndex = 19;
            cannedGoodsBtnLbl.Text = "Canned Goods";
            // 
            // cannedGoodsBtn
            // 
            cannedGoodsBtn.BackColor = Color.Transparent;
            cannedGoodsBtn.FlatStyle = FlatStyle.Popup;
            cannedGoodsBtn.Image = Properties.Resources.canned_food__1_;
            cannedGoodsBtn.Location = new Point(604, 54);
            cannedGoodsBtn.Name = "cannedGoodsBtn";
            cannedGoodsBtn.Size = new Size(89, 96);
            cannedGoodsBtn.TabIndex = 18;
            cannedGoodsBtn.UseVisualStyleBackColor = false;
            // 
            // dairyItemsBtnLbl
            // 
            dairyItemsBtnLbl.AutoSize = true;
            dairyItemsBtnLbl.ForeColor = SystemColors.Control;
            dairyItemsBtnLbl.Location = new Point(495, 154);
            dairyItemsBtnLbl.Name = "dairyItemsBtnLbl";
            dairyItemsBtnLbl.Size = new Size(73, 17);
            dairyItemsBtnLbl.TabIndex = 17;
            dairyItemsBtnLbl.Text = "Dairy Items";
            // 
            // dairyItemsBtn
            // 
            dairyItemsBtn.BackColor = Color.Transparent;
            dairyItemsBtn.FlatStyle = FlatStyle.Popup;
            dairyItemsBtn.Image = Properties.Resources.dairy_products__1_;
            dairyItemsBtn.Location = new Point(484, 54);
            dairyItemsBtn.Name = "dairyItemsBtn";
            dairyItemsBtn.Size = new Size(89, 96);
            dairyItemsBtn.TabIndex = 16;
            dairyItemsBtn.UseVisualStyleBackColor = false;
            dairyItemsBtn.Click += dairyItemsBtn_Click;
            // 
            // itemsPanelMsg
            // 
            itemsPanelMsg.AutoSize = true;
            itemsPanelMsg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemsPanelMsg.ForeColor = SystemColors.Control;
            itemsPanelMsg.Location = new Point(3, 178);
            itemsPanelMsg.Name = "itemsPanelMsg";
            itemsPanelMsg.Size = new Size(332, 64);
            itemsPanelMsg.TabIndex = 15;
            itemsPanelMsg.Text = "Ready to shop? \r\nGrab some tasty items now!";
            // 
            // beverageBtnLbl
            // 
            beverageBtnLbl.AutoSize = true;
            beverageBtnLbl.ForeColor = SystemColors.Control;
            beverageBtnLbl.Location = new Point(440, 297);
            beverageBtnLbl.Name = "beverageBtnLbl";
            beverageBtnLbl.Size = new Size(68, 17);
            beverageBtnLbl.TabIndex = 14;
            beverageBtnLbl.Text = "Beverages";
            // 
            // beverageBtn
            // 
            beverageBtn.BackColor = Color.Transparent;
            beverageBtn.FlatStyle = FlatStyle.Popup;
            beverageBtn.Image = Properties.Resources.drinks__1_;
            beverageBtn.Location = new Point(421, 197);
            beverageBtn.Name = "beverageBtn";
            beverageBtn.Size = new Size(89, 96);
            beverageBtn.TabIndex = 13;
            beverageBtn.UseVisualStyleBackColor = false;
            // 
            // fruitVegeBtnLbl
            // 
            fruitVegeBtnLbl.AutoSize = true;
            fruitVegeBtnLbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fruitVegeBtnLbl.ForeColor = SystemColors.Control;
            fruitVegeBtnLbl.Location = new Point(349, 154);
            fruitVegeBtnLbl.Name = "fruitVegeBtnLbl";
            fruitVegeBtnLbl.Size = new Size(118, 13);
            fruitVegeBtnLbl.TabIndex = 12;
            fruitVegeBtnLbl.Text = "Fruits and Vegetables";
            // 
            // fruitVegeBtn
            // 
            fruitVegeBtn.BackColor = Color.Transparent;
            fruitVegeBtn.FlatStyle = FlatStyle.Popup;
            fruitVegeBtn.Image = Properties.Resources.healthy_food__2_;
            fruitVegeBtn.Location = new Point(359, 54);
            fruitVegeBtn.Name = "fruitVegeBtn";
            fruitVegeBtn.Size = new Size(89, 96);
            fruitVegeBtn.TabIndex = 11;
            fruitVegeBtn.UseVisualStyleBackColor = false;
            fruitVegeBtn.Click += fruitVegeBtn_Click;
            // 
            // returnActionPnlBtn
            // 
            returnActionPnlBtn.BackColor = Color.Transparent;
            returnActionPnlBtn.FlatStyle = FlatStyle.Popup;
            returnActionPnlBtn.Image = Properties.Resources.left_arrow;
            returnActionPnlBtn.Location = new Point(616, 398);
            returnActionPnlBtn.Name = "returnActionPnlBtn";
            returnActionPnlBtn.Size = new Size(65, 37);
            returnActionPnlBtn.TabIndex = 10;
            returnActionPnlBtn.UseVisualStyleBackColor = false;
            returnActionPnlBtn.Click += returnActionPnlBtn_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(itemsSectPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add";
            itemsSectPanel.ResumeLayout(false);
            itemsSectPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel itemsSectPanel;
        private Label bakedGoodsBtnLbl;
        private Button bakedGoodsBtn;
        private Label cannedGoodsBtnLbl;
        private Button cannedGoodsBtn;
        private Label dairyItemsBtnLbl;
        private Button dairyItemsBtn;
        private Label itemsPanelMsg;
        private Label beverageBtnLbl;
        private Button beverageBtn;
        private Label fruitVegeBtnLbl;
        private Button fruitVegeBtn;
        private Button returnActionPnlBtn;
    }
}