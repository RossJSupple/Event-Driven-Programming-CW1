using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _30094747
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onItem_Click(object sender, EventArgs e)
        {

            PictureBox item = (PictureBox)sender;

            string tag = item.Tag.ToString();
            string itemName = "lbl" + tag + "Name";
            string itemPrice = "lbl" + tag + "Price";

            Label lblName = this.Controls.Find(itemName, true).FirstOrDefault() as Label;
            Label lblPrice = this.Controls.Find(itemPrice, true).FirstOrDefault() as Label;

            if (lblName != null && lblPrice != null)
            {
                shoppingCart(tag, lblName.Text);
                cartTotal(lblPrice.Text);
            }
            else
            {
                MessageBox.Show("Could not find one or both labels.");
            }

            string lastAction = "ADD";

            displayLastAction(lastAction, lblName.Text);

        }

        private void shoppingCart(string tag, string itemName)
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

        private void cartTotal(string price)
        {
            double incomingPrice = Convert.ToDouble(price.Trim('£'));

            double oldPrice = Convert.ToDouble(txtItemTotals.Text.Trim('£'));

            double newPrice = oldPrice + incomingPrice;

            txtItemTotals.Text = '£' + newPrice.ToString("F2");

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            disableItemButtons();
            enableMoneyButtons();
            txtItemTotals.Hide();
            lblTotal.Hide();
            txtInsertedChange.Show();
            lblInsertedMoney.Show();
            txtInsertedChange.Text = txtItemTotals.Text; 
        }

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
        }


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

        private void resetSystem()
        {
            lblDisplayLastAction.Text = "Click An Item To Begin";
            lstViewCart.Items.Clear();
            txtItemTotals.Clear();
            txtItemTotals.Show();
            lblTotal.Show();
            txtInsertedChange.Hide();
            lblInsertedMoney.Hide();
            txtItemTotals.Text = "£0.00";
            txtInsertedChange.Text = "0.00";
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

        private void dragMoney_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox money = (PictureBox)sender;
            money.DoDragDrop(money.Tag, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void picBoxCoinSlot_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void picBoxCoinSlot_DragDrop(object sender, DragEventArgs e)
        {
            string lastAction = "Insert";
            double moneyValue = Convert.ToDouble(e.Data.GetData(DataFormats.Text).ToString());
            displayLastAction(lastAction, moneyValue.ToString("F2"));
            double oldTotalValue = Convert.ToDouble(txtInsertedChange.Text.Trim('£'));
            double newTotalValue = oldTotalValue - moneyValue;
            txtInsertedChange.Text = '£' + newTotalValue.ToString("F2");
            calculateChange();
        }

        private void calculateChange()
        {
            double overallTotal = Convert.ToDouble(txtItemTotals.Text.Trim('£'));
            double TotalAfterChangeEntered = Convert.ToDouble(txtInsertedChange.Text.Trim('£'));
            double changeGiven;
            if (TotalAfterChangeEntered <= 0)
            {
                changeGiven = TotalAfterChangeEntered * -1 + 0;
                txtInsertedChange.Text = "£0.00";
                MessageBox.Show("Thank you for shopping with us,\nyour change is: " + '£' + changeGiven.ToString("F2"), "Order Complete");
                writeTransactionToFile();
                resetSystem();
            }
            
        }

        private void lstViewCart_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lstViewCart.DoDragDrop(e.Item, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void picBoxBin_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

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

        private void displayLastAction(string lastAction, string name)
        {
            if(lastAction == "ADD")
            {
                lblDisplayLastAction.Text = name + " Added To Cart";
            }
            else if (lastAction == "Insert")
            {
                lblDisplayLastAction.Text = "Amount Inserted: £" + name; 
            }
            else if(lastAction == "Remove")
            {
                lblDisplayLastAction.Text = name + " Has Been Removed From The Cart";
            }
            
        }
        
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
                    tw.WriteLine("{0,-15}{1,-20} {2}", header1, header2, header3);
                    tw.WriteLine();
                }
                foreach (ListViewItem item in lstViewCart.Items)
                {
                    
                    string itemName = item.Text;
                    string itemQTY = item.SubItems[1].Text;
                    tw.WriteLine("{0,-20}{1,-15} {2}", itemName,'x' + itemQTY, dateTime);

                }
                tw.WriteLine("Order Total: " + txtItemTotals.Text);
                tw.WriteLine();
                tw.WriteLine();
            }

        }
    }
}
