﻿using System;
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
using LogicLayer;
using LogicLayerInterfaces;
using DataTransferObjects;

namespace WPFPresentationLayer.AdoptionPages
{
  
    /// <summary>
    /// Creator: Awaab Elamin
    /// 2020/04/15
    /// Approver : Mohamed Elamin
    /// Interaction logic for AnimalsRecords.xaml
    /// </summary>
    /// <param name="e"></param>
    /// <param name="sender"></param>
    ///<remarks>
    /// Updater Name
    /// Updated: yyyy/mm/dd 
    /// Update: ()
    /// </remarks>
    public partial class AnimalsRecords : Page
    {
        private IAdoptionManager animalManager;
        private AnimalMedical animal;
        private List<AnimalMedical> animals;

        /// <summary>
        /// Creator: Awaab Elamin
        /// 2020/04/15
        /// Approver : Mohamed Elamin
        /// Default constructor intial the private attributes
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        ///<remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd 
        /// Update: ()
        /// </remarks>
        public AnimalsRecords()
        {
            InitializeComponent();
            animalManager = new ReviewerManager();
            animals = new List<AnimalMedical>();
        }

        /// <summary>
        /// Creator: Awaab Elamin
        /// 2020/04/15
        /// Approver : Mohamed Elamin
        /// on loadin animal record page retrieve animal rmedical records and show in the the grid
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        ///<remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd 
        /// Update: ()
        /// </remarks>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                animals = animalManager.retrieveAllAnimals();
                DGViewData.ItemsSource = animals;
            }
            catch (Exception)
            {

                lblAnimalMedError.Content = "We do not have animal medicals records for now";
            }
            
        }
    }
}