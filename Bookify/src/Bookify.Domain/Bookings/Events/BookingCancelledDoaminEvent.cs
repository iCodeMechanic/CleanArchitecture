using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

public sealed record BookingCancelledDoaminEvent(Guid BookingId) : IDomainEvent;
