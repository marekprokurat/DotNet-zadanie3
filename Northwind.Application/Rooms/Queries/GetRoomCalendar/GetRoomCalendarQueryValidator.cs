
using FluentValidation;

namespace Northwind.Application.Rooms.Queries.Validators
{
    class GetRoomCalendarQueryValidator : AbstractValidator<GetRoomCalendarQuery>
    {
        public GetRoomCalendarQueryValidator()
        {
            RuleFor(e => e.RoomId).NotNull();
        }
    }
}
