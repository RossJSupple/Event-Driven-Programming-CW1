namespace _30094747
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picBoxItemOne = new PictureBox();
            lblItemOneName = new Label();
            lblItemOnePrice = new Label();
            lstViewCart = new ListView();
            clmHeaderOne = new ColumnHeader();
            clmHeaderQty = new ColumnHeader();
            picBoxItemTwo = new PictureBox();
            lblItemTwoName = new Label();
            lblItemTwoPrice = new Label();
            picBoxItemThree = new PictureBox();
            picBoxItemFour = new PictureBox();
            lblItemThreeName = new Label();
            lblItemFourName = new Label();
            txtItemTotals = new TextBox();
            lblItemThreePrice = new Label();
            lblItemFourPrice = new Label();
            btnCheckout = new Button();
            btnCancelOrder = new Button();
            picBoxCoinSlot = new PictureBox();
            picBoxFivePound = new PictureBox();
            picBoxOnePound = new PictureBox();
            txtInsertedChange = new TextBox();
            lblTotal = new Label();
            lblInsertedMoney = new Label();
            picBoxFiftyPence = new PictureBox();
            picBoxTwentyPence = new PictureBox();
            picBoxBin = new PictureBox();
            divider = new Label();
            picBoxItemFive = new PictureBox();
            lblItemFiveName = new Label();
            lblItemFivePrice = new Label();
            picBoxItemSix = new PictureBox();
            picBoxItemSeven = new PictureBox();
            picBoxItemEight = new PictureBox();
            lblItemSixName = new Label();
            lblItemSevenName = new Label();
            lblItemEightName = new Label();
            lblItemSixPrice = new Label();
            lblItemSevenPrice = new Label();
            lblItemEightPrice = new Label();
            picBoxTenPound = new PictureBox();
            picBoxTwoPound = new PictureBox();
            picBoxTenPence = new PictureBox();
            picBoxFivePence = new PictureBox();
            lblDisplayLastAction = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxItemOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemFour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxCoinSlot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxFivePound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxOnePound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxFiftyPence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTwentyPence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemFive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemSix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemSeven).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemEight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTenPound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTwoPound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTenPence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxFivePence).BeginInit();
            SuspendLayout();
            // 
            // picBoxItemOne
            // 
            picBoxItemOne.BorderStyle = BorderStyle.Fixed3D;
            picBoxItemOne.Image = (Image)resources.GetObject("picBoxItemOne.Image");
            picBoxItemOne.Location = new Point(12, 12);
            picBoxItemOne.Name = "picBoxItemOne";
            picBoxItemOne.Size = new Size(139, 143);
            picBoxItemOne.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxItemOne.TabIndex = 0;
            picBoxItemOne.TabStop = false;
            picBoxItemOne.Tag = "ItemOne";
            picBoxItemOne.Click += onItem_Click;
            // 
            // lblItemOneName
            // 
            lblItemOneName.AutoSize = true;
            lblItemOneName.Font = new Font("Segoe UI", 12F);
            lblItemOneName.Location = new Point(12, 158);
            lblItemOneName.Name = "lblItemOneName";
            lblItemOneName.Size = new Size(79, 21);
            lblItemOneName.TabIndex = 1;
            lblItemOneName.Text = "Coca Cola";
            // 
            // lblItemOnePrice
            // 
            lblItemOnePrice.AutoSize = true;
            lblItemOnePrice.Font = new Font("Segoe UI", 11F);
            lblItemOnePrice.Location = new Point(12, 179);
            lblItemOnePrice.Name = "lblItemOnePrice";
            lblItemOnePrice.Size = new Size(44, 20);
            lblItemOnePrice.TabIndex = 2;
            lblItemOnePrice.Text = "£1.50";
            // 
            // lstViewCart
            // 
            lstViewCart.BorderStyle = BorderStyle.FixedSingle;
            lstViewCart.Columns.AddRange(new ColumnHeader[] { clmHeaderOne, clmHeaderQty });
            lstViewCart.GridLines = true;
            lstViewCart.Location = new Point(592, 12);
            lstViewCart.Name = "lstViewCart";
            lstViewCart.Size = new Size(195, 217);
            lstViewCart.TabIndex = 3;
            lstViewCart.UseCompatibleStateImageBehavior = false;
            lstViewCart.View = View.Details;
            lstViewCart.ItemDrag += lstViewCart_ItemDrag;
            // 
            // clmHeaderOne
            // 
            clmHeaderOne.Text = "Name";
            clmHeaderOne.Width = 120;
            // 
            // clmHeaderQty
            // 
            clmHeaderQty.Text = "Quantity";
            clmHeaderQty.Width = 75;
            // 
            // picBoxItemTwo
            // 
            picBoxItemTwo.BorderStyle = BorderStyle.Fixed3D;
            picBoxItemTwo.Image = (Image)resources.GetObject("picBoxItemTwo.Image");
            picBoxItemTwo.Location = new Point(157, 12);
            picBoxItemTwo.Name = "picBoxItemTwo";
            picBoxItemTwo.Size = new Size(139, 143);
            picBoxItemTwo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxItemTwo.TabIndex = 4;
            picBoxItemTwo.TabStop = false;
            picBoxItemTwo.Tag = "ItemTwo";
            picBoxItemTwo.Click += onItem_Click;
            // 
            // lblItemTwoName
            // 
            lblItemTwoName.AutoSize = true;
            lblItemTwoName.Font = new Font("Segoe UI", 12F);
            lblItemTwoName.Location = new Point(157, 158);
            lblItemTwoName.Name = "lblItemTwoName";
            lblItemTwoName.Size = new Size(66, 21);
            lblItemTwoName.TabIndex = 5;
            lblItemTwoName.Text = "Squares";
            // 
            // lblItemTwoPrice
            // 
            lblItemTwoPrice.AutoSize = true;
            lblItemTwoPrice.Font = new Font("Segoe UI", 11F);
            lblItemTwoPrice.Location = new Point(157, 179);
            lblItemTwoPrice.Name = "lblItemTwoPrice";
            lblItemTwoPrice.Size = new Size(44, 20);
            lblItemTwoPrice.TabIndex = 6;
            lblItemTwoPrice.Text = "£1.00";
            // 
            // picBoxItemThree
            // 
            picBoxItemThree.BorderStyle = BorderStyle.Fixed3D;
            picBoxItemThree.Image = (Image)resources.GetObject("picBoxItemThree.Image");
            picBoxItemThree.Location = new Point(302, 12);
            picBoxItemThree.Name = "picBoxItemThree";
            picBoxItemThree.Size = new Size(139, 143);
            picBoxItemThree.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxItemThree.TabIndex = 7;
            picBoxItemThree.TabStop = false;
            picBoxItemThree.Tag = "ItemThree";
            picBoxItemThree.Click += onItem_Click;
            // 
            // picBoxItemFour
            // 
            picBoxItemFour.BorderStyle = BorderStyle.Fixed3D;
            picBoxItemFour.Image = (Image)resources.GetObject("picBoxItemFour.Image");
            picBoxItemFour.Location = new Point(447, 12);
            picBoxItemFour.Name = "picBoxItemFour";
            picBoxItemFour.Size = new Size(139, 143);
            picBoxItemFour.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxItemFour.TabIndex = 8;
            picBoxItemFour.TabStop = false;
            picBoxItemFour.Tag = "ItemFour";
            picBoxItemFour.Click += onItem_Click;
            // 
            // lblItemThreeName
            // 
            lblItemThreeName.AutoSize = true;
            lblItemThreeName.Font = new Font("Segoe UI", 12F);
            lblItemThreeName.Location = new Point(302, 158);
            lblItemThreeName.Name = "lblItemThreeName";
            lblItemThreeName.Size = new Size(47, 21);
            lblItemThreeName.TabIndex = 9;
            lblItemThreeName.Text = "Fanta";
            // 
            // lblItemFourName
            // 
            lblItemFourName.AutoSize = true;
            lblItemFourName.Font = new Font("Segoe UI", 12F);
            lblItemFourName.Location = new Point(447, 158);
            lblItemFourName.Name = "lblItemFourName";
            lblItemFourName.Size = new Size(120, 21);
            lblItemFourName.TabIndex = 10;
            lblItemFourName.Text = "Monster Munch";
            lblItemFourName.Click += onItem_Click;
            // 
            // txtItemTotals
            // 
            txtItemTotals.BackColor = Color.White;
            txtItemTotals.BorderStyle = BorderStyle.None;
            txtItemTotals.Font = new Font("Segoe UI", 15F);
            txtItemTotals.Location = new Point(689, 450);
            txtItemTotals.Name = "txtItemTotals";
            txtItemTotals.ReadOnly = true;
            txtItemTotals.Size = new Size(98, 27);
            txtItemTotals.TabIndex = 11;
            txtItemTotals.Text = "£0.00";
            txtItemTotals.TextAlign = HorizontalAlignment.Right;
            // 
            // lblItemThreePrice
            // 
            lblItemThreePrice.AutoSize = true;
            lblItemThreePrice.Font = new Font("Segoe UI", 11F);
            lblItemThreePrice.Location = new Point(302, 179);
            lblItemThreePrice.Name = "lblItemThreePrice";
            lblItemThreePrice.Size = new Size(44, 20);
            lblItemThreePrice.TabIndex = 12;
            lblItemThreePrice.Text = "£2.00";
            // 
            // lblItemFourPrice
            // 
            lblItemFourPrice.AutoSize = true;
            lblItemFourPrice.Font = new Font("Segoe UI", 11F);
            lblItemFourPrice.Location = new Point(447, 179);
            lblItemFourPrice.Name = "lblItemFourPrice";
            lblItemFourPrice.Size = new Size(44, 20);
            lblItemFourPrice.TabIndex = 13;
            lblItemFourPrice.Text = "£1.20";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(128, 255, 128);
            btnCheckout.FlatAppearance.BorderSize = 2;
            btnCheckout.Font = new Font("Segoe UI", 12F);
            btnCheckout.Location = new Point(591, 363);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(196, 29);
            btnCheckout.TabIndex = 14;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.BackColor = Color.Red;
            btnCancelOrder.Font = new Font("Segoe UI", 12F);
            btnCancelOrder.Location = new Point(591, 398);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(196, 29);
            btnCancelOrder.TabIndex = 15;
            btnCancelOrder.Text = "Cancel";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // picBoxCoinSlot
            // 
            picBoxCoinSlot.AllowDrop = true;
            picBoxCoinSlot.BorderStyle = BorderStyle.FixedSingle;
            picBoxCoinSlot.Enabled = false;
            picBoxCoinSlot.Image = (Image)resources.GetObject("picBoxCoinSlot.Image");
            picBoxCoinSlot.Location = new Point(591, 510);
            picBoxCoinSlot.Name = "picBoxCoinSlot";
            picBoxCoinSlot.Size = new Size(196, 164);
            picBoxCoinSlot.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxCoinSlot.TabIndex = 16;
            picBoxCoinSlot.TabStop = false;
            picBoxCoinSlot.DragDrop += picBoxCoinSlot_DragDrop;
            picBoxCoinSlot.DragEnter += picBoxCoinSlot_DragEnter;
            // 
            // picBoxFivePound
            // 
            picBoxFivePound.BorderStyle = BorderStyle.Fixed3D;
            picBoxFivePound.Enabled = false;
            picBoxFivePound.Image = (Image)resources.GetObject("picBoxFivePound.Image");
            picBoxFivePound.Location = new Point(12, 614);
            picBoxFivePound.Name = "picBoxFivePound";
            picBoxFivePound.Size = new Size(189, 98);
            picBoxFivePound.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxFivePound.TabIndex = 17;
            picBoxFivePound.TabStop = false;
            picBoxFivePound.Tag = "5.00";
            picBoxFivePound.MouseDown += dragMoney_MouseDown;
            // 
            // picBoxOnePound
            // 
            picBoxOnePound.BorderStyle = BorderStyle.Fixed3D;
            picBoxOnePound.Enabled = false;
            picBoxOnePound.Image = (Image)resources.GetObject("picBoxOnePound.Image");
            picBoxOnePound.Location = new Point(207, 614);
            picBoxOnePound.Name = "picBoxOnePound";
            picBoxOnePound.Size = new Size(118, 98);
            picBoxOnePound.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOnePound.TabIndex = 18;
            picBoxOnePound.TabStop = false;
            picBoxOnePound.Tag = "1.00";
            picBoxOnePound.MouseDown += dragMoney_MouseDown;
            // 
            // txtInsertedChange
            // 
            txtInsertedChange.BackColor = Color.White;
            txtInsertedChange.BorderStyle = BorderStyle.None;
            txtInsertedChange.Font = new Font("Segoe UI", 15F);
            txtInsertedChange.Location = new Point(709, 685);
            txtInsertedChange.Name = "txtInsertedChange";
            txtInsertedChange.ReadOnly = true;
            txtInsertedChange.Size = new Size(78, 27);
            txtInsertedChange.TabIndex = 19;
            txtInsertedChange.Text = "£0.00";
            txtInsertedChange.TextAlign = HorizontalAlignment.Right;
            txtInsertedChange.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 15F);
            lblTotal.Location = new Point(592, 450);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(98, 27);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "Total:";
            // 
            // lblInsertedMoney
            // 
            lblInsertedMoney.Font = new Font("Segoe UI", 15F);
            lblInsertedMoney.Location = new Point(591, 685);
            lblInsertedMoney.Name = "lblInsertedMoney";
            lblInsertedMoney.Size = new Size(63, 27);
            lblInsertedMoney.TabIndex = 21;
            lblInsertedMoney.Text = "Total:";
            lblInsertedMoney.Visible = false;
            // 
            // picBoxFiftyPence
            // 
            picBoxFiftyPence.BorderStyle = BorderStyle.Fixed3D;
            picBoxFiftyPence.Enabled = false;
            picBoxFiftyPence.Image = (Image)resources.GetObject("picBoxFiftyPence.Image");
            picBoxFiftyPence.Location = new Point(331, 510);
            picBoxFiftyPence.Name = "picBoxFiftyPence";
            picBoxFiftyPence.Size = new Size(118, 98);
            picBoxFiftyPence.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxFiftyPence.TabIndex = 22;
            picBoxFiftyPence.TabStop = false;
            picBoxFiftyPence.Tag = "0.50";
            picBoxFiftyPence.MouseDown += dragMoney_MouseDown;
            // 
            // picBoxTwentyPence
            // 
            picBoxTwentyPence.BorderStyle = BorderStyle.Fixed3D;
            picBoxTwentyPence.Enabled = false;
            picBoxTwentyPence.Image = (Image)resources.GetObject("picBoxTwentyPence.Image");
            picBoxTwentyPence.Location = new Point(331, 614);
            picBoxTwentyPence.Name = "picBoxTwentyPence";
            picBoxTwentyPence.Size = new Size(118, 98);
            picBoxTwentyPence.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxTwentyPence.TabIndex = 23;
            picBoxTwentyPence.TabStop = false;
            picBoxTwentyPence.Tag = "0.20";
            picBoxTwentyPence.MouseDown += dragMoney_MouseDown;
            // 
            // picBoxBin
            // 
            picBoxBin.AllowDrop = true;
            picBoxBin.BorderStyle = BorderStyle.FixedSingle;
            picBoxBin.Image = (Image)resources.GetObject("picBoxBin.Image");
            picBoxBin.Location = new Point(591, 235);
            picBoxBin.Name = "picBoxBin";
            picBoxBin.Size = new Size(196, 122);
            picBoxBin.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxBin.TabIndex = 24;
            picBoxBin.TabStop = false;
            picBoxBin.DragDrop += picBoxBin_DragDrop;
            picBoxBin.DragEnter += picBoxBin_DragEnter;
            // 
            // divider
            // 
            divider.BackColor = Color.Black;
            divider.BorderStyle = BorderStyle.Fixed3D;
            divider.Location = new Point(12, 499);
            divider.Name = "divider";
            divider.Size = new Size(775, 7);
            divider.TabIndex = 25;
            // 
            // picBoxItemFive
            // 
            picBoxItemFive.BorderStyle = BorderStyle.Fixed3D;
            picBoxItemFive.Image = (Image)resources.GetObject("picBoxItemFive.Image");
            picBoxItemFive.Location = new Point(12, 235);
            picBoxItemFive.Name = "picBoxItemFive";
            picBoxItemFive.Size = new Size(139, 143);
            picBoxItemFive.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxItemFive.TabIndex = 26;
            picBoxItemFive.TabStop = false;
            picBoxItemFive.Tag = "ItemFive";
            picBoxItemFive.Click += onItem_Click;
            // 
            // lblItemFiveName
            // 
            lblItemFiveName.AutoSize = true;
            lblItemFiveName.Font = new Font("Segoe UI", 12F);
            lblItemFiveName.Location = new Point(12, 381);
            lblItemFiveName.Name = "lblItemFiveName";
            lblItemFiveName.Size = new Size(79, 21);
            lblItemFiveName.TabIndex = 27;
            lblItemFiveName.Text = "Dr Pepper";
            // 
            // lblItemFivePrice
            // 
            lblItemFivePrice.AutoSize = true;
            lblItemFivePrice.Font = new Font("Segoe UI", 12F);
            lblItemFivePrice.Location = new Point(12, 401);
            lblItemFivePrice.Name = "lblItemFivePrice";
            lblItemFivePrice.Size = new Size(49, 21);
            lblItemFivePrice.TabIndex = 28;
            lblItemFivePrice.Text = "£1.25";
            // 
            // picBoxItemSix
            // 
            picBoxItemSix.BorderStyle = BorderStyle.Fixed3D;
            picBoxItemSix.Image = (Image)resources.GetObject("picBoxItemSix.Image");
            picBoxItemSix.Location = new Point(157, 235);
            picBoxItemSix.Name = "picBoxItemSix";
            picBoxItemSix.Size = new Size(139, 143);
            picBoxItemSix.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxItemSix.TabIndex = 29;
            picBoxItemSix.TabStop = false;
            picBoxItemSix.Tag = "ItemSix";
            picBoxItemSix.Click += onItem_Click;
            // 
            // picBoxItemSeven
            // 
            picBoxItemSeven.BorderStyle = BorderStyle.Fixed3D;
            picBoxItemSeven.Image = (Image)resources.GetObject("picBoxItemSeven.Image");
            picBoxItemSeven.Location = new Point(302, 235);
            picBoxItemSeven.Name = "picBoxItemSeven";
            picBoxItemSeven.Size = new Size(139, 143);
            picBoxItemSeven.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxItemSeven.TabIndex = 30;
            picBoxItemSeven.TabStop = false;
            picBoxItemSeven.Tag = "ItemSeven";
            picBoxItemSeven.Click += onItem_Click;
            // 
            // picBoxItemEight
            // 
            picBoxItemEight.BorderStyle = BorderStyle.Fixed3D;
            picBoxItemEight.Image = (Image)resources.GetObject("picBoxItemEight.Image");
            picBoxItemEight.Location = new Point(447, 235);
            picBoxItemEight.Name = "picBoxItemEight";
            picBoxItemEight.Size = new Size(139, 143);
            picBoxItemEight.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxItemEight.TabIndex = 31;
            picBoxItemEight.TabStop = false;
            picBoxItemEight.Tag = "ItemEight";
            picBoxItemEight.Click += onItem_Click;
            // 
            // lblItemSixName
            // 
            lblItemSixName.AutoSize = true;
            lblItemSixName.Font = new Font("Segoe UI", 12F);
            lblItemSixName.Location = new Point(157, 381);
            lblItemSixName.Name = "lblItemSixName";
            lblItemSixName.Size = new Size(56, 21);
            lblItemSixName.TabIndex = 32;
            lblItemSixName.Text = "Galaxy";
            // 
            // lblItemSevenName
            // 
            lblItemSevenName.AutoSize = true;
            lblItemSevenName.Font = new Font("Segoe UI", 12F);
            lblItemSevenName.Location = new Point(302, 381);
            lblItemSevenName.Name = "lblItemSevenName";
            lblItemSevenName.Size = new Size(112, 21);
            lblItemSevenName.TabIndex = 33;
            lblItemSevenName.Text = "Mountain Dew";
            // 
            // lblItemEightName
            // 
            lblItemEightName.AutoSize = true;
            lblItemEightName.Font = new Font("Segoe UI", 12F);
            lblItemEightName.Location = new Point(447, 381);
            lblItemEightName.Name = "lblItemEightName";
            lblItemEightName.Size = new Size(81, 21);
            lblItemEightName.TabIndex = 34;
            lblItemEightName.Text = "Dairy Milk";
            // 
            // lblItemSixPrice
            // 
            lblItemSixPrice.AutoSize = true;
            lblItemSixPrice.Font = new Font("Segoe UI", 12F);
            lblItemSixPrice.Location = new Point(157, 401);
            lblItemSixPrice.Name = "lblItemSixPrice";
            lblItemSixPrice.Size = new Size(49, 21);
            lblItemSixPrice.TabIndex = 35;
            lblItemSixPrice.Text = "£1.99";
            // 
            // lblItemSevenPrice
            // 
            lblItemSevenPrice.AutoSize = true;
            lblItemSevenPrice.Font = new Font("Segoe UI", 12F);
            lblItemSevenPrice.Location = new Point(302, 401);
            lblItemSevenPrice.Name = "lblItemSevenPrice";
            lblItemSevenPrice.Size = new Size(49, 21);
            lblItemSevenPrice.TabIndex = 36;
            lblItemSevenPrice.Text = "£1.25";
            // 
            // lblItemEightPrice
            // 
            lblItemEightPrice.AutoSize = true;
            lblItemEightPrice.Font = new Font("Segoe UI", 12F);
            lblItemEightPrice.Location = new Point(447, 401);
            lblItemEightPrice.Name = "lblItemEightPrice";
            lblItemEightPrice.Size = new Size(49, 21);
            lblItemEightPrice.TabIndex = 37;
            lblItemEightPrice.Text = "£3.00";
            // 
            // picBoxTenPound
            // 
            picBoxTenPound.BorderStyle = BorderStyle.Fixed3D;
            picBoxTenPound.Enabled = false;
            picBoxTenPound.Image = (Image)resources.GetObject("picBoxTenPound.Image");
            picBoxTenPound.Location = new Point(12, 510);
            picBoxTenPound.Name = "picBoxTenPound";
            picBoxTenPound.Size = new Size(189, 98);
            picBoxTenPound.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxTenPound.TabIndex = 38;
            picBoxTenPound.TabStop = false;
            picBoxTenPound.Tag = "10.00";
            picBoxTenPound.MouseDown += dragMoney_MouseDown;
            // 
            // picBoxTwoPound
            // 
            picBoxTwoPound.BorderStyle = BorderStyle.Fixed3D;
            picBoxTwoPound.Enabled = false;
            picBoxTwoPound.Image = (Image)resources.GetObject("picBoxTwoPound.Image");
            picBoxTwoPound.Location = new Point(207, 510);
            picBoxTwoPound.Name = "picBoxTwoPound";
            picBoxTwoPound.Size = new Size(118, 98);
            picBoxTwoPound.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxTwoPound.TabIndex = 39;
            picBoxTwoPound.TabStop = false;
            picBoxTwoPound.Tag = "2.00";
            picBoxTwoPound.MouseDown += dragMoney_MouseDown;
            // 
            // picBoxTenPence
            // 
            picBoxTenPence.BorderStyle = BorderStyle.Fixed3D;
            picBoxTenPence.Enabled = false;
            picBoxTenPence.Image = (Image)resources.GetObject("picBoxTenPence.Image");
            picBoxTenPence.Location = new Point(455, 510);
            picBoxTenPence.Name = "picBoxTenPence";
            picBoxTenPence.Size = new Size(118, 98);
            picBoxTenPence.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxTenPence.TabIndex = 40;
            picBoxTenPence.TabStop = false;
            picBoxTenPence.Tag = "0.10";
            picBoxTenPence.MouseDown += dragMoney_MouseDown;
            // 
            // picBoxFivePence
            // 
            picBoxFivePence.BorderStyle = BorderStyle.Fixed3D;
            picBoxFivePence.Enabled = false;
            picBoxFivePence.Image = (Image)resources.GetObject("picBoxFivePence.Image");
            picBoxFivePence.Location = new Point(455, 614);
            picBoxFivePence.Name = "picBoxFivePence";
            picBoxFivePence.Size = new Size(118, 98);
            picBoxFivePence.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxFivePence.TabIndex = 41;
            picBoxFivePence.TabStop = false;
            picBoxFivePence.Tag = "0.05";
            picBoxFivePence.MouseDown += dragMoney_MouseDown;
            // 
            // lblDisplayLastAction
            // 
            lblDisplayLastAction.BorderStyle = BorderStyle.FixedSingle;
            lblDisplayLastAction.Font = new Font("Segoe UI", 16F);
            lblDisplayLastAction.Location = new Point(12, 439);
            lblDisplayLastAction.Name = "lblDisplayLastAction";
            lblDisplayLastAction.Size = new Size(574, 49);
            lblDisplayLastAction.TabIndex = 42;
            lblDisplayLastAction.Text = "Click An Item To Begin";
            lblDisplayLastAction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 726);
            Controls.Add(lblDisplayLastAction);
            Controls.Add(picBoxFivePence);
            Controls.Add(picBoxTenPence);
            Controls.Add(picBoxTwoPound);
            Controls.Add(picBoxTenPound);
            Controls.Add(lblItemEightPrice);
            Controls.Add(lblItemSevenPrice);
            Controls.Add(lblItemSixPrice);
            Controls.Add(lblItemEightName);
            Controls.Add(lblItemSevenName);
            Controls.Add(lblItemSixName);
            Controls.Add(picBoxItemEight);
            Controls.Add(picBoxItemSeven);
            Controls.Add(picBoxItemSix);
            Controls.Add(lblItemFivePrice);
            Controls.Add(lblItemFiveName);
            Controls.Add(picBoxItemFive);
            Controls.Add(divider);
            Controls.Add(picBoxBin);
            Controls.Add(picBoxTwentyPence);
            Controls.Add(picBoxFiftyPence);
            Controls.Add(lblInsertedMoney);
            Controls.Add(lblTotal);
            Controls.Add(txtInsertedChange);
            Controls.Add(picBoxOnePound);
            Controls.Add(picBoxFivePound);
            Controls.Add(picBoxCoinSlot);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnCheckout);
            Controls.Add(lblItemFourPrice);
            Controls.Add(lblItemThreePrice);
            Controls.Add(txtItemTotals);
            Controls.Add(lblItemFourName);
            Controls.Add(lblItemThreeName);
            Controls.Add(picBoxItemFour);
            Controls.Add(picBoxItemThree);
            Controls.Add(lblItemTwoPrice);
            Controls.Add(lblItemTwoName);
            Controls.Add(picBoxItemTwo);
            Controls.Add(lstViewCart);
            Controls.Add(lblItemOnePrice);
            Controls.Add(lblItemOneName);
            Controls.Add(picBoxItemOne);
            Name = "Form1";
            Text = "30094747";
            ((System.ComponentModel.ISupportInitialize)picBoxItemOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemFour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxCoinSlot).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxFivePound).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxOnePound).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxFiftyPence).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTwentyPence).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemFive).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemSix).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemSeven).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxItemEight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTenPound).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTwoPound).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTenPence).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxFivePence).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxItemOne;
        private Label lblItemOneName;
        private Label lblItemOnePrice;
        private ListView lstViewCart;
        private ColumnHeader clmHeaderOne;
        private ColumnHeader clmHeaderQty;
        private PictureBox picBoxItemTwo;
        private Label lblItemTwoName;
        private Label lblItemTwoPrice;
        private PictureBox picBoxItemThree;
        private PictureBox picBoxItemFour;
        private Label lblItemThreeName;
        private Label lblItemFourName;
        private TextBox txtItemTotals;
        private Label lblItemThreePrice;
        private Label lblItemFourPrice;
        private Button btnCheckout;
        private Button btnCancelOrder;
        private PictureBox picBoxCoinSlot;
        private PictureBox picBoxFivePound;
        private PictureBox picBoxOnePound;
        private TextBox txtInsertedChange;
        private Label lblTotal;
        private Label lblInsertedMoney;
        private PictureBox picBoxFiftyPence;
        private PictureBox picBoxTwentyPence;
        private PictureBox picBoxBin;
        private Label divider;
        private PictureBox picBoxItemFive;
        private Label lblItemFiveName;
        private Label lblItemFivePrice;
        private PictureBox picBoxItemSix;
        private PictureBox picBoxItemSeven;
        private PictureBox picBoxItemEight;
        private Label lblItemSixName;
        private Label lblItemSevenName;
        private Label lblItemEightName;
        private Label lblItemSixPrice;
        private Label lblItemSevenPrice;
        private Label lblItemEightPrice;
        private PictureBox picBoxTenPound;
        private PictureBox picBoxTwoPound;
        private PictureBox picBoxTenPence;
        private PictureBox picBoxFivePence;
        private Label lblDisplayLastAction;
    }
}
