﻿using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Components;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Presenters
{
    public sealed class MainPresenter : PresenterBase<IMainView>, IMainPresenter
    {
        private readonly IHotelRepository hotelRepository;
        private readonly IHotelDetailsPresenter hotelDetailsPresenter;
        private readonly IReservationPresenter reservationPresenter;

        public MainPresenter(IMainView mainView, IHotelRepository hotelRepository, IHotelDetailsPresenter hotelDetailsPresenter, IReservationPresenter reservationPresenter) : base(mainView)
        {
            this.hotelRepository = hotelRepository;
            this.hotelDetailsPresenter = hotelDetailsPresenter;
            this.reservationPresenter = reservationPresenter;

            view.RequestViewHotelDetails += RequestViewHotelDetails;
            view.RequestLoadHotels += RequestLoadHotels;
            view.RequestSaveData += RequestSaveData;
        }

        #region Main Logic
        private void RequestLoadHotels(object s, HotelFilterEventArgs e)
        {
            var hotels = hotelRepository.GetHotels(e.Location, e.GuestCount, e.Sort);

            view.LoadHotels(hotels);
        }

        private void RequestSaveData(object s, EventArgs e)
        {
            hotelRepository.Save();
        }
        #endregion

        #region Navigation
        //
        // Main -> Hotel Details
        //
        private void RequestViewHotelDetails(object s, HotelSelectedEventArgs e)
        {
            hotelDetailsPresenter.RequestViewHotelDetails(e.Index);
        }

        //
        // Main -> Reservation
        //
        private void RequestViewReservation(object s, ReservationReferenceEventArgs e)
        {
            reservationPresenter.RequestViewReservation(e.Reference);
        }
        #endregion
    }
}
