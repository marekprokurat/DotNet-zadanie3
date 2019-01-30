﻿
using FluentValidation;

namespace Northwind.Application.Rooms.Queries.Validators
{
    class GetRoomDetailsQueryValidator : AbstractValidator<GetRoomDetailsQuery>
    {
        public GetRoomDetailsQueryValidator()
        {
            RuleFor(e => e.RoomId).NotNull();
        }
    }
}
