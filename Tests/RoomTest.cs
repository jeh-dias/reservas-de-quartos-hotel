using Business.Interfaces;
using Domain;
using Moq;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class RoomTest
    {
        [Fact]
        public void RoomTestSucesso()
        {
            var roomBusinessMock = new Mock<IRoomBusiness>();
            roomBusinessMock.Setup(
                a => a.Add(It.IsAny<Room>())).Returns(true);

            var roomsExpectancy = new List<Room>
            {
                new Room() { Amount = 10, AmountAvailable = 10},
                new Room() { Amount = 20, AmountAvailable = 20 }
        };

            roomBusinessMock.Setup(a => a.GetList()).Returns(roomsExpectancy);

            var roomService = new RoomService(roomBusinessMock.Object);
            var rooms = roomService.Insert(null);

            Assert.NotNull(rooms);
            Assert.True(rooms.Any());

            for (int i =0; i < rooms.Count; i++)
            {
                Assert.Equal(roomsExpectancy[i].Amount, rooms[i].Amount);
                Assert.Equal(roomsExpectancy[i].AmountAvailable, rooms[i].AmountAvailable);
            }
        }
    }
}
