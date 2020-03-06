﻿using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayerInterfaces;

namespace LogicLayerInterfaces
{
    /// <summary>
    /// Creator: Mohamed Elamin
    /// Created: 2020/02/29
    /// Approver: Awaab Elamin, 2020/03/03
    ///
    /// This Class is the public interface for Adoption Interviewer Manager class
    /// </summary>
    public interface IAdoptionInterviewerManager
    {

        /// <summary>
        /// Creator: Mohamed Elamin
        /// Created: 2020/02/19
        /// Approver: Awaab Elamin, 2020/03/03
        /// 
        /// This method used to get Adoption Applications Aappointments By Appointmen
        ///  type.
        /// 
        /// </summary>
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd 
        /// Update: ()
        /// </remarks>
        /// <param name=""></param>

        List<AdoptionAppointment> SelectAdoptionAappointmentsByAppointmentType();



        /// <summary>
        /// Creator: Mohamed Elamin
        /// Created: 2020/02/29
        /// Approver: Awaab Elamin, 2020/03/03
        /// 
        /// This method used to updates the appointment's record ,so the Interviewer can insert
        ///  his notes into the system.
        /// 
        /// </summary>
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd 
        /// Update: ()
        /// </remarks>
        /// <param name=""></param>
        /// 
        bool EditAppointment(AdoptionAppointment oldAdoptionAppointment
            , AdoptionAppointment newAdoptionAppointment);

    }
}




