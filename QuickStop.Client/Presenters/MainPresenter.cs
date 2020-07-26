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

        public MainPresenter(IMainView mainView, IHotelRepository hotelRepository, IHotelDetailsPresenter hotelDetailsPresenter) : base(mainView)
        {
            this.hotelRepository = hotelRepository;
            this.hotelDetailsPresenter = hotelDetailsPresenter;

            view.HotelSelected += HotelSelected;
            view.LoadFilteredHotel += LoadFilteredHotel;
            view.SaveData += SaveData;
        }

        private void HotelSelected(object s, HotelSelectedEventArgs e)
        {
            if(hotelDetailsPresenter.ShowHotelDetails(e.Index) == DialogResult.OK)
            {
                view.PopulateHotels(null);
            }
        }

        private void LoadFilteredHotel(object s, HotelFilterEventArgs e)
        {
            var hotels = hotelRepository.GetHotels(e.Location, e.GuestCount, e.Sort);

            view.PopulateHotels(hotels);
        }

        private void SaveData(object s, EventArgs e)
        {
            hotelRepository.Save();
        }
    }
}
