using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace gui
{
    /**
     * This form allows the user to enter desired filters on an interactive way
     */
    public partial class DataReader : Form
    {
        //stores the data rows
        private List<Data> data;

        /**
         * DataReader constructor : initiliazes the form
         */
        public DataReader()
        {
            InitializeComponent();
        }

        /**
         * Shows a warning message to user in the case that there isn't enough information to do the query
         */
        private void ShowGeneralWarning()
        {

            MessageBox.Show("You need to enter the complete criteria to request the filtering" +
                "of data you want to search",
                "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /**
         * Shows a warning message to user when requesting amount of data
         */
        private void showLimitWarning()
        {

            MessageBox.Show("The limit must be a multiple of the amount of data you requesting",
                "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        /**
         * Shows a confirmation message when data processing is successful
         */
        private void showConfirmation()
        {
            MessageBox.Show("The processing of the data by the recopilation dates has been successful");

        }

        /**
         * Launches a new form to show the results done with the current query
        */
        private void LaunchResults(String value, Boolean column)
        {
            DataFilter datafilter = new DataFilter();

            if (!column)
            {
                datafilter.FillDataGridView(data);
                datafilter.ShowDialog();
            }
            else
            {
                datafilter.FillDataGridViewColumn(value, data);
                datafilter.ShowDialog();
            }
        }

        /**
         * Triggered event caused by the user. Filter the information on the json according to the 
         * criteria entered.
         */
        private void Filter_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                 * gets all information entered on the form
                 */
                User user = new User();

                String request = User.URL;

                String specifiedvaluefordate = this.specifiedvaluefordate.Text;
                String datevalue = this.datevalue.Text;

                String specifiedvalueforenviromentalauthority = this.specifiedvalueforenviromentalauthority.Text;
                String enviromentalauthorityvalue = this.enviromentalauthorityvalue.Text;

                String specifiedvalueforstationname = this.specifiedvalueforstationname.Text;
                String stationnamevalue = this.stationnamevalue.Text;

                String specifiedvaluefortechnology = this.specifiedvaluefortechnology.Text;
                String technologyvalue = this.technologyvalue.Text;

                String specifiedvalueforlatitude = this.specifiedvalueforlatitude.Text;
                String latitudecondition = this.latitudecondition.Text;
                String latitudevalue = this.latitudevalue.Text;

                String specifiedvalueforlongitude = this.specifiedvalueforlongitude.Text;
                String longitudecondition = this.longitudecondition.Text;
                String longitudevalue = this.longitudevalue.Text;

                String specifiedvaluefordepname = this.specifiedvaluefordepname.Text;
                String depnamevalue = this.depnamevalue.Text;

                String specifiedvaluefordepcode = this.specifiedvaluefordepcode.Text;
                String depcodevalue = this.depcodevalue.Text;

                String specifiedvalueformunname = this.specifiedvalueformunname.Text;
                String munnamevalue = this.munnamevalue.Text;

                String specifiedvalueformuncode = this.specifiedvalueformuncode.Text;
                String muncodevalue = this.muncodevalue.Text;

                String specifiedvaluefortypeofstation = this.specifiedvaluefortypeofstation.Text;
                String typeofstationvalue = this.typeofstationvalue.Text;

                String specifiedvalueforexhibitiontime = this.specifiedvalueforexhibitiontime.Text;
                String exhibitiontimecondition = this.exhibitiontimecondition.Text;
                String exhibitiontimevalue = this.exhibitiontimevalue.Text;

                String specifiedvalueforvariable = this.specifiedvalueforvariable.Text;
                String variablevalue = this.variablevalue.Text;

                String specifiedvalueforunits = this.specifiedvalueforunits.Text;
                String unitsvalue = this.unitsvalue.Text;

                String specifiedvalueforconcentration = this.specifiedvalueforconcentration.Text;
                String concentrationcondition = this.concentrationcondition.Text;
                String concentrationvalue = this.concentrationvalue.Text;

                String selectedcolumn = this.columnsfilter.Text;

                Boolean selected = false;
                
                /**
                 * checks if a column that has been selected has the proper value to do the query
                 */
                if ((specifiedvaluefordate.Equals("date") && datevalue.Equals(""))
                    || (specifiedvalueforenviromentalauthority.Equals("enviromental authority") && (enviromentalauthorityvalue.Equals("")))
                    || (specifiedvaluefortechnology.Equals("technology") && technologyvalue.Equals(""))
                    || (specifiedvalueforlatitude.Equals("latitude") && latitudevalue.Equals(""))
                    || (specifiedvalueforlongitude.Equals("longitude") && longitudevalue.Equals(""))
                    || (specifiedvalueforstationname.Equals("station name") && stationnamevalue.Equals(""))
                    || (specifiedvaluefordepname.Equals("department code") && depnamevalue.Equals(""))
                    || (specifiedvaluefordepcode.Equals("department name") && depcodevalue.Equals(""))
                    || (specifiedvalueformunname.Equals("municipality name") && munnamevalue.Equals(""))
                    || (specifiedvalueformuncode.Equals("municipality code") && muncodevalue.Equals(""))
                    || (specifiedvaluefortypeofstation.Equals("type of station") && typeofstationvalue.Equals(""))
                    || (specifiedvalueforexhibitiontime.Equals("exhibition time") && exhibitiontimevalue.Equals(""))
                    || (specifiedvalueforvariable.Equals("variable") && variablevalue.Equals(""))
                    || (specifiedvalueforunits.Equals("units") && unitsvalue.Equals(""))
                    || (specifiedvalueforconcentration.Equals("concentration") && concentrationvalue.Equals("")))
                {
                    ShowGeneralWarning();
                }
                /**
                 * Checks the information entered in order to apply the correct filters provided by the API of the dataset
                 */
                else
                {
                    if (this.amount.Text.Equals("") == false)
                    {
                        request += User.Limit + Convert.ToDouble(this.amount.Text);
                    }

                    if (specifiedvaluefordate.Equals("date"))
                    {
                        request += User.Addition + User.date + datevalue.Replace(" ", User.Space);
                    }

                    if (specifiedvalueforenviromentalauthority.Equals("enviromental authority"))
                    {
                        request += User.Addition + User.enviromentalauthority + enviromentalauthorityvalue.Replace(" ", User.Space);
                    }

                    if (specifiedvalueforstationname.Equals("station name"))
                    {
                        request += User.Addition + User.stationname + stationnamevalue.Replace(" ", User.Space);
                    }

                    if (specifiedvaluefortechnology.Equals("technology"))
                    {
                        request += User.Addition + User.technology + technologyvalue;
                    }

                    if (specifiedvalueforlatitude.Equals("latitude"))
                    {
                        if (latitudecondition.Equals("Less than"))
                        {
                            request += User.Addition + User.Condition + User.latitude.Replace(User.latitude.Last(), '<') + latitudevalue;
                        }

                        else if (latitudecondition.Equals("Bigger than"))
                        {
                            request += User.Addition + User.Condition + User.latitude.Replace(User.latitude.Last(), '>') + latitudevalue;
                        }

                        else
                        {
                            request += User.Addition + User.latitude + latitudevalue;
                        }
                    }

                    if (specifiedvalueforlongitude.Equals("longitude"))
                    {
                        if (longitudecondition.Equals("Less than"))
                        {
                            request += User.Addition + User.Condition + User.longitude.Replace(User.longitude.Last(), '<') + longitudevalue;
                        }

                        else if (longitudecondition.Equals("Bigger than"))
                        {
                            request += User.Addition + User.Condition + User.longitude.Replace(User.longitude.Last(), '>') + longitudevalue;
                        }

                        else
                        {
                            request += User.Addition + User.longitude + longitudevalue;
                        }
                    }

                    if (specifiedvaluefordepname.Equals("department name"))
                    {
                        request += User.Addition + User.departmentname + depnamevalue.Replace(" ", User.Space);
                    }

                    if (specifiedvaluefordepcode.Equals("department code"))
                    {
                        request += User.Addition + User.departmentcode + depcodevalue;
                    }

                    if (specifiedvalueformunname.Equals("municipality name"))
                    {
                        request += User.Addition + User.municipalityname + munnamevalue.Replace(" ", User.Space);
                    }

                    if (specifiedvalueformuncode.Equals("municipality code"))
                    {
                        request += User.Addition + User.municipalitycode + muncodevalue;
                    }

                    if (specifiedvaluefortypeofstation.Equals("type of station"))
                    {
                        request += User.Addition + User.typeofstation + typeofstationvalue;
                    }

                    if (specifiedvalueforexhibitiontime.Equals("exhibition time"))
                    {
                        if (exhibitiontimecondition.Equals("Less than"))
                        {
                            request += User.Addition + User.Condition + User.exhibitiontime.Replace(User.exhibitiontime.Last(), '<')
                                + exhibitiontimevalue;
                        }

                        else if (exhibitiontimecondition.Equals("Bigger than"))
                        {
                            request += User.Addition + User.Condition + User.exhibitiontime.Replace(User.exhibitiontime.Last(), '>')
                                + exhibitiontimevalue;
                        }

                        else
                        {
                            request += User.Addition + User.exhibitiontime + exhibitiontimevalue;
                        }
                    }

                    if (specifiedvalueforvariable.Equals("variable"))
                    {
                        request += User.Addition + User.variable + variablevalue.Replace(" ", User.Space);
                    }

                    if (specifiedvalueforunits.Equals("units"))
                    {
                        request += User.Addition + User.units + unitsvalue;
                    }

                    if (specifiedvalueforconcentration.Equals("concentration"))
                    {
                        if (concentrationcondition.Equals("Less than"))
                        {
                            request += User.Addition + User.Condition + User.concentration.Replace(User.concentration.Last(), '<')
                                + concentrationvalue;
                        }

                        else if (concentrationcondition.Equals("Bigger than"))
                        {
                            request += User.Addition + User.Condition + User.concentration.Replace(User.concentration.Last(), '>')
                                + concentrationvalue;
                        }

                        else
                        {
                            request += User.Addition + User.concentration + concentrationvalue;
                        }
                    }
                    /**
                     * Checks if the user wants to show one column
                     */
                    if (selectedcolumn.Equals("") == false)
                    {
                        selected = true;

                        if (selectedcolumn.Equals("Date"))
                        {
                            request += User.Addition + User.Selected + User.date.Replace(User.date.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Enviromental authority"))
                        {
                            request += User.Addition + User.Selected + User.enviromentalauthority.Replace(User.enviromentalauthority.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Station name"))
                        {
                            request += User.Addition + User.Selected + User.stationname.Replace(User.stationname.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Technology"))
                        {
                            request += User.Addition + User.Selected + User.technology.Replace(User.technology.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Latitude"))
                        {
                            request += User.Addition + User.Selected + User.latitude.Replace(User.latitude.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Longitude"))
                        {
                            request += User.Addition + User.Selected + User.longitude.Replace(User.longitude.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Department name"))
                        {
                            request += User.Addition + User.Selected + User.departmentname.Replace(User.departmentname.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Department code"))
                        {
                            request += User.Addition + User.Selected + User.departmentcode.Replace(User.departmentcode.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Municipality name"))
                        {
                            request += User.Addition + User.Selected + User.municipalityname.Replace(User.municipalityname.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Municipality code"))
                        {
                            request += User.Addition + User.Selected + User.municipalitycode.Replace(User.municipalitycode.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Type of station"))
                        {
                            request += User.Addition + User.Selected + User.typeofstation.Replace(User.typeofstation.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Exhibition time"))
                        {
                            request += User.Addition + User.Selected + User.exhibitiontime.Replace(User.exhibitiontime.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Variable"))
                        {
                            request += User.Addition + User.Selected + User.variable.Replace(User.variable.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Units"))
                        {
                            request += User.Addition + User.Selected + User.units.Replace(User.units.Last(), ' ');
                        }

                        if (selectedcolumn.Equals("Concentration"))
                        {
                            request += User.Addition + User.Selected + User.concentration.Replace(User.concentration.Last(), ' ');
                        }
                    }                    
                    if (this.limit.Text.Equals("") == false)
                    {
                        request += User.Addition + User.Amount + Convert.ToDouble(this.limit.Text);
                    }
                    /**
                     * loads the json path in the case that no limit has been set
                     */
                    if (this.amount.Text.Equals(""))
                    {
                        user.Load(selected, request);
                        data = user.GetData();                        
                        LaunchResults(selectedcolumn, selected);
                    }
                    /**
                     * loads the json path in the case that a limit has been set
                     */
                    else if (!this.amount.Text.Equals(""))
                    {
                        user.Load(selected, Convert.ToDouble(this.amount.Text), request);
                        data = user.GetData();
                        Save(data);
                        LaunchResults(selectedcolumn, selected);
                        showConfirmation();
                    }
                }
            }
            catch (InvalidCastException ae)
            {
                ae.ToString();
                ShowGeneralWarning();
            }
        }

        /**
         * Saves a report of interest for a selected department and variable
         */
        private void Save(List<Data> List)
        {
            String namevalue = this.depnamevalue.Text.Replace(" ", "_");
            String var = this.variablevalue.Text.Replace(" ", "_");
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("..\\..\\..\\..\\code\\Data\\" + namevalue + "\\" + var + "\\" + var + ".csv"))
                {
                    foreach (Data Row in List)
                    {
                        file.WriteLine(Row.toString());
                    }
                }
            }
            catch (System.IO.FileNotFoundException exception)
            {
                MessageBox.Show("Exception due to: " + exception.Message);
            }
        }

        /**
         * Loads the report of interest for a selected department and variable in order to divided by individual reports by year
         */
        private void LoadDepartmentData(String namevalue, String var)
        {
            List<Data> partialdata = new List<Data>();
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader("..\\..\\..\\..\\code\\Data\\" + namevalue + "\\" + var + "\\" + var + ".csv"))
                {
                    String line = file.ReadLine();

                    while (line != null)
                    {
                        String[] infor = line.Split(';');

                        String[] partialdate = infor[0].Split(' ');

                        String date = partialdate[0];
                        String enviromentalauthority = infor[1];
                        String stationname = infor[2];
                        String technology = infor[3];
                        String latitude = infor[4];
                        String longitude = infor[5];
                        String deparmentcode = infor[6];
                        String deparmentname = infor[7];
                        String municipalitycode = infor[8];
                        String municipalityname = infor[9];
                        String typeofstation = infor[10];
                        String exhibitiontime = infor[11];
                        String variable = infor[12];
                        String units = infor[13];
                        String concentration = infor[14];

                        Data data = new Data(date, enviromentalauthority, stationname, technology, latitude, longitude, deparmentcode, deparmentname, municipalitycode,
                            municipalityname, typeofstation, exhibitiontime, variable, units, concentration);

                        partialdata.Add(data);

                        line = file.ReadLine();
                    }

                    ExtractByDate(partialdata, namevalue, var);
                }
            }
            catch (System.IO.FileNotFoundException exception)
            {
                MessageBox.Show("Exception due to: " + exception.Message);
            }           
            
        }

        /**
         * Separates the data recolected for a variable on every year of tracking
         */
        private void ExtractByDate(List<Data> partialdata, String namevalue, String var) 
        {
            List<Data> data2011 = new List<Data>();
            List<Data> data2012 = new List<Data>();
            List<Data> data2013 = new List<Data>();
            List<Data> data2014 = new List<Data>();
            List<Data> data2015 = new List<Data>();
            List<Data> data2016 = new List<Data>();
            List<Data> data2017 = new List<Data>();

            foreach (Data row in partialdata) 
            {
                if (row.GetDate.Contains("2011")) 
                {
                    data2011.Add(row);
                }
                else if (row.GetDate.Contains("2012")) 
                {
                    data2012.Add(row);
                }
                else if (row.GetDate.Contains("2013"))
                {
                    data2013.Add(row);
                }
                else if (row.GetDate.Contains("2014"))
                {
                    data2014.Add(row);
                }
                else if (row.GetDate.Contains("2015"))
                {
                    data2015.Add(row);
                }
                else if (row.GetDate.Contains("2016"))
                {
                    data2016.Add(row);
                }
                else if (row.GetDate.Contains("2017"))
                {
                    data2017.Add(row);
                }
            }
            SaveByDate(data2011, namevalue, var, "2011");
            SaveByDate(data2011, namevalue, var, "2012");
            SaveByDate(data2011, namevalue, var, "2013");
            SaveByDate(data2011, namevalue, var, "2014");
            SaveByDate(data2011, namevalue, var, "2015");
            SaveByDate(data2011, namevalue, var, "2016");
            SaveByDate(data2011, namevalue, var, "2017");            
        }

        /**
         * Saves individually the report of a variable for every year of tracking
         */
        private void SaveByDate(List<Data> List, String namevalue, String var, String year)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("..\\..\\..\\..\\code\\Data\\" + namevalue + "\\" +
                    var + "\\" + year + "\\" + var + ".csv"))
                {
                    foreach (Data Row in List)
                    {
                        file.WriteLine(Row.toString());
                    }
                }
            }
            catch (System.IO.FileNotFoundException exception)
            {
                MessageBox.Show("Exception due to: " + exception.Message);
            }
        }
        
        /**
        * Triggered event caused by the user. Allows to partitionate the data on every year of tracking
        */
        private void Load_Click(object sender, EventArgs e)
        {
            String namevalue = this.depnamevalue.Text.Replace(" ", "_");
            String var = this.variablevalue.Text.Replace(" ", "_");
            LoadDepartmentData(namevalue, var);            
            showConfirmation();
        }        
    }
}