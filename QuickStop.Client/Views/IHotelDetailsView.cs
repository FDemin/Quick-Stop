﻿using QuickStop.Client.Contracts;
using QuickStop.Components;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Views
{
    public interface IHotelDetailsView : IView
    {
        event EventHandler<HotelSelectedEventArgs> HotelSelected;

        void DisplayHotel(Hotel hotel);
    }
}
