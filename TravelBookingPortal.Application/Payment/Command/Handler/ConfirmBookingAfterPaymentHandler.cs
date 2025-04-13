using MediatR;
using Microsoft.AspNetCore.SignalR;
using TravelBookingPortal.Application.Payment.Command.Model;
using TravelBookingPortal.Domain.Enitites.BookingEntities;
using TravelBookingPortal.Domain.IHubs;
using TravelBookingPortal.Domain.Repositories;
using TravelBookingPortal.Domain.Repositories.BookingRepo;

public class ConfirmBookingAfterPaymentHandler : IRequestHandler<ConfirmBookingAfterPaymentCommand,Unit>
{
    private readonly IBookingRepository _bookingRepository;
    private readonly INotificationService _notificationService;

    public ConfirmBookingAfterPaymentHandler(
        IBookingRepository bookingRepository,
        INotificationService notificationService)
    {
        _bookingRepository = bookingRepository;
        _notificationService = notificationService;
    }

    public async Task<Unit> Handle(ConfirmBookingAfterPaymentCommand request, CancellationToken cancellationToken)
    {
       
        var booking = await _bookingRepository.GetBookingByIdAsync(request.BookingId);

        

       
        await _bookingRepository.UpdateAsync(booking);

        //await _notificationService.SendBookingConfirmedAsync(booking.BookingId);

        return Unit.Value;
    }

   
}
