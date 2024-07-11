using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Reviews;

public sealed record ReviewCreatedDomainEvent(Guid BookingId) : IDomainEvent;
