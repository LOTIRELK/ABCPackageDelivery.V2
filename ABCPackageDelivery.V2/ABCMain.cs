using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCPackageDelivery.V2
{
    public partial class ABCMain : MetroFramework.Forms.MetroForm
    {
        static void createOverNightReceiver(List<OverNightReceiver> overNightReceiverList)
        {

            OverNightReceiver ONR1 = new OverNightReceiver(23, .53, 444, 2, "Mary O Bryan", "12 GroveHill", "Naas", "Leinster", "HN123");
            OverNightReceiver ONR2 = new OverNightReceiver(22, .60, 333, 2.23, "Barry McDermot", "2 SunnyBeach", "Tralee", "Munster", "HB723");
            OverNightReceiver ONR3 = new OverNightReceiver(43, .63, 222, 1.43, "Aisling O Meara", "54 Oakwood Grove", "Limerick", "Munster", "HN143");

            overNightReceiverList.Add(ONR1);
            overNightReceiverList.Add(ONR2);
            overNightReceiverList.Add(ONR3);
            
        }

        static void createOverNightSender(List<OverNightSender> overNightSenderList)
        {

            OverNightSender ONS1 = new OverNightSender(23, .53, 444, 2, "Mick O Toole", "The Clare Glens", "Newport", "Munster", "NO823");
            OverNightSender ONS2 = new OverNightSender(22, .60, 333, 2.23, "Liam Flaherty", "39 Ballylanders", "Sligo", "Connaught", "ML102");
            OverNightSender ONS3 = new OverNightSender(43, .63, 222, 1.43, "Aoife Slattery", "87 Terrace View", "Cork", "Munster", "LW902");

            overNightSenderList.Add(ONS1);
            overNightSenderList.Add(ONS2);
            overNightSenderList.Add(ONS3);
        }
        static void createOverNightCourier(List<OverNightCourier> overNightCourierList)
        {
            OverNightCourier ONC1 = new OverNightCourier(43, .63, 222, 1.43, "Nigthline", "Patrick Harris", "Raheen Industrial", "Limerick", "Munster", "TW123");
            OverNightCourier ONC2 = new OverNightCourier(22, .60, 333, 2.23, "UPS", "Sarah Jane", "Unit 5a Limerick", "Limerick", "Munster", "DD123");
            overNightCourierList.Add(ONC1);
            overNightCourierList.Add(ONC2);
        }

        static void createTwoDaySender(List<TwoDaySender> twoDaySenderList)
        {
            TwoDaySender TDS1 = new TwoDaySender(12, .50, 904, 2, "Selena Burke", "355 The Grove", "Donegal", "Ulster", "YU773");
            TwoDaySender TDS2 = new TwoDaySender(6.83, .42, 843, 1.50, "Michael Bryant", "2 Oakwood Garden", "Templemore", "Munster", "TX890");
            TwoDaySender TDS3 = new TwoDaySender(20.71, .36, 506, 1, "Lara Croft", "12 Abbingdon", "England", "Surrey", "CW392");

            twoDaySenderList.Add(TDS1);
            twoDaySenderList.Add(TDS3);
            twoDaySenderList.Add(TDS2);

        }

        static void createTwoDayReceiver(List<TwoDayReceiver> twoDayReceiverList)
        {

            TwoDayReceiver TDR2 = new TwoDayReceiver(6.83, .42, 843, 1.50, "Billy Connolly", "12 Beechwood", "Waterford", "Leinster", "UJ89e");
            TwoDayReceiver TDR3 = new TwoDayReceiver(20.71, .36, 506, 1, "Lilly Gold", "12 Barry Lane", "Limerick", "Munster", "FW456");
            TwoDayReceiver TDR1 = new TwoDayReceiver(12, .50, 904, 2, "Matt Daly", "Clarington Ave", "Cork", "Munster", "UB092");

            twoDayReceiverList.Add(TDR1);
            twoDayReceiverList.Add(TDR2);
            twoDayReceiverList.Add(TDR3);

        }

        static void showTwoDayDeliveryDetails(List<TwoDayReceiver> twoDayReceiverList, List<TwoDaySender> twoDaySenderList)
        {
            Console.WriteLine("Two day delivery details");

            foreach (TwoDaySender p in twoDaySenderList)
            {
                foreach (TwoDayReceiver i in twoDayReceiverList)
                {
                    if (p.packageID == i.packageID)
                    {
                        p.displayPackageDetails(" ");
                        i.displayPackageDetails(" ");
                        double cost = p.CalculateCost();
                        
                        Console.WriteLine(Convert.ToString(cost));
                    }
                }
            }
        }

        static double getTwoDayDeliveryTotalCost(List<TwoDayReceiver> twoDayReceiverList, List<TwoDaySender> twoDaySenderList, double total)
        {
            total = 0;
           
            foreach (TwoDaySender p in twoDaySenderList)
            {
                foreach (TwoDayReceiver i in twoDayReceiverList)
                {
                    if (p.packageID == i.packageID)
                    {
                        double cost = p.CalculateCost();
                        total += cost;
                    }
                }
            }
            return total;
        }

        static double getOverNightDeliveryTotalCost(List<OverNightSender> overNightSenderList, List<OverNightReceiver> overNightReceiverList, List<OverNightCourier> overNightCourierList, double total)
        {
            total = 0;
           
            foreach (OverNightSender p in overNightSenderList)
            {
                foreach (OverNightReceiver i in overNightReceiverList)
                {
                    if (p.packageID == i.packageID)
                    {

                        foreach (OverNightCourier y in overNightCourierList)
                            if (p.packageID == y.packageID)
                            {
                                double courierCost = y.CalculateCost();
                                total += courierCost;
                            }
                            else
                            {
                                double cost = p.CalculateCost();
                                total += cost;
                            }

                    }
                }
            }
            return total;
        }

        static int getOverNightCount(List<OverNightSender> overNightSenderList, List<OverNightReceiver> overNightReceiverList, List<OverNightCourier> overNightCourierList, int total)
        {
            total = 0;

            foreach (OverNightSender p in overNightSenderList)
            {
                foreach (OverNightReceiver i in overNightReceiverList)
                {
                    if (p.packageID == i.packageID)
                    {

                        foreach (OverNightCourier y in overNightCourierList)
                            if (p.packageID == y.packageID)
                            {

                                total++;

                            }
                            else
                            {
                                total++;
                            }

                    }
                }
            }
            return total;
        }

        static int getTwoDayDeliveryCount(List<TwoDayReceiver> twoDayReceiverList, List<TwoDaySender> twoDaySenderList, int total)
        {
            total = 0;


            foreach (TwoDaySender p in twoDaySenderList)
            {
                foreach (TwoDayReceiver i in twoDayReceiverList)
                {
                    if (p.packageID == i.packageID)
                    {
                        total++;
                    }
                }
            }
            return total;
        }
        double totalCostTwoDay = 0;
        double totalOverNight = 0;
        int twoDayCounter = 0;
        int overNightCounter = 0;

        List<OverNightReceiver> overNightReceiverList = new List<OverNightReceiver>();
        List<OverNightSender> overNightSenderList = new List<OverNightSender>();
        List<OverNightCourier> overNightCourierList = new List<OverNightCourier>();
        List<TwoDaySender> twoDaySenderList = new List<TwoDaySender>();
        List<TwoDayReceiver> twoDayReceiverList = new List<TwoDayReceiver>();
        public ABCMain()
        {
            InitializeComponent();
        }

        private void mtCreateParcel_Click(object sender, EventArgs e)
        {
            listMain.Items.Clear();
            createOverNightSender(overNightSenderList);
            createOverNightReceiver(overNightReceiverList);
            createOverNightCourier(overNightCourierList);
            createTwoDaySender(twoDaySenderList);
            createTwoDayReceiver(twoDayReceiverList);
            MessageBox.Show("Parcels have been created in the system.", "Confirmation");
        }
        private void mtDisplayShippingDetails_Click(object sender, EventArgs e)
        {
           
                listMain.Items.Clear();
                listMain.Items.Add("---TWO-DAY DELIVERY DETAILS---");
                foreach (TwoDaySender p in twoDaySenderList)
                {
                    foreach (TwoDayReceiver i in twoDayReceiverList)
                    {
                        if (p.packageID == i.packageID)
                        {

                            listMain.Items.Add("SENDER: " + p.displayPackageDetails(" "));
                            listMain.Items.Add("RECEIVER: " + i.displayPackageDetails(" "));
                            double cost = p.CalculateCost();
                            cost = Math.Round(cost, 2);
                            listMain.Items.Add("COST: €" + Convert.ToString(cost));
                            listMain.Items.Add("");
                        }
                    }
                }
            bool checker = false;
            listMain.Items.Add("---OVERNIGHT DELIVERY DETAILS---");
            foreach (OverNightSender p in overNightSenderList)
            {
                foreach (OverNightReceiver i in overNightReceiverList)
                {
                    if (p.packageID == i.packageID)
                    {
                        foreach (OverNightCourier y in overNightCourierList)
                        {
                            if (p.packageID == y.packageID)
                            {
                                checker = true;
                                listMain.Items.Add("SENDER: " + i.displayPackageDetails(" "));
                                listMain.Items.Add("RECEIVER: " + p.displayPackageDetails(" "));
                                listMain.Items.Add("COURIER: " + y.displayPackageDetails(" "));
                                double courierCost = y.CalculateCost();
                                courierCost = Math.Round(courierCost, 2);
                                listMain.Items.Add(Convert.ToString("COST: €" + Convert.ToString(courierCost)));
                                listMain.Items.Add("");
                            }
                        }
                        if(checker!=true)
                        {
                            if (p.packageID == i.packageID)
                            {
                                listMain.Items.Add("SENDER: " + i.displayPackageDetails(" "));
                                listMain.Items.Add("RECEIVER: " + p.displayPackageDetails(" "));
                                double cost = p.CalculateCost();
                                cost = Math.Round(cost);
                                listMain.Items.Add(Convert.ToString("COST: €" + Convert.ToString(cost)));
                                listMain.Items.Add("");
                            }
                        }
                    }
                }
                //break here
            }
           }
        

        private void mtCostAnalysis_Click(object sender, EventArgs e)
        {
            listMain.Items.Clear(); 
            double totalTwoDayCost = getTwoDayDeliveryTotalCost(twoDayReceiverList, twoDaySenderList, totalCostTwoDay);
            double totalOverNightCost = getOverNightDeliveryTotalCost(overNightSenderList, overNightReceiverList, overNightCourierList, totalOverNight);
            double totalCost = totalTwoDayCost + totalOverNightCost;
            totalCost = Math.Round(totalCost, 2);
            totalOverNightCost = Math.Round(totalOverNightCost, 2);
            totalTwoDayCost = Math.Round(totalTwoDayCost, 2);
            int totalOverNightCount = getOverNightCount(overNightSenderList, overNightReceiverList, overNightCourierList, overNightCounter);
            int totalTwoNightCount = getTwoDayDeliveryCount(twoDayReceiverList, twoDaySenderList, twoDayCounter);
            int totalCount = totalOverNightCount + totalTwoNightCount;

            double overNightPercentage = totalOverNightCost * 100 / totalCost;
            double twoDayPercentage = totalTwoDayCost * 100 / totalCost;

            listMain.Items.Add("Total delivery cost: €" + totalCost);
            listMain.Items.Add("Total overnight cost: €" + totalOverNightCost);
            listMain.Items.Add("Total overnight percentage: " + Math.Round(overNightPercentage, 2) + "%");
            listMain.Items.Add("Total two day cost: €" + totalTwoDayCost);
            listMain.Items.Add("Total two day percentage: " + Math.Round(twoDayPercentage, 2) + "%");
        }

        private void mtDisplayCourierDetails_Click(object sender, EventArgs e)
        {
            listMain.Items.Clear();
            listMain.Items.Add("---COURIER DETAILS---");
            foreach (OverNightCourier c in overNightCourierList)
            {
                listMain.Items.Add(c.displayPackageDetails(" "));
            }
        }

        private void mt_Click(object sender, EventArgs e)
        {
           DialogResult result =MessageBox.Show("Are you sure you wish to close the application?",
                            "Important Question",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if(result ==DialogResult.Yes)
            this.Close();
        }
    }
}
