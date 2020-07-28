﻿using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Client.Presenters;
using QuickStop.Client.Views;
using QuickStop.Infrastructure.Contracts;
using QuickStop.Infrastructure.Repositories;
using QuickStop.Infrastructure.Serializers;
using System;
using System.IO;
using System.Windows.Forms;

namespace QuickStop.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string s = Path.GetDirectoryName(Application.ExecutablePath);

            IMainView mainView = new MainForm();
            IHotelRoomDetailsView hotelDetailsView = new HotelDetailsForm();
            IHotelBookingView reservationView = new ReservationForm();

            IHotelSerializer hotelSerializer = new HotelSerializer(s);
            IHotelBookSerializer reservationSerializer = new HotelBookingSerializer(s);

            IHotelRoomRepository hotelRepository = new HotelRepository(hotelSerializer);
            IHotelBookingRepository reservationRepository = new ReservationRepository(reservationSerializer);

            
            IHotelBookingPresenter reservationPresenter = new ReservationPresenter(reservationView, hotelRepository, reservationRepository);
            IHotelRoomDetailsPresenter hotelDetailsPresenter = new HotelRoomDetailsPresenter(hotelDetailsView, hotelRepository, reservationPresenter);
            IMainPresenter mainPresenter = new MainPresenter(mainView, hotelRepository, hotelDetailsPresenter, reservationPresenter);

            Application.Run(mainView as MainForm);
        }
    }
}
