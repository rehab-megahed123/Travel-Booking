

namespace TravelBookingPortal.Domain.IHubs
{
  public  interface IBookingHub
    {
        public Task SendBookingConfirmedAsync(int bookingId);
       public  Task SendBookingUpdate(string message);
    }
}
