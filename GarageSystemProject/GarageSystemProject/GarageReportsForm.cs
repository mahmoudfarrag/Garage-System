using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GarageSystemProject
{
    public partial class GarageReportsForm : Form
    {
        public GarageReportsForm()
        {
            InitializeComponent();
        }

        private void GarageReportsForm_Load(object sender, EventArgs e)
        {
            fillComboBoxGarages();
            comboBoxReportTypes.SelectedIndex = 0;
        }
        public void fillComboBoxGarages()
        {
            comboBoxGarages.DisplayMember = nameof(Garage.Name);
            comboBoxGarages.DataSource = SystemData.Garages.ToList();
        }

        private void buttonShowReport_Click(object sender, EventArgs e)
        {
            Garage selectedGarage = (Garage)comboBoxGarages.SelectedItem;
            if (selectedGarage == null)
            {
                MessageBox.Show("There's no garages in the system");
                return;
            }
            dataGridViewEnterOutVehiclesReport.Visible = false;
            dataGridViewVehiclesTypesAndCost.Visible = false;
            dataGridViewCrowdTimes.Visible = false;
            labelTotalProfits.Visible = false;
            labelMaxNumOFVehicles.Visible = false;
            labelMinNumOFVehicles.Visible = false;
            if ((string) comboBoxReportTypes.SelectedItem == "All Vehicles")
            {
                ShowAllVehiclesReport(selectedGarage);
            }
            else if((string)comboBoxReportTypes.SelectedItem == "All Vehicles Types And Cost")
            {
                ShowAllVehiclesTypesAndCostReport(selectedGarage);
            }
            else if ((string)comboBoxReportTypes.SelectedItem == "Crowd Times")
            {
                showCrowdTimesReport(selectedGarage);
            }
        }

        private void showCrowdTimesReport(Garage selectedGarage)
        {
            dataGridViewCrowdTimes.Rows.Clear();
            int[] periodsByNumOfCars = new int[4];
            double[] periodsByProfits = new double[4];
            string[] periods = new string[4] 
            {
                "12 am - 06 am",
                "06 am - 12 pm",
                "12 pm - 06 pm",
                "06 pm - 12 am"
            };
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            if (selectedGarage.countOfVehicleEnterOutDetails != 0)
            {
                dataGridViewCrowdTimes.Visible = true;
                labelMaxNumOFVehicles.Visible = true;
                labelMinNumOFVehicles.Visible = true;
                labelMaxProfits.Visible = true;
                labelMinProfits.Visible = true;
                foreach (VehicleEnterOutDetails vehicleEnterOutDetails in selectedGarage.VehicleEnterOutDetails)
                {
                    if (vehicleEnterOutDetails.EnterDate.Date >= startDate.Date && vehicleEnterOutDetails.EnterDate.Date <= endDate.Date)
                    {
                        if (vehicleEnterOutDetails.EnterDate.Hour >= 0 && vehicleEnterOutDetails.EnterDate.Hour < 6)
                        {
                            periodsByNumOfCars[0]++;
                            (string totTime, double totCost) = computeTotHoursAndCost(vehicleEnterOutDetails);
                            periodsByProfits[0] += totCost;
                        }
                            
                        if (vehicleEnterOutDetails.EnterDate.Hour >= 6 && vehicleEnterOutDetails.EnterDate.Hour < 12)
                        {
                            periodsByNumOfCars[1]++;
                            (string totTime, double totCost) = computeTotHoursAndCost(vehicleEnterOutDetails);
                            periodsByProfits[1] += totCost;
                        }
                        if (vehicleEnterOutDetails.EnterDate.Hour >= 12 && vehicleEnterOutDetails.EnterDate.Hour < 18)
                        {
                            periodsByNumOfCars[2]++;
                            (string totTime, double totCost) = computeTotHoursAndCost(vehicleEnterOutDetails);
                            periodsByProfits[2] += totCost;
                        }
                            
                        if (vehicleEnterOutDetails.EnterDate.Hour >= 18 && vehicleEnterOutDetails.EnterDate.Hour < 23)
                        {
                            periodsByNumOfCars[3]++;
                            (string totTime, double totCost) = computeTotHoursAndCost(vehicleEnterOutDetails);
                            periodsByProfits[3] += totCost;
                        }
                    }
                }
                dataGridViewCrowdTimes.Rows.Add();
                dataGridViewCrowdTimes.Rows[0].Cells[0].Value = "Number of Vehicles";
                dataGridViewCrowdTimes.Rows[0].Cells[1].Value = periodsByNumOfCars[0];
                dataGridViewCrowdTimes.Rows[0].Cells[2].Value = periodsByNumOfCars[1];
                dataGridViewCrowdTimes.Rows[0].Cells[3].Value = periodsByNumOfCars[2];
                dataGridViewCrowdTimes.Rows[0].Cells[4].Value = periodsByNumOfCars[3];

                dataGridViewCrowdTimes.Rows.Add();
                dataGridViewCrowdTimes.Rows[1].Cells[0].Value = "Profits";
                dataGridViewCrowdTimes.Rows[1].Cells[1].Value = periodsByProfits[0];
                dataGridViewCrowdTimes.Rows[1].Cells[2].Value = periodsByProfits[1];
                dataGridViewCrowdTimes.Rows[1].Cells[3].Value = periodsByProfits[2];
                dataGridViewCrowdTimes.Rows[1].Cells[4].Value = periodsByProfits[3];

                int maxValByNumOfCars = periodsByNumOfCars.Max();
                int indexMax = Array.IndexOf(periodsByNumOfCars, maxValByNumOfCars);
                int minValByNumOfCars = periodsByNumOfCars.Min();
                int indexMin = Array.IndexOf(periodsByNumOfCars, minValByNumOfCars);
                labelMaxNumOFVehicles.Text = "Max number of vehicles :" + periods[indexMax];
                labelMinNumOFVehicles.Text = "Min number of vehicles :" + periods[indexMin];

                double maxValByprofits = periodsByProfits.Max();
                int indexMaxProfit = Array.IndexOf(periodsByProfits, maxValByprofits);
                double minValByprofits = periodsByProfits.Min();
                int indexMinProfit = Array.IndexOf(periodsByProfits, minValByprofits);
                labelMaxProfits.Text = "Max Profit :" + periods[indexMaxProfit];
                labelMinProfits.Text = "Min Profit :" + periods[indexMinProfit];
            }
            else
            {
                MessageBox.Show("No Vehicles Entered This Garage Yet");
            }
        }

        private void ShowAllVehiclesTypesAndCostReport(Garage selectedGarage)
        {
            if (selectedGarage.countOfVehicleEnterOutDetails != 0)
            {


                int currentRow = 0;
                dataGridViewVehiclesTypesAndCost.Visible = true;
                labelTotalProfits.Visible = true;
                dataGridViewVehiclesTypesAndCost.Rows.Clear();
                double totalGarageProfits = 0;
                foreach (VehicleType vehicleType in SystemData.VehicleTypes)
                {
                    string vehicleTypeName = vehicleType.Name;
                    int typeCostPerHour = vehicleType.CostPerHour;
                    dataGridViewVehiclesTypesAndCost.Rows.Add();
                    dataGridViewVehiclesTypesAndCost.Rows[currentRow].Cells[0].Value = vehicleType;
                    dataGridViewVehiclesTypesAndCost.Rows[currentRow].Cells[2].Value = typeCostPerHour;
                    int numOfVehicle = 0;
                    double totalProfitsForVehicleType = 0;
                    foreach (VehicleEnterOutDetails vehicleEnterOutDetails in selectedGarage.VehicleEnterOutDetails)
                    {
                        if (vehicleEnterOutDetails.Vehicle.Type.Name == vehicleTypeName)
                        {
                            (string totTime, double totCost) = computeTotHoursAndCost(vehicleEnterOutDetails);
                            totalProfitsForVehicleType += totCost;
                            numOfVehicle++;
                        }
                    }
                    dataGridViewVehiclesTypesAndCost.Rows[currentRow].Cells[1].Value = numOfVehicle;
                    dataGridViewVehiclesTypesAndCost.Rows[currentRow].Cells[3].Value = totalProfitsForVehicleType;
                    totalGarageProfits += totalProfitsForVehicleType;
                    currentRow++;
                }
                labelTotalProfits.Text = $"Total Garage Profits: {totalGarageProfits}";
                dataGridViewCrowdTimes.Rows.Clear();
            }
            else
            {
                MessageBox.Show("No Vehicles Entered This Garage Yet");
            }
        }
        private void ShowAllVehiclesReport(Garage selectedGarage)
        {
            
            int currentRow = 0;
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            if(selectedGarage.countOfVehicleEnterOutDetails != 0)
            {
                dataGridViewEnterOutVehiclesReport.Visible = true;
                dataGridViewEnterOutVehiclesReport.Rows.Clear();
                foreach (VehicleEnterOutDetails vehicleEnterOutDetails in selectedGarage.VehicleEnterOutDetails)
                {
                    if (vehicleEnterOutDetails.EnterDate.Date >= startDate.Date && vehicleEnterOutDetails.EnterDate.Date <= endDate.Date)
                    {
                        dataGridViewEnterOutVehiclesReport.Rows.Add();
                        dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[0].Value = vehicleEnterOutDetails.Vehicle.Name;
                        dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[1].Value = vehicleEnterOutDetails.Vehicle.Number;
                        dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[2].Value = vehicleEnterOutDetails.Vehicle.Type;
                        dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[3].Value = vehicleEnterOutDetails.Vehicle.Color;
                        dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[4].Value = vehicleEnterOutDetails.Vehicle.vehicleOwner.Name;
                        dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[5].Value = vehicleEnterOutDetails.Vehicle.vehicleOwner.NID;
                        dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[6].Value = vehicleEnterOutDetails.Vehicle.vehicleOwner.Address;
                        dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[7].Value = vehicleEnterOutDetails.EnterDate;
                        // compute cost and hours
                        (string totTime, double totCost) = computeTotHoursAndCost(vehicleEnterOutDetails);
                        if (vehicleEnterOutDetails.ExitDate != null)
                            dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[8].Value = vehicleEnterOutDetails.ExitDate;
                        else
                            dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[8].Value = "This Car Still in Garage";
                      
                        dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[9].Value = totTime;
                        dataGridViewEnterOutVehiclesReport.Rows[currentRow].Cells[10].Value = totCost;

                        currentRow++;
                    }

                }
            }
            else
            {
                MessageBox.Show("No Vehicles Entered This Garage Yet");
            }
            
        }
        
        private (string totTime, double totCost) computeTotHoursAndCost(VehicleEnterOutDetails vehicleEnterOutDetails)
        {
            TimeSpan diffTime;
            int costPerHour = vehicleEnterOutDetails.Vehicle.Type.CostPerHour;
            if (vehicleEnterOutDetails.ExitDate == null)
                diffTime = (DateTime.Now - vehicleEnterOutDetails.EnterDate);
            else
                diffTime = (TimeSpan)(vehicleEnterOutDetails.ExitDate - vehicleEnterOutDetails.EnterDate);

            double days = Math.Floor(diffTime.TotalDays);
            double totHours = diffTime.Hours + (days * 24);
            double minutes = diffTime.Minutes;
            string totTime = $"{totHours}h {minutes}m";
            double totCost = Math.Round( (totHours + minutes/60 ) * costPerHour);
            return (totTime, totCost);
        }
    }
}
