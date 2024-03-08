namespace Circustrein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String Size = "none";
        String Eats = "none";
        int Amount;
        int NumberLargeMeat;
        int NumberMediumMeat;
        int NumberSmallMeat;
        int NumberLargePlants;
        int NumberMediumPlants;
        int NumberSmallPlants;
        int WagonPoints;
        int WagonCount = 0;

        List<Dieren> dier = new List<Dieren>();

        private void checkBoxSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSmall.Checked == true)
            {
                Size = "Small";
                checkBoxMedium.Checked = false;
                checkBoxLarge.Checked = false;
            }
        }

        private void checkBoxMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMedium.Checked == true)
            {
                Size = "Medium";
                checkBoxSmall.Checked = false;
                checkBoxLarge.Checked = false;
            }
        }

        private void checkBoxLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLarge.Checked == true)
            {
                Size = "Large";
                checkBoxSmall.Checked = false;
                checkBoxMedium.Checked = false;
            }
        }

        private void checkBoxMeat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMeat.Checked == true)
            {
                Eats = "Meat";
                checkBoxPlants.Checked = false;
            }
        }

        private void checkBoxPlants_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlants.Checked == true)
            {
                Eats = "Plants";
                checkBoxMeat.Checked = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (checkBoxSmall.Checked != true && checkBoxMedium.Checked != true && checkBoxLarge.Checked != true)
            {
                Size = "none";
            }

            if (checkBoxMeat.Checked != true && checkBoxPlants.Checked != true)
            {
                Eats = "none";
            }

            if (Size == "none" || Eats == "none")
            {
                MessageBox.Show("Please fill in size and food", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Amount = ((int)numericUpDownAmount.Value);
                AddItemToList();
                SortAnimals();
            }
        }

        void AddItemToList()
        {
            ListViewItem List = new ListViewItem(Size);
            List.SubItems.Add(Eats);
            List.SubItems.Add(Amount.ToString());
            listView1.Items.AddRange(new ListViewItem[] { List });
        }

        void SortAnimals()
        {
            if (Size == "Large" && Eats == "Meat")
            {
                NumberLargeMeat = Amount + NumberLargeMeat;
            }

            if (Size == "Medium" && Eats == "Meat")
            {
                NumberMediumMeat = Amount + NumberMediumMeat;
            }

            if (Size == "Small" && Eats == "Meat")
            {
                NumberSmallMeat = Amount + NumberSmallMeat;
            }

            if (Size == "Large" && Eats == "Plants")
            {
                NumberLargePlants = Amount + NumberLargePlants;
            }

            if (Size == "Medium" && Eats == "Plants")
            {
                NumberMediumPlants = Amount + NumberMediumPlants;
            }

            if (Size == "Small" && Eats == "Plants")
            {
                NumberSmallPlants = Amount + NumberSmallPlants;
            }
        }

        void CreateAnimalList(int NumberLargeMeat, int NumberMediumMeat, int NumberSmallMeat, int NumberLargePlants, int NumberMediumPlants, int NumberSmallPlants)
        {
            for (int i = 0; i < NumberLargeMeat; i++)
            {
                dier.Add(new Dieren(Dieren.SizeOptions.Large, Dieren.EatOptions.Meat));
            }

            for (int i = 0; i < NumberMediumMeat; i++)
            {
                dier.Add(new Dieren(Dieren.SizeOptions.Medium, Dieren.EatOptions.Meat));
            }

            for (int i = 0; i < NumberSmallMeat; i++)
            {
                dier.Add(new Dieren(Dieren.SizeOptions.Small, Dieren.EatOptions.Meat));
            }

            for (int i = 0; i < NumberLargePlants; i++)
            {
                dier.Add(new Dieren(Dieren.SizeOptions.Large, Dieren.EatOptions.Plants));
            }

            for (int i = 0; i < NumberMediumPlants; i++)
            {
                dier.Add(new Dieren(Dieren.SizeOptions.Medium, Dieren.EatOptions.Plants));
            }

            for (int i = 0; i < NumberSmallPlants; i++)
            {
                dier.Add(new Dieren(Dieren.SizeOptions.Small, Dieren.EatOptions.Plants));
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            CreateAnimalList(NumberLargeMeat, NumberMediumMeat, NumberSmallMeat, NumberLargePlants, NumberMediumPlants, NumberSmallPlants);
            Trein trein = new Trein(this);
            trein.FillWagon(NumberLargeMeat, NumberMediumMeat, NumberSmallMeat, NumberLargePlants, NumberMediumPlants, NumberSmallPlants);
        }
    }
}