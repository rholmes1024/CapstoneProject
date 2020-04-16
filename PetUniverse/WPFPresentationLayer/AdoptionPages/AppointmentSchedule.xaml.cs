﻿using LogicLayerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PresentationUtilityCode;
using LogicLayer;

namespace WPFPresentationLayer.AdoptionPages
{
    /// <summary>
    /// Creator: Thomas Dupuy
    /// Created: 2/21/2020
    /// Approver: Zach Behrensmeyer
    /// 
    /// Page to veiw Appointment Schedule
    /// </summary>
    public partial class AppointmentSchedule : Page
    {
        private IAppointmentManager _appointmentManager;
        /// <summary>
        /// Creator : Thomas Dupuy
        /// Created: 2/21/2020
        /// Approver: Austin Gee
        /// 
        /// This method is a no-argument constructor
        /// </summary>
        /// 
        /// <remarks>
        /// Updater: 
        /// Updated:  
        /// Update: 
        /// </remarks>
        public AppointmentSchedule()
        {
            _appointmentManager = new AppointmentManager();
            InitializeComponent();
        }

        /// <summary>
        /// Creator : Thomas Dupuy
        /// Created: 2/21/2020
        /// Approver: Austin Gee
        /// 
        /// This method is called when the view appointments tab is selected in the Adoption canvas
        /// </summary>
        /// 
        /// <remarks>
        /// Updater: 
        /// Updated: 
        /// Update: 
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgAppointmentList_AutoGeneratedColumns(object sender, EventArgs e)
        {
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[13]);
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[12]);
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[11]);
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[10]);
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[7]);
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[6]);
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[5]);
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[4]);
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[3]);
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[2]);
            dgAppointmentList.Columns.Remove(dgAppointmentList.Columns[1]);

            dgAppointmentList.Columns[0].Header = "Location";
            dgAppointmentList.Columns[1].Header = "Appointment Type";
            dgAppointmentList.Columns[2].Header = "Date/Time";

            dgAppointmentList.Columns[0].DisplayIndex = 2;
            dgAppointmentList.Columns[1].DisplayIndex = 1;
            dgAppointmentList.Columns[2].DisplayIndex = 0;
        }

        /// <summary>
        /// Creator : Thomas Dupuy
        /// Created: 2/21/2020
        /// Approver: Austin Gee
        /// 
        /// This method is called when the view appointments tab is loaded
        /// </summary>
        /// 
        /// <remarks>
        /// Updater: 
        /// Updated: 
        /// Update: 
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgAppointmentList_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dgAppointmentList.ItemsSource = _appointmentManager.RetrieveAllActiveAppointments();
            }
            catch (Exception)
            {
                WPFErrorHandler.ErrorMessage("Could not retrieve data.");
            }
        }
    }
}
