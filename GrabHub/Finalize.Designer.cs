namespace GrabHub
{
    partial class Finalize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finalize));
            checkoutPanel = new Panel();
            returnCheckoutPnlBtn = new Button();
            paymentPanel = new Panel();
            cashLblPymtPnl = new Label();
            gcashLblPymtPnl = new Label();
            visaCardLblPymtPnl = new Label();
            masterCardLblPymtPnl = new Label();
            payHereLblPymtPnl = new Label();
            payBtnPymtPnl = new Button();
            cashBtnPymtPnl = new Button();
            gcashBtnPymtPnl = new Button();
            visaCardBtnPymtPnl = new Button();
            masterCardBtnPymtPnl = new Button();
            recieptPanel = new Panel();
            totalLbl = new Label();
            dateTimeLbl = new Label();
            discountLbl = new Label();
            purchaseItemsList = new ListBox();
            invoiceLbl = new Label();
            addressInvoiceLbl = new Label();
            gradhubInvoiceLbl = new Label();
            checkoutPanel.SuspendLayout();
            paymentPanel.SuspendLayout();
            recieptPanel.SuspendLayout();
            SuspendLayout();
            // 
            // checkoutPanel
            // 
            checkoutPanel.BackColor = Color.FromArgb(30, 30, 30);
            checkoutPanel.Controls.Add(returnCheckoutPnlBtn);
            checkoutPanel.Controls.Add(paymentPanel);
            checkoutPanel.Controls.Add(recieptPanel);
            checkoutPanel.Location = new Point(15, 12);
            checkoutPanel.Name = "checkoutPanel";
            checkoutPanel.Size = new Size(773, 491);
            checkoutPanel.TabIndex = 13;
            checkoutPanel.Paint += checkoutPanel_Paint;
            // 
            // returnCheckoutPnlBtn
            // 
            returnCheckoutPnlBtn.BackColor = Color.Transparent;
            returnCheckoutPnlBtn.FlatStyle = FlatStyle.Popup;
            returnCheckoutPnlBtn.Image = (Image)resources.GetObject("returnCheckoutPnlBtn.Image");
            returnCheckoutPnlBtn.Location = new Point(668, 431);
            returnCheckoutPnlBtn.Name = "returnCheckoutPnlBtn";
            returnCheckoutPnlBtn.Size = new Size(65, 37);
            returnCheckoutPnlBtn.TabIndex = 14;
            returnCheckoutPnlBtn.UseVisualStyleBackColor = false;
            returnCheckoutPnlBtn.Click += returnCheckoutPnlBtn_Click;
            // 
            // paymentPanel
            // 
            paymentPanel.Controls.Add(cashLblPymtPnl);
            paymentPanel.Controls.Add(gcashLblPymtPnl);
            paymentPanel.Controls.Add(visaCardLblPymtPnl);
            paymentPanel.Controls.Add(masterCardLblPymtPnl);
            paymentPanel.Controls.Add(payHereLblPymtPnl);
            paymentPanel.Controls.Add(payBtnPymtPnl);
            paymentPanel.Controls.Add(cashBtnPymtPnl);
            paymentPanel.Controls.Add(gcashBtnPymtPnl);
            paymentPanel.Controls.Add(visaCardBtnPymtPnl);
            paymentPanel.Controls.Add(masterCardBtnPymtPnl);
            paymentPanel.Location = new Point(27, 60);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(330, 382);
            paymentPanel.TabIndex = 15;
            // 
            // cashLblPymtPnl
            // 
            cashLblPymtPnl.AutoSize = true;
            cashLblPymtPnl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashLblPymtPnl.ForeColor = SystemColors.Control;
            cashLblPymtPnl.Location = new Point(217, 286);
            cashLblPymtPnl.Name = "cashLblPymtPnl";
            cashLblPymtPnl.Size = new Size(33, 15);
            cashLblPymtPnl.TabIndex = 23;
            cashLblPymtPnl.Text = "Cash";
            // 
            // gcashLblPymtPnl
            // 
            gcashLblPymtPnl.AutoSize = true;
            gcashLblPymtPnl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gcashLblPymtPnl.ForeColor = SystemColors.Control;
            gcashLblPymtPnl.Location = new Point(70, 286);
            gcashLblPymtPnl.Name = "gcashLblPymtPnl";
            gcashLblPymtPnl.Size = new Size(52, 15);
            gcashLblPymtPnl.TabIndex = 22;
            gcashLblPymtPnl.Text = "G - Cash";
            // 
            // visaCardLblPymtPnl
            // 
            visaCardLblPymtPnl.AutoSize = true;
            visaCardLblPymtPnl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            visaCardLblPymtPnl.ForeColor = SystemColors.Control;
            visaCardLblPymtPnl.Location = new Point(221, 159);
            visaCardLblPymtPnl.Name = "visaCardLblPymtPnl";
            visaCardLblPymtPnl.Size = new Size(28, 15);
            visaCardLblPymtPnl.TabIndex = 21;
            visaCardLblPymtPnl.Text = "Visa";
            // 
            // masterCardLblPymtPnl
            // 
            masterCardLblPymtPnl.AutoSize = true;
            masterCardLblPymtPnl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            masterCardLblPymtPnl.ForeColor = SystemColors.Control;
            masterCardLblPymtPnl.Location = new Point(65, 159);
            masterCardLblPymtPnl.Name = "masterCardLblPymtPnl";
            masterCardLblPymtPnl.Size = new Size(71, 15);
            masterCardLblPymtPnl.TabIndex = 20;
            masterCardLblPymtPnl.Text = "Master Card";
            // 
            // payHereLblPymtPnl
            // 
            payHereLblPymtPnl.AutoSize = true;
            payHereLblPymtPnl.BackColor = Color.Transparent;
            payHereLblPymtPnl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payHereLblPymtPnl.ForeColor = SystemColors.Control;
            payHereLblPymtPnl.Location = new Point(15, 7);
            payHereLblPymtPnl.Name = "payHereLblPymtPnl";
            payHereLblPymtPnl.Size = new Size(115, 32);
            payHereLblPymtPnl.TabIndex = 16;
            payHereLblPymtPnl.Text = "Pay Here";
            // 
            // payBtnPymtPnl
            // 
            payBtnPymtPnl.BackColor = Color.Transparent;
            payBtnPymtPnl.FlatStyle = FlatStyle.Popup;
            payBtnPymtPnl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payBtnPymtPnl.ForeColor = Color.White;
            payBtnPymtPnl.Location = new Point(48, 322);
            payBtnPymtPnl.Name = "payBtnPymtPnl";
            payBtnPymtPnl.Size = new Size(233, 51);
            payBtnPymtPnl.TabIndex = 19;
            payBtnPymtPnl.Text = "Pay";
            payBtnPymtPnl.UseVisualStyleBackColor = true;
            // 
            // cashBtnPymtPnl
            // 
            cashBtnPymtPnl.BackColor = Color.Transparent;
            cashBtnPymtPnl.FlatStyle = FlatStyle.Popup;
            cashBtnPymtPnl.Image = Properties.Resources.money;
            cashBtnPymtPnl.Location = new Point(168, 195);
            cashBtnPymtPnl.Name = "cashBtnPymtPnl";
            cashBtnPymtPnl.Size = new Size(119, 85);
            cashBtnPymtPnl.TabIndex = 18;
            cashBtnPymtPnl.UseVisualStyleBackColor = false;
            // 
            // gcashBtnPymtPnl
            // 
            gcashBtnPymtPnl.BackColor = Color.Transparent;
            gcashBtnPymtPnl.FlatStyle = FlatStyle.Popup;
            gcashBtnPymtPnl.Image = Properties.Resources.gcash_svgrepo_com;
            gcashBtnPymtPnl.Location = new Point(38, 195);
            gcashBtnPymtPnl.Name = "gcashBtnPymtPnl";
            gcashBtnPymtPnl.Size = new Size(119, 85);
            gcashBtnPymtPnl.TabIndex = 17;
            gcashBtnPymtPnl.UseVisualStyleBackColor = false;
            // 
            // visaCardBtnPymtPnl
            // 
            visaCardBtnPymtPnl.BackColor = Color.Transparent;
            visaCardBtnPymtPnl.FlatStyle = FlatStyle.Popup;
            visaCardBtnPymtPnl.Image = Properties.Resources.symbols;
            visaCardBtnPymtPnl.Location = new Point(168, 65);
            visaCardBtnPymtPnl.Name = "visaCardBtnPymtPnl";
            visaCardBtnPymtPnl.Size = new Size(119, 85);
            visaCardBtnPymtPnl.TabIndex = 16;
            visaCardBtnPymtPnl.UseVisualStyleBackColor = false;
            // 
            // masterCardBtnPymtPnl
            // 
            masterCardBtnPymtPnl.BackColor = Color.Transparent;
            masterCardBtnPymtPnl.FlatStyle = FlatStyle.Popup;
            masterCardBtnPymtPnl.Image = Properties.Resources.card__4_;
            masterCardBtnPymtPnl.Location = new Point(38, 63);
            masterCardBtnPymtPnl.Name = "masterCardBtnPymtPnl";
            masterCardBtnPymtPnl.Size = new Size(119, 85);
            masterCardBtnPymtPnl.TabIndex = 15;
            masterCardBtnPymtPnl.UseVisualStyleBackColor = false;
            // 
            // recieptPanel
            // 
            recieptPanel.BackColor = Color.FromArgb(64, 64, 64);
            recieptPanel.Controls.Add(totalLbl);
            recieptPanel.Controls.Add(dateTimeLbl);
            recieptPanel.Controls.Add(discountLbl);
            recieptPanel.Controls.Add(purchaseItemsList);
            recieptPanel.Controls.Add(invoiceLbl);
            recieptPanel.Controls.Add(addressInvoiceLbl);
            recieptPanel.Controls.Add(gradhubInvoiceLbl);
            recieptPanel.Location = new Point(369, 9);
            recieptPanel.Name = "recieptPanel";
            recieptPanel.Size = new Size(292, 464);
            recieptPanel.TabIndex = 0;
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.BackColor = Color.Transparent;
            totalLbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLbl.ForeColor = SystemColors.Control;
            totalLbl.Location = new Point(18, 382);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(84, 40);
            totalLbl.TabIndex = 6;
            totalLbl.Text = "Total";
            // 
            // dateTimeLbl
            // 
            dateTimeLbl.AutoSize = true;
            dateTimeLbl.BackColor = Color.Transparent;
            dateTimeLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeLbl.ForeColor = SystemColors.Control;
            dateTimeLbl.Location = new Point(104, 121);
            dateTimeLbl.Name = "dateTimeLbl";
            dateTimeLbl.Size = new Size(92, 15);
            dateTimeLbl.TabIndex = 5;
            dateTimeLbl.Text = "2/22/2022  16:03";
            // 
            // discountLbl
            // 
            discountLbl.AutoSize = true;
            discountLbl.BackColor = Color.Transparent;
            discountLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountLbl.ForeColor = SystemColors.Control;
            discountLbl.Location = new Point(19, 348);
            discountLbl.Name = "discountLbl";
            discountLbl.Size = new Size(70, 20);
            discountLbl.TabIndex = 4;
            discountLbl.Text = "Discount:";
            // 
            // purchaseItemsList
            // 
            purchaseItemsList.BackColor = Color.FromArgb(64, 64, 64);
            purchaseItemsList.BorderStyle = BorderStyle.None;
            purchaseItemsList.ForeColor = Color.RosyBrown;
            purchaseItemsList.FormattingEnabled = true;
            purchaseItemsList.HorizontalScrollbar = true;
            purchaseItemsList.ItemHeight = 17;
            purchaseItemsList.Location = new Point(17, 171);
            purchaseItemsList.Name = "purchaseItemsList";
            purchaseItemsList.Size = new Size(267, 153);
            purchaseItemsList.TabIndex = 3;
            // 
            // invoiceLbl
            // 
            invoiceLbl.AutoSize = true;
            invoiceLbl.BackColor = Color.Transparent;
            invoiceLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceLbl.ForeColor = SystemColors.Control;
            invoiceLbl.Location = new Point(110, 94);
            invoiceLbl.Name = "invoiceLbl";
            invoiceLbl.Size = new Size(74, 15);
            invoiceLbl.TabIndex = 2;
            invoiceLbl.Text = "Sales Invoice";
            // 
            // addressInvoiceLbl
            // 
            addressInvoiceLbl.AutoSize = true;
            addressInvoiceLbl.BackColor = Color.Transparent;
            addressInvoiceLbl.Font = new Font("Segoe UI Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressInvoiceLbl.ForeColor = SystemColors.Control;
            addressInvoiceLbl.Location = new Point(44, 62);
            addressInvoiceLbl.Name = "addressInvoiceLbl";
            addressInvoiceLbl.Size = new Size(199, 20);
            addressInvoiceLbl.TabIndex = 1;
            addressInvoiceLbl.Text = "Sanciangko St, Cebu City, 6000";
            // 
            // gradhubInvoiceLbl
            // 
            gradhubInvoiceLbl.AutoSize = true;
            gradhubInvoiceLbl.BackColor = Color.Transparent;
            gradhubInvoiceLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradhubInvoiceLbl.ForeColor = SystemColors.Control;
            gradhubInvoiceLbl.Location = new Point(83, 28);
            gradhubInvoiceLbl.Name = "gradhubInvoiceLbl";
            gradhubInvoiceLbl.Size = new Size(124, 32);
            gradhubInvoiceLbl.TabIndex = 0;
            gradhubInvoiceLbl.Text = "Grab Hub";
            // 
            // Finalize
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 516);
            Controls.Add(checkoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Finalize";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finalize";
            checkoutPanel.ResumeLayout(false);
            paymentPanel.ResumeLayout(false);
            paymentPanel.PerformLayout();
            recieptPanel.ResumeLayout(false);
            recieptPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel checkoutPanel;
        private Button returnCheckoutPnlBtn;
        private Panel paymentPanel;
        private Label cashLblPymtPnl;
        private Label gcashLblPymtPnl;
        private Label visaCardLblPymtPnl;
        private Label masterCardLblPymtPnl;
        private Label payHereLblPymtPnl;
        private Button payBtnPymtPnl;
        private Button cashBtnPymtPnl;
        private Button gcashBtnPymtPnl;
        private Button visaCardBtnPymtPnl;
        private Button masterCardBtnPymtPnl;
        private Panel recieptPanel;
        private Label totalLbl;
        private Label dateTimeLbl;
        private Label discountLbl;
        private ListBox purchaseItemsList;
        private Label invoiceLbl;
        private Label addressInvoiceLbl;
        private Label gradhubInvoiceLbl;
    }
}