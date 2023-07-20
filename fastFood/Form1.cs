namespace fastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sets up and shows current time
            dateLB.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLB.Text = DateTime.Now.ToLongTimeString();
        }

        private void friesCB_CheckedChanged(object sender, EventArgs e)
        {
            if (friesCB.Checked == true)
            {
                friesTB.Enabled = true;
            }
            else
            {
                friesTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                friesTB.Text = "0";
            }
        }

        private void burgerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (burgerCB.Checked == true)
            {
                burgerTB.Enabled = true;
            }
            else
            {
                burgerTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                burgerTB.Text = "0";
            }
        }

        private void saladCB_CheckedChanged(object sender, EventArgs e)
        {
            if (saladCB.Checked == true)
            {
                saladTB.Enabled = true;
            }
            else
            {
                saladTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                saladTB.Text = "0";
            }
        }

        private void sandwichCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sandwichCB.Checked == true)
            {
                sandwichTB.Enabled = true;
            }
            else
            {
                sandwichTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                sandwichTB.Text = "0";
            }
        }

        private void chickenCB_CheckedChanged(object sender, EventArgs e)
        {
            if (chickenCB.Checked == true)
            {
                chickenTB.Enabled = true;
            }
            else
            {
                chickenTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                chickenTB.Text = "0";
            }
        }

        private void wrapCB_CheckedChanged(object sender, EventArgs e)
        {
            if (wrapCB.Checked == true)
            {
                wrapTB.Enabled = true;
            }
            else
            {
                wrapTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                wrapTB.Text = "0";
            }
        }

        private void teaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (teaCB.Checked == true)
            {
                teaTB.Enabled = true;
            }
            else
            {
                teaTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                teaTB.Text = "0";
            }
        }

        private void coffeeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (coffeeCB.Checked == true)
            {
                coffeeTB.Enabled = true;
            }
            else
            {
                coffeeTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                coffeeTB.Text = "0";
            }
        }

        private void waterCB_CheckedChanged(object sender, EventArgs e)
        {
            if (waterCB.Checked == true)
            {
                waterTB.Enabled = true;
            }
            else
            {
                waterTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                waterTB.Text = "0";
            }
        }

        private void cocoaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (cocoaCB.Checked == true)
            {
                cocoaTB.Enabled = true;
            }
            else
            {
                cocoaTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                cocoaTB.Text = "0";
            }
        }

        private void juiceCB_CheckedChanged(object sender, EventArgs e)
        {
            if (juiceCB.Checked == true)
            {
                juiceTB.Enabled = true;
            }
            else
            {
                juiceTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                juiceTB.Text = "0";
            }
        }

        private void milkCB_CheckedChanged(object sender, EventArgs e)
        {
            if (milkCB.Checked == true)
            {
                milkTB.Enabled = true;
            }
            else
            {
                milkTB.Enabled = false;
                //this is done so that if an item is selected and a quantity
                //inputted, and then deselected, the item quantity will
                //revert to 0
                milkTB.Text = "0";
            }
        }

        private void closeLB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //set item prices
        double friesPrice = 50, burgerPrice = 60, saladPrice = 100, sandwichPrice = 80, chickenPrice = 50, wrapPrice = 35;
        double teaPrice = 35, coffeePrice = 50, waterPrice = 10, cocoaPrice = 55, juicePrice = 30, milkPrice = 25;
        //declare variables to hold total price for each item for adding later
        //(could also be done directly by adding the result of (inputted number * item price) to the subtotal
        double friesTotal, burgerTotal, saladTotal, sandwichTotal, chickenTotal, wrapTotal;
        double teaTotal, coffeeTotal, waterTotal, cocoaTotal, juiceTotal, milkTotal;
        //initialise subtotal as nill
        double subtotal = 0, tax, overallTotal;
        private void addButton_Click(object sender, EventArgs e)
        {
            //calculate total costs for each item
            //essentially, convert the text inputted to the menu to a double
            //and then multiply that number by the set price for that item
            //in a try-catch in case of invalid input - the original tutorial didn't do this, but
            //I don't have enough trust to not do it...
            try
            {
                //food items:
                friesTotal = friesPrice * Convert.ToDouble(friesTB.Text);
                burgerTotal = burgerPrice * Convert.ToDouble(burgerTB.Text);
                saladTotal = saladPrice * Convert.ToDouble(saladTB.Text);
                sandwichTotal = sandwichPrice * Convert.ToDouble(sandwichTB.Text);
                chickenTotal = chickenPrice * Convert.ToDouble(chickenTB.Text);
                wrapTotal = wrapPrice * Convert.ToDouble(wrapTB.Text);
                //drink items:
                teaTotal = teaPrice * Convert.ToDouble(teaTB.Text);
                coffeeTotal = coffeePrice * Convert.ToDouble (coffeeTB.Text);
                waterTotal = waterPrice * Convert.ToDouble(waterTB.Text);
                cocoaTotal = cocoaPrice * Convert.ToDouble(cocoaTB.Text);
                juiceTotal = juicePrice * Convert.ToDouble(juiceTB.Text);
                milkTotal = milkPrice * Convert.ToDouble(milkTB.Text);
                //assuming this doesn't fail, add items to receipt:
                //clear any past receipts:
                receiptTB.Clear();
                tax = 0;
                overallTotal = 0;
                //basic receipt format/styling
                receiptTB.AppendText(Environment.NewLine);
                receiptTB.AppendText("\t\tSWIFTY'S RESTAURANTS LTD" + Environment.NewLine);
                receiptTB.AppendText("\t\t*****************************"+Environment.NewLine);
                //add items to list
                //there's probably a more sophisticated way of doing this, but for now, this is how the tutorial recommends
                //(could possibly have a list of all possible items and iterate through it, but not sure if that's worth the iteration?)
                if(friesCB.Checked == true)
                {
                    //in future
                    //could change receipt so it reads as quantity ordered * price = total amount for that item
                    //would be fairly simple to do and would look more receipt-y :)
                    receiptTB.AppendText("\tFries:\t" + friesTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + friesTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                if(burgerCB.Checked == true)
                {
                    receiptTB.AppendText("\tBurgers:\t" + burgerTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + burgerTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                if (saladCB.Checked == true)
                {
                    receiptTB.AppendText("\tSalads:\t" + friesTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + saladTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                if (sandwichCB.Checked == true)
                {
                    receiptTB.AppendText("\tSandwiches:\t" + sandwichTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + sandwichTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                if (chickenCB.Checked == true)
                {
                    receiptTB.AppendText("\tChicken:\t" + chickenTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + chickenTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                if (wrapCB.Checked == true)
                {
                    receiptTB.AppendText("\tWraps:\t" + wrapTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + wrapTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                //drinks:
                if (teaCB.Checked == true)
                {
                    receiptTB.AppendText("\tTeas:\t" + teaTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + teaTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                if (coffeeCB.Checked == true)
                {
                    receiptTB.AppendText("\tCoffees:\t" + coffeeTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + coffeeTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                if (waterCB.Checked == true)
                {
                    receiptTB.AppendText("\tWater:\t" + waterTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + waterTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                if (cocoaCB.Checked == true)
                {
                    receiptTB.AppendText("\tCocoa:\t" + cocoaTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + cocoaTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                if (juiceCB.Checked == true)
                {
                    receiptTB.AppendText("\tJuice:\t" + juiceTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + juiceTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                if (milkCB.Checked == true)
                {
                    receiptTB.AppendText("\tMilk:\t" + milkTotal + " Points" + Environment.NewLine);
                    subtotal = subtotal + milkTotal;
                    subtotalPriceLB.Text = "" + subtotal;
                }
                //calculate tax
                tax = subtotal * 0.16;
                //update tax and total labels
                overallTotal = subtotal + tax;
                taxPriceLB.Text = tax.ToString();
                totalPriceLB.Text = overallTotal.ToString();
            }
            catch (Exception exception) {
                //show an alert to user if above failed
                //(it probably failed due to invalid input)
                MessageBox.Show("Please check all inputs are numbers");
            }

        }
    }
}