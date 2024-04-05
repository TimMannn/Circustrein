using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Trein
    {
        int Reset = 0;
        bool Skip = false;
        private int WagonPoints { get; set; }

        public int WagonCount { get; set; }

        private Form1 form1;

        public List<Trein> Wagon = new List<Trein>();

        public Trein(int _WagonCount)
        {
            WagonCount = _WagonCount;
        }

        public Trein()
        {
            
        }

        public Trein(Form1 form1)
        {
            this.form1 = form1;
        }

        public void FillWagon(int NumberLargeMeat, int NumberMediumMeat, int NumberSmallMeat, int NumberLargePlants, int NumberMediumPlants, int NumberSmallPlants, Form1 form1)
        {
            form1.label3.Text = "LargeMeat: " + NumberLargeMeat.ToString();
            form1.label4.Text = "MediumMeat: " + NumberMediumMeat.ToString();
            form1.label5.Text = "SmallMeat: " + NumberSmallMeat.ToString();
            form1.label6.Text = "LargePlants: " + NumberLargePlants.ToString();
            form1.label7.Text = "MediumPlants: " + NumberMediumPlants.ToString();
            form1.label8.Text = "SmallPlants: " + NumberSmallPlants.ToString();

            WagonPoints = 0;
            
            for (int LM = 0; LM != NumberLargeMeat; NumberLargeMeat--)
            {
                Wagon.Add(new Trein(WagonPoints));
                WagonCount++;
                form1.label2.Text = "Wagons: " + WagonCount.ToString();
            }
            
            for (int MM = 0; MM != NumberMediumMeat; NumberMediumMeat--)
            {
                Wagon.Add(new Trein(WagonPoints));
                WagonCount++;
                form1.label2.Text = "Wagons: " + WagonCount.ToString();

                if (NumberLargePlants != 0)
                {
                    NumberLargePlants--;
                }
            }
            
            for (int SM = 0; SM != NumberSmallMeat; NumberSmallMeat--)
            {
                WagonPoints = ((int)Dieren.SizeOptions.Small) + WagonPoints;
                Wagon.Add(new Trein(WagonPoints));
                WagonCount++;
                form1.label2.Text = "Wagons: " + WagonCount.ToString();

                if (NumberMediumPlants >= 3)
                {
                    Skip = true;
                }

                if (NumberLargePlants >= 1 && NumberMediumPlants >= 1 && Skip == false)
                {
                    WagonPoints = ((int)Dieren.SizeOptions.Large) + WagonPoints;
                    WagonPoints = ((int)Dieren.SizeOptions.Medium) + WagonPoints;
                    NumberLargePlants--;
                    NumberMediumPlants--;
                }

                Skip = false;

                if (NumberMediumPlants >= 1 && WagonPoints <= 7)
                {
                    for (int MP = 0; MP != NumberMediumPlants; NumberMediumPlants--)
                    {
                        WagonPoints = ((int)Dieren.SizeOptions.Medium) + WagonPoints;
                        if (WagonPoints == 10)
                        {
                            NumberMediumPlants--;
                            break;
                        }
                    }
                }

                if (WagonPoints <= 5 && NumberLargePlants >= 1)
                {
                    NumberLargePlants--;
                }
                WagonPoints = Reset;
            }
            
            for (int LP = 0; LP != NumberLargePlants; NumberLargePlants--)
            {
                
                if (WagonPoints == 0)
                {
                    Wagon.Add(new Trein(WagonPoints));
                    WagonCount++;
                    form1.label2.Text = "Wagons: " + WagonCount.ToString();
                }
                    WagonPoints = ((int)Dieren.SizeOptions.Large) + WagonPoints;

                if (WagonPoints <= 7 && NumberMediumPlants != 0)
                {
                    WagonPoints = ((int)Dieren.SizeOptions.Medium) + WagonPoints;
                    NumberMediumPlants--;
                }

                if (WagonPoints < 10 && NumberSmallPlants != 0)
                {
                    for (int SP = 0; SP != NumberSmallPlants; NumberSmallPlants--)
                    {
                        WagonPoints = ((int)Dieren.SizeOptions.Small) + WagonPoints;
                        if (WagonPoints == 10)
                        {
                            NumberSmallPlants--;
                            break;
                        }
                    }
                }
                if (WagonPoints == 10)
                {
                    WagonPoints = Reset;
                }
            }

            for (int MP = 0; MP != NumberMediumPlants; NumberMediumPlants--)
            {
                if (WagonPoints == 0)
                {
                    Wagon.Add(new Trein(WagonPoints));
                    WagonCount++;
                    form1.label2.Text = "Wagons: " + WagonCount.ToString();
                }

                WagonPoints = ((int)Dieren.SizeOptions.Medium) + WagonPoints;

                if (NumberMediumPlants == 0 || WagonPoints == 9)
                {
                    for (int SP = 0; SP != NumberSmallPlants; NumberSmallPlants--)
                    {
                        WagonPoints = ((int)Dieren.SizeOptions.Small) + WagonPoints;
                        if (WagonPoints == 10)
                        {
                            NumberSmallPlants--;
                            break;
                        }
                    }
                }

                if (WagonPoints == 10)
                {
                    WagonPoints = Reset;
                }
            } 
            
            for (int SP = 0; SP != NumberSmallPlants; NumberSmallPlants--)
            {
                if (WagonPoints == 0)
                {
                    Wagon.Add(new Trein(WagonPoints));
                    WagonCount++;
                    form1.label2.Text = "Wagons: " + WagonCount.ToString();
                }

                WagonPoints = ((int)Dieren.SizeOptions.Small) + WagonPoints;

                if (WagonPoints == 10)
                {
                    WagonPoints = Reset;
                }
            } 
        }
    }
}
