using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservationException : Exception
    {
        public enum ExceptionType
        {
            INVALID_HOTEL_TYPE,
            INVALID_DATE
        }

        /// <summary>
        /// The type
        /// </summary>
        ExceptionType type;

        /// <summary>
        /// Initializes a new instance of the <see cref="HotelReservationException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public HotelReservationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}