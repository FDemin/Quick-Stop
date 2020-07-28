﻿using QuickStop.Components.Exceptions;
using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace QuickStop.Infrastructure.Serializers
{
    public sealed class HotelSerializer : SerializerBase, IHotelSerializer
    {
        private readonly string fileName;

        public HotelSerializer(string baseDirectory) : base(baseDirectory, @"\Data\", ',')
        {
            fileName = "HotelData";
        }

        IEnumerable<HotelRoom> IHotelSerializer.DeserializeHotels()
        {
            List<HotelRoom> hotels = new List<HotelRoom>();

            string file = FilePath(fileName);
            try
            {
                string[] data = File.ReadAllLines(file);

                foreach (string hotelData in data)
                {
                    string[] hotelParams = parser.Split(hotelData);

                    try
                    {
                        HotelRoom hotel = new HotelRoom
                        {
                            ID = Convert.ToInt32(hotelParams[0]),
                            Name = hotelParams[1].Trim('\"'),
                            Description = hotelParams[2].Trim('\"'),
                            Price = Convert.ToDecimal(hotelParams[3]),
                            Ratings = Convert.ToUInt16(hotelParams[4]),
                            Location = (Location)Enum.Parse(typeof(Location), hotelParams[5]),
                            MinGuestCount = Convert.ToInt32(hotelParams[6]),
                            MaxGuestCount = Convert.ToInt32(hotelParams[7]),
                            DateUntilAvailable = string.IsNullOrWhiteSpace(hotelParams[8]) ? null : (DateTime?)Convert.ToDateTime(hotelParams[8]),
                            Icon = hotelParams[9],
                            Room = hotelParams[10]
                        };

                        hotels.Add(hotel);
                    }
                    catch
                    {
                        
                    }
                }

                return hotels;
            }
            catch
            {
                string src = GetResourceFileContentAsString(fileName + extension);
                File.WriteAllText(file, src);

                throw new HotelDataNotFoundException();
            }
        }

        void IHotelSerializer.SerializeHotels(IEnumerable<HotelRoom> hotels)
        {

            StringBuilder sb = new StringBuilder();
            string file = FilePath(fileName);

            foreach (HotelRoom hotel in hotels)
            {
                sb.Append(IncludeDelimiter(hotel.ID.ToString()));
                sb.Append(IncludeDelimiter(hotel.Name, true));
                sb.Append(IncludeDelimiter(hotel.Description, true));
                sb.Append(IncludeDelimiter(hotel.Price.ToString()));
                sb.Append(IncludeDelimiter(hotel.Ratings.ToString()));
                sb.Append(IncludeDelimiter(hotel.Location.ToString()));
                sb.Append(IncludeDelimiter(hotel.MinGuestCount.ToString()));
                sb.Append(IncludeDelimiter(hotel.MaxGuestCount.ToString()));
                sb.Append(IncludeDelimiter(hotel.DateUntilAvailable.ToString()));
                sb.Append(IncludeDelimiter(hotel.Icon));
                sb.Append(IncludeDelimiter(hotel.Room));
                sb.AppendLine();
            }

            File.WriteAllText(file, sb.ToString());
        }

        private string IncludeDelimiter(string str, bool ignoreDelimiterOnString = false)
        {
            string quote = ignoreDelimiterOnString ? "\"" : null;
            return $"{quote}{str}{quote}{delimiters.First()}";
        }

        private string GetResourceFileContentAsString(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "QuickStop.Infrastructure.Data." + fileName;

            string resource = null;
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using(StreamReader reader = new StreamReader(stream))
            {
                resource = reader.ReadToEnd();
            }

            return resource;
        }
    }
}
