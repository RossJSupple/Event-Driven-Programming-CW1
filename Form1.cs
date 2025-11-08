namespace _30094747
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
                Method for handling clicking an item
        when the item is clicked the program should use its tag
        to search for the corresponding name and price by using 
        string concatenation and then search the controls for
        the correct label. then should pass the information into
        methods to update the shopping cart and price.
        */
        private void onItem_Click(object sender, EventArgs e)
        {

            PictureBox item = (PictureBox)sender;

            if (item != null)
            {
                string tag = item.Tag.ToString();
                string itemName = "lbl" + tag + "Name";
                string itemPrice = "lbl" + tag + "Price";

                Label lblName = this.Controls.Find(itemName, true).FirstOrDefault() as Label;
                Label lblPrice = this.Controls.Find(itemPrice, true).FirstOrDefault() as Label;

                if (lblName != null && lblPrice != null)
                {
                    addToShoppingCart(tag, lblName.Text);
                    updateCartTotal(lblPrice.Text);
                }
                else
                {
                    MessageBox.Show("Could not find one or both labels.");
                }

                string lastAction = "ADD";
                displayLastAction(lastAction, lblName.Text);

            }
            else
            {
                MessageBox.Show("Error, sender was invalid!");
            }
        }

        /*
                Adding to shopping cart
        the item name and tag are passed in from
        the item click, the method should first
        check to see if the item exists within
        the shopping cart, if not then instantiate
        a new listviewitem and assign it the 
        passed in information, if the item already
        exists then update the quantity.
        */
        private void addToShoppingCart(string tag, string itemName)
        {
            ListViewItem items = new ListViewItem();

            if (!(lstViewCart.Items.ContainsKey(tag)))
            {
                items.Name = tag;
                items.Text = itemName;
                items.SubItems.Add("1");
                lstViewCart.Items.Add(items);
            }
            else
            {
                int index = lstViewCart.Items.IndexOfKey(tag);
                int changeQty = Convert.ToInt32(lstViewCart.Items[index].SubItems[1].Text.ToString());
                changeQty++;
                lstViewCart.Items[index].SubItems[1].Text = changeQty.ToString();
            }

        }

        /*
                update the total price
        method should convert or parse the original
        total price into a double, using the passed in
        price to add to and update the total, then
        convert/parse the new total back to a string
        and write it to the totals text data member.
        */
        private void updateCartTotal(string price)
        {
            double incomingPrice = Convert.ToDouble(price.Trim('£'));
            double oldPrice = Convert.ToDouble(txtItemTotals.Text.Trim('£'));
            double newPrice = oldPrice + incomingPrice;
            txtItemTotals.Text = '£' + newPrice.ToString("F2");
        }

        /*
                checkout button click
        when the checout button is clicked the
        program should disable the item buttons from
        being pressed and enable the money buttons so
        the user can pay.
        */
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            disableItemButtons();
            enableMoneyButtons();
            txtItemTotals.Hide();
            lblTotal.Hide();
            txtCheckoutTotal.Show();
            lblTotalTwo.Show();
            txtCheckoutTotal.Text = txtItemTotals.Text;
        }

        /*
                disable item buttons
        should disable anything relating to items,
        this included the shopping cart.
        */
        private void disableItemButtons()
        {
            picBoxItemOne.Enabled = false;
            picBoxItemTwo.Enabled = false;
            picBoxItemThree.Enabled = false;
            picBoxItemFour.Enabled = false;
            picBoxItemFive.Enabled = false;
            picBoxItemSix.Enabled = false;
            picBoxItemSeven.Enabled = false;
            picBoxItemEight.Enabled = false;
            lstViewCart.Enabled = false;
        }

        /*
                enable money buttons
        should enable all money buttons for the
        user to pay.
        */
        private void enableMoneyButtons()
        {
            picBoxTenPound.Enabled = true;
            picBoxFivePound.Enabled = true;
            picBoxTwoPound.Enabled = true;
            picBoxOnePound.Enabled = true;
            picBoxFiftyPence.Enabled = true;
            picBoxTwentyPence.Enabled = true;
            picBoxTenPence.Enabled = true;
            picBoxFivePence.Enabled = true;
            picBoxCoinSlot.Enabled = true;
        }

        /*
                resetting the system
        should, re-enable all item buttons and
        shopping cart, disable all money buttons,
        reset item totals back to £0.00, and display
        a confirmation message that the system has been reset.
        */
        private void resetSystem()
        {
            lblDisplayLastAction.Text = "Click An Item To Begin";
            lstViewCart.Items.Clear();
            txtItemTotals.Clear();
            txtItemTotals.Show();
            lblTotal.Show();
            txtCheckoutTotal.Hide();
            lblTotalTwo.Hide();
            txtItemTotals.Text = "£0.00";
            txtCheckoutTotal.Text = "£0.00";
            lstViewCart.Enabled = true;
            picBoxItemOne.Enabled = true;
            picBoxItemTwo.Enabled = true;
            picBoxItemThree.Enabled = true;
            picBoxItemFour.Enabled = true;
            picBoxItemFive.Enabled = true;
            picBoxItemSix.Enabled = true;
            picBoxItemSeven.Enabled = true;
            picBoxItemEight.Enabled = true;
            picBoxTenPound.Enabled = false;
            picBoxFivePound.Enabled = false;
            picBoxTwoPound.Enabled = false;
            picBoxOnePound.Enabled = false;
            picBoxFiftyPence.Enabled = false;
            picBoxTwentyPence.Enabled = false;
            picBoxTenPence.Enabled = false;
            picBoxFivePence.Enabled = false;
            picBoxCoinSlot.Enabled = false;
            MessageBox.Show("System has been reset,\nnext customer please!");
        }

        /*
                cancel order
        should prompt the user with a choice
        whether to cancel the order, if yes then
        the system reset method is called, if no
        then they can continue with their transaction.
        */
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you would like to cancel your order?";
            string messageBoxCaption = "Cancel Order";
            var result = MessageBox.Show(message, messageBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                resetSystem();
            }
        }

        /*
                dragging money
        should grab the contents of the money
        into the c# dogragdrop method to be copied
        to the drop target.
        */
        private void dragMoney_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox money = (PictureBox)sender;
            money.DoDragDrop(money.Tag, DragDropEffects.Copy | DragDropEffects.Move);
        }

        /*
                money enters drop zone
        should detect when the money being
        dragged has entered the drop zone,
        if yes then the data being sent is
        copied, if no then nothing happens
        */
        private void picBoxCoinSlot_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        /*
                drop money
        when the money is dropped the money tag
        should be converted to a double and then
        deducted from the item total.
        */
        private void picBoxCoinSlot_DragDrop(object sender, DragEventArgs e)
        {
            string lastAction = "Insert";
            double moneyValue = Convert.ToDouble(e.Data.GetData(DataFormats.Text).ToString());
            displayLastAction(lastAction, moneyValue.ToString("F2"));
            double oldTotalValue = Convert.ToDouble(txtCheckoutTotal.Text.Trim('£'));
            double newTotalValue = oldTotalValue - moneyValue;
            txtCheckoutTotal.Text = '£' + newTotalValue.ToString("F2");
            calculateChange();
        }

        /*
                calculate change
        once the total price reaches 0 after
        deducting money entered by the user,
        the negative value is multiplied by 1
        to give the user their change in a
        positive value.
        */
        private void calculateChange()
        {
            double TotalAfterChangeEntered = Convert.ToDouble(txtCheckoutTotal.Text.Trim('£'));
            double changeGiven;
            if (TotalAfterChangeEntered <= 0)
            {
                changeGiven = TotalAfterChangeEntered * -1 + 0;
                txtCheckoutTotal.Text = "£0.00";
                MessageBox.Show("Thank you for shopping with us,\nyour change is: " + '£' + changeGiven.ToString("F2"), "Order Complete");
                writeTransactionToFile();
                resetSystem();
            }
        }

        /*
                dragging an item out of cart
        same process as with dragging money,this
        method prepares the money for dragging,
        copying and moving the item object.
        */
        private void lstViewCart_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lstViewCart.DoDragDrop(e.Item, DragDropEffects.Copy | DragDropEffects.Move);
        }

        /*
                hovering over bin
        once the item is dragged into the bin
        the program will copy the data held in
        the handler or do nothing if the item
        is not within the bin.
        */
        private void picBoxBin_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        /*
                dragging item to the bin
        after the item is dropped into the bin
        the program will use its tag, to search the
        listview for the item and then deduct 1 from
        the quantity within the list or remove it all
        togeter if it was the last one, should then call
        the deduct from total method.
        */
        private void picBoxBin_DragDrop(object sender, DragEventArgs e)
        {
            string lastAction = "Remove";
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                string tagData = item.Name;
                int index = lstViewCart.Items.IndexOfKey(tagData);
                int existingQTY = Convert.ToInt32(lstViewCart.Items[index].SubItems[1].Text.ToString());

                existingQTY -= 1;
                if (existingQTY > 0)
                {
                    lstViewCart.Items[index].SubItems[1].Text = existingQTY.ToString();
                }
                else
                {
                    lstViewCart.Items.RemoveByKey(tagData);
                }
                removeItemFromTotal(tagData);
                displayLastAction(lastAction, item.Text);
            }
        }

        /*
                deducting item price from total
        using the item tag passed in by the bin drag & drop
        this method should search for the correct item label
        to get the price and then deduct that price from the
        total.
        */
        private void removeItemFromTotal(string itemTag)
        {
            string itemPrice = "lbl" + itemTag + "Price";
            double Price;
            double newTotal;
            Label lblPrice = this.Controls.Find(itemPrice, true).FirstOrDefault() as Label;

            if (lblPrice != null)
            {
                double itemTotals = Convert.ToDouble(txtItemTotals.Text.Trim('£'));
                Price = Convert.ToDouble(lblPrice.Text.Trim('£'));
                newTotal = itemTotals - Price;
                txtItemTotals.Text = '£' + newTotal.ToString("F2");
            }
            else
            {
                MessageBox.Show("Could not the correct label");
            }
        }

        /*
                displaying the users last action
        should take data passed in from other methods to be
        concatenated displaying the users last action
        */
        private void displayLastAction(string lastAction, string name)
        {
            if (lastAction == "ADD")
            {
                lblDisplayLastAction.Text = name + " Added To Cart";
            }
            else if (lastAction == "Insert")
            {
                lblDisplayLastAction.Text = "Amount Inserted: £" + name;
            }
            else if (lastAction == "Remove")
            {
                lblDisplayLastAction.Text = name + " Has Been Removed From The Cart";
            }
        }

        /*
                write sales history to file
        this method should check to see if a file already
        write the users transaction history exists, if no then
        the file will be created with headers to identify each
        column, if it does exist then just append the transaction
        to the file include the item name, quantity and date, 
        then display the order total at the bottom of the transaction.
        */
        private void writeTransactionToFile()
        {
            string path = @"../../../salesHistory.txt";
            string header1 = "Item Name";
            string header2 = "Item Quantity";
            string header3 = "Date";
            string dateTime = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
            bool fileExists = false;

            if (File.Exists(path))
            {
                fileExists = true;
            }

            using (TextWriter tw = new StreamWriter(path, append: true))
            {
                if (fileExists == false)
                {
                    tw.WriteLine("{0,-20}{1,-20} {2}", header1, header2, header3);
                    tw.WriteLine();
                }
                foreach (ListViewItem item in lstViewCart.Items)
                {
                    string itemName = item.Text;
                    string itemQTY = item.SubItems[1].Text;
                    tw.WriteLine("{0,-25}{1,-15} {2}", itemName, 'x' + itemQTY, dateTime);
                }
                tw.WriteLine();
                tw.WriteLine("Order Total: " + "{0, -28}{1}", txtItemTotals.Text, dateTime);
                tw.WriteLine();
                tw.WriteLine();
            }
        }
    }
}