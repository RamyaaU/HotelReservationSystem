using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservationException : Exception
    {
        public enum ExceptionType
        {
            INVALID_DATE,
            INVALID_CUSTOMER_TYPE,
            INVALID_HOTEL_TYPE,
            INVALID_CHOICE
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
