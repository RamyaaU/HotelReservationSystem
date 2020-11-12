using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        //Hotel Name
        HotelType type;

        //Rate for Regular Customer        
        /// <summary>
        /// Gets the weekday rate.
        /// </summary>
        /// <value>
        /// The weekday rate.
        /// </value>
        public double WEEKDAY_RATE { get; }

        /// <summary>
        /// Gets the weekend rate.
        /// </summary>
        /// <value>
        /// The weekend rate.
        /// </value>
        public double WEEKEND_RATE { get; }

        /// <summary>
        /// Gets the rating.
        /// </summary>
        /// <value>
        /// The rating.
        /// </value>
        public double RATING { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="hotelType">Type of the hotel.</param>
        /// <exception cref="HotelReservationException">Invalid Hotel Type</exception>
        public Hotel(HotelType hotelType)
        {
            this.type = hotelType;
            try
            {
                if (hotelType.Equals(HotelType.LAKEWOOD))
                {
                    this.WEEKDAY_RATE = 110;
                    this.WEEKEND_RATE = 90;
                    this.RATING = 3;
                }
                if (hotelType.Equals(HotelType.BRIDGEWOOD))
                {
                    this.WEEKDAY_RATE = 150;
                    this.WEEKEND_RATE = 50;
                    this.RATING = 4;
                }
                if (hotelType.Equals(HotelType.RIDGEWOOD))
                {
                    this.WEEKDAY_RATE = 220;
                    this.WEEKEND_RATE = 150;
                    this.RATING = 5;
                }
            }
            catch (HotelReservationException)
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_HOTEL_TYPE, "Invalid Hotel Type");
            }
        }

        /// <summary>
        /// Finds the total cost.
        /// </summary>
        /// <param name="startDateString">The start date string.</param>
        /// <param name="endDateString">The end date string.</param>
        /// <returns></returns>
        /// <exception cref="HotelReservationException">Invalid date entered</exception>
        public double FindTotalCost(string startDateString, string endDateString)
        {
            //variable
            double TotalCost = 0;
            try
            {
                //converts the start date and time value to an equivalent string representation of date and time
                DateTime startDate = Convert.ToDateTime(startDateString);
                //converts the end date and time value to an equivalent string representation of date and time
                DateTime endDate = Convert.ToDateTime(endDateString);
                //when startdate <= enddate , for startdate first day of the week will be added
                for (; startDate <= endDate; startDate = startDate.AddDays(1))
                {
                    if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
                        TotalCost += WEEKEND_RATE;
                    else
                        TotalCost += WEEKDAY_RATE;
                }
            }
            catch (Exception)
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_DATE, "Invalid date entered");
            }
            return TotalCost;
        }
    }
}

