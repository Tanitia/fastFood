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
    }
}