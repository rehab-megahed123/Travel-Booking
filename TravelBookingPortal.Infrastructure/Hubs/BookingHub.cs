using Microsoft.AspNetCore.SignalR;
using TravelBookingPortal.Domain.IHubs;



namespace TravelBookingPortal.Infrastructure.Hubs
{
    public class BookingHub : Hub,IBookingHub
    {
        public async Task JoinGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task ConfirmBooking(int bookingId)
        {
            var groupName = $"booking-{bookingId}";
            await Clients.Group(groupName).SendAsync("BookingConfirmed", bookingId);
        }

        public async Task SendBookingConfirmedAsync(int bookingId)
        {
            await Clients.Group($"booking-{bookingId}")
                .SendAsync("BookingConfirmed", bookingId);
        }


        public async Task SendBookingUpdate(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                
                throw new ArgumentNullException(nameof(message), "Message cannot be null or empty");
            }

           // await Clients.All.SendAsync("ReceiveBookingUpdate", message);
        }
    }
}
