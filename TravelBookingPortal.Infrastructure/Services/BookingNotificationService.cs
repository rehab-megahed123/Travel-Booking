using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using TravelBookingPortal.Domain.Enitites.BookingEntities;
using TravelBookingPortal.Domain.IHubs;
using TravelBookingPortal.Domain.Repositories;
using TravelBookingPortal.Infrastructure.Hubs;

namespace TravelBookingPortal.Infrastructure.Services
{
    public class BookingNotificationService : INotificationService
    {
        private readonly IHubContext<BookingHub> _hubContext;

        public BookingNotificationService(IHubContext<BookingHub> hubContext)
        {
            _hubContext = hubContext;
        }

        

        public async Task SendBookingConfirmedAsync(int bookingId)
        {
            //await _hubContext.Clients.Group($"booking-{bookingId}")
            //    .SendAsync("BookingConfirmed", bookingId);
        }
    }
}
