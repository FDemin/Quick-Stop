﻿
using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Presenters
{
    public sealed class ReservationPresenter : PresenterBase<IReservationView>, IReservationPresenter
    {
        private readonly IHotelRepository hotelRepository;
        private readonly IReservationRepository reservationRepository;

        public ReservationPresenter(IReservationView reservationView, IHotelRepository hotelRepository, IReservationRepository reservationRepository) : base(reservationView)
        {
            this.hotelRepository = hotelRepository;
            this.reservationRepository = reservationRepository;

            view.RequestCreateReservation += RequestCreateReservation;
        }

        void IReservationPresenter.RequestReservation(int hotelIndex)
        {
            Hotel selectedHotel = hotelRepository.FindHotelByID(hotelIndex);

            view.DisplayReservation(selectedHotel);
        }

        void IReservationPresenter.RequestViewReservation(string reference)
        {
            try
            {
                Reservation reservation = reservationRepository.GetReservation(reference);
                Hotel hotel = hotelRepository.FindHotelByID(reservation.HotelID);

                view.DisplayReservation(reservation, hotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\r\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestCreateReservation(object s, EventArgs e)
        {
            Reservation reservation = view.GetReservation();

            reservationRepository.CreateReservation(reservation);
            hotelRepository.SetHotelInavailablity(reservation.HotelID, reservation.CheckOut);

            view.FinalizeReservation(reservation.Reference);
        }
    }
}