﻿using QuickStop.Client.Contracts.Views;
using QuickStop.Client.ViewModels;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class ReservationForm : IHotelBookingView
    {
        #region Events
        private event EventHandler RequestCreateReservation;

        event EventHandler IHotelBookingView.RequestCreateHotelBooking
        {
            add { RequestCreateReservation += value; }
            remove { RequestCreateReservation -= value; }
        }
        #endregion

        public HotelBookingViewModel HotelBookingViewModel { get; set; }

#pragma warning disable CS1066 // The default value specified will have no effect because it applies to a member that is used in contexts that do not allow optional arguments
        void IHotelBookingView.DisplayHotelBooking(bool isReadOnly = false)
#pragma warning restore CS1066 // The default value specified will have no effect because it applies to a member that is used in contexts that do not allow optional arguments
        {
            //dateTimePicker2.Value = ReservationViewModel.CheckIn;
            //dateTimePicker1.Value = ReservationViewModel.CheckOut;

            numericUpDown1.Enabled = !isReadOnly;
            dateTimePicker1.Enabled = !isReadOnly;
            dateTimePicker2.Enabled = !isReadOnly;
            button1.Visible = !isReadOnly;

            ShowDialog();
        }

        void IHotelBookingView.FinalizeHotelBooking(string reference)
        {
            MessageBox.Show("Thank you for booking in Quick Stop!\r\nYour booking reference is: " + reference, "Quick-Stop: Booking Complete", MessageBoxButtons.OK);
            Close();
        }
    }
}