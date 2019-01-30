
using FluentValidation;

namespace Northwind.Application.Rooms.Commands.Validators
{
    class DeleteRoomCommandValidator : AbstractValidator<DeleteRoomCommand>
    {
        public DeleteRoomCommandValidator()
        {
           // RuleFor(e => e.RoomId).NotNull();
        }
    }
}
