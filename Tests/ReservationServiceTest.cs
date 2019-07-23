using Business.Interfaces;
using Domain;
using Moq;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Tests
{
    public class ReservationServiceTest
    {
        [Fact]
        public void ReservationTestSucess()
        {
            var reservationBusinessMock = new Mock<IReservationBusiness>();

            reservationBusinessMock.Setup(
                a => a.Add(It.IsAny<Reservation>(),null)).Returns(true);

            var reservationsExpectancy = new List<Reservation>
            {
                new Reservation() { Client = "Jessica Dias Rodrigues", DateStart = DateTime.Now, DateEnd = DateTime.Now.AddDays(2)},
                new Reservation() { Client = "Cliente Teste", DateStart = DateTime.Now, DateEnd = DateTime.Now.AddDays(10) }
        };

            reservationBusinessMock.Setup(a => a.GetList()).Returns(reservationsExpectancy);

            var reservationService = new ReservationService(reservationBusinessMock.Object);
            var reservations = reservationService.Insert(null, null);

            Assert.NotNull(reservations);
            Assert.True(reservations.Any());

            for (int i = 0; i < reservations.Count; i++)
            {
                Assert.Equal(reservationsExpectancy[i].Client, reservations[i].Client);
                Assert.Equal(reservationsExpectancy[i].DateStart, reservations[i].DateStart);
                Assert.Equal(reservationsExpectancy[i].DateEnd, reservations[i].DateEnd);
            }
        }
    }
}
