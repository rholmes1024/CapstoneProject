﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessInterfaces;
using DataTransferObjects;

namespace DataAccessFakes
{
    /// <summary>
    /// Creator: Ethan Murphy
    /// Created: 2/7/2020
    /// Approver: Carl Davis 2/14/2020
    /// Approver: Chuck Baxter 2/14/2020
    /// 
    /// A class used to test the Vet Appointment Accessor with fake data
    /// </summary>
    public class FakeVetAppointmentAccessor : IVetAppointmentAccessor
    {
        private List<AnimalVetAppointment> _vetAppointments;

        /// <summary>
        /// Creator: Ethan Murphy
        /// Created: 2/7/2020
        /// Approver: Carl Davis 2/14/2020
        /// Approver: Chuck Baxter 2/14/2020
        /// 
        /// Default constructor that intializes a list of
        /// AnimalVetAppointment and creates 3 records
        /// </summary>
        /// <remarks>
        /// Updater:
        /// Updated:
        /// Update:
        /// </remarks>
        public FakeVetAppointmentAccessor()
        {
            _vetAppointments = new List<AnimalVetAppointment>()
            {
                new AnimalVetAppointment()
                {
                    VetAppointmentID = 1,
                    AnimalID = 1,
                    AnimalName = "qwerty",
                    UserID = 1,
                    AppointmentDateTime = DateTime.Now,
                    AppointmentDescription = "asdf",
                    ClinicAddress = "1234 asdf",
                    VetName = "awerga",
                    FollowUpDateTime = null,
                    Active = true
                },
                new AnimalVetAppointment()
                {
                    VetAppointmentID = 2,
                    AnimalID = 2,
                    AnimalName = "greasgeas",
                    UserID = 2,
                    AppointmentDateTime = DateTime.Now,
                    AppointmentDescription = "fdsa",
                    ClinicAddress = "gaerdgaerg",
                    VetName = "hstrth",
                    FollowUpDateTime = DateTime.Parse("2/20/2021 2:00PM"),
                    Active = true
                },
                new AnimalVetAppointment()
                {
                    VetAppointmentID = 3,
                    AnimalID = 3,
                    AnimalName = "geasrgg",
                    UserID = 3,
                    AppointmentDateTime = DateTime.Parse("3/1/2020 2:00PM"),
                    AppointmentDescription = "hsrethrh",
                    ClinicAddress = "1234 hgaergaeh",
                    VetName = "htshsrth",
                    FollowUpDateTime = null,
                    Active = false
                }
            };
        }

        /// <summary>
        /// Creator: Ethan Murphy
        /// Created: 2/7/2020
        /// Approver: Carl Davis 2/14/2020
        /// Approver: Chuck Baxter 2/14/2020
        /// 
        /// Inserts a fake animal vet appointment record
        /// </summary>
        /// <remarks>
        /// Updater:
        /// Updated:
        /// Update:
        /// </remarks>
        /// <param name="animalVetAppointment">An AnimalVetAppointment object</param>
        /// <returns>Insert succesful</returns>
        public bool InsertVetAppointment(AnimalVetAppointment animalVetAppointment)
        {
            bool result = false;

            _vetAppointments.Add(animalVetAppointment);

            try
            {
                if (_vetAppointments[_vetAppointments.Count - 1] == animalVetAppointment)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Creator: Ethan Murphy
        /// Created: 2/7/2020
        /// Approver: Carl Davis 2/14/2020
        /// Approver: Chuck Baxter 2/14/2020
        /// 
        /// Gets a list of all fake animal vet appointment records
        /// </summary>
        /// <remarks>
        /// Updater:
        /// Updated:
        /// Update:
        /// </remarks>
        /// <returns>List of all animal vet appointments</returns>
        public List<AnimalVetAppointment> SelectAllVetAppointments()
        {
            return _vetAppointments;
        }

        /// <summary>
        /// Creator: Ethan Murphy
        /// Created: 3/1/2020
        /// Approver: Ben Hanna, 3/6/2020
        /// Approver:
        /// 
        /// Updates an existing fake vet appointment record
        /// </summary>
        /// <remarks>
        /// Updater:
        /// Updated:
        /// Update:
        /// </remarks>
        /// <param name="oldAnimalVetAppointment">The existing record</param>
        /// <param name="newAnimalVetAppointment">The updated record</param>
        /// <returns>Insert succesful</returns>
        public bool UpdateVetAppointment(AnimalVetAppointment oldAnimalVetAppointment, AnimalVetAppointment newAnimalVetAppointment)
        {
            bool result = false;

            if (_vetAppointments.Contains(oldAnimalVetAppointment))
            {
                _vetAppointments.Remove(oldAnimalVetAppointment);
                _vetAppointments.Add(newAnimalVetAppointment);
            }
            if(_vetAppointments.Contains(newAnimalVetAppointment) &&
                !_vetAppointments.Contains(oldAnimalVetAppointment))
            {
                result = true;
            }

            return result;
        }
    }
}
