﻿using DataTransferObjects;
using LogicLayer;
using LogicLayerInterfaces;
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

namespace WPFPresentationLayer.RecruitingPages
{
    /// <summary>
    /// 
    /// Name: Steve Coonrod
    /// Date: 2\08\2020
    /// Checked By:
    /// 
    /// This is the page which contains all Event Management operations.
    /// 
    /// Updated By:     
    /// Date Updated:   
    /// 
    /// </summary>
    public partial class EventMgmt : Page
    {

        private IPUEventManager _eventManager = null;//For using event manager methods
        private PetUniverseUser _user = null;//for tracking the current user

        /// <summary>
        /// Name: Steve Coonrod
        /// Date: 2\08\2020
        /// Checked By:
        /// 
        /// This is the no-argument constructor.
        /// It is never used, but is necessary for the PUHome window to initialize.
        /// 
        /// Updated By:     
        /// Date Updated: 
        /// 
        /// </summary>
        public EventMgmt()
        {
            InitializeComponent();
            _eventManager = new PUEventManager();
        }

        /// <summary>
        /// Name: Steve Coonrod
        /// Date: 2\08\2020
        /// Checked By:
        /// 
        /// This is the constructor for this page which takes in a user object.
        /// This is necessary for basing functionality on the users role.
        /// 
        /// Updated By:     
        /// Date Updated: 
        /// 
        /// </summary>
        /// <param name="user"></param>
        public EventMgmt(PetUniverseUser user)
        {
            InitializeComponent();
            _eventManager = new PUEventManager();
            _user = user;
        }


        /// <summary>
        /// Name: Steve Coonrod
        /// Date: 2\08\2020
        /// Checked By:
        /// 
        /// This is the click event to Create a New Event (UC-606 and UC-633)
        /// 
        /// Updated By:     
        /// Date Updated: 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEvent_Click(object sender, RoutedEventArgs e)
        {
            frmCreateEditEvent newEventForm = new frmCreateEditEvent(_eventManager, _user);

            newEventForm.Owner = Window.GetWindow(this);
            if (newEventForm.ShowDialog() == true)
            {
                dgEventList.ItemsSource = _eventManager.GetAllEvents();
            }

        }

        /// <summary>
        /// 
        /// Name: Steve Coonrod
        /// Date: 2\08\2020
        /// Checked By:
        /// 
        /// The handler for loading this page.
        /// At this point it will populate the events datagrid
        /// 
        /// Updated By:     
        /// Date Updated: 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgEventList.ItemsSource == null)
                {
                    dgEventList.ItemsSource = _eventManager.GetAllEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }
        }

        private void dgEventList_AutoGeneratedColumns(object sender, EventArgs e)
        {
            dgEventList.Columns.RemoveAt(11);
            dgEventList.Columns.RemoveAt(10);
            dgEventList.Columns.RemoveAt(2);
            dgEventList.Columns.RemoveAt(1);
            dgEventList.Columns.RemoveAt(0);
            dgEventList.Columns[1].Header = "Type";
            dgEventList.Columns[2].Header = "Date and Time";
        }
    }
}