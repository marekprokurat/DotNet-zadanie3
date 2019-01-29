﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Northwind.Application.Interfaces;
using Northwind.Application.Notifications.Models;
using Northwind.Domain.Entities;
using Northwind.Persistence;

namespace Northwind.Application.Rooms.Commands.Handlers
{
    class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, Unit>
    {
        private readonly NorthwindDbContext _context;
        private readonly INotificationService _notificationService;

        public CreateRoomCommandHandler(NorthwindDbContext context, INotificationService notificationService)
        {
            _context = context;
            _notificationService = notificationService;
        }

        public async Task<Unit> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            var room = new Room()
            {
                RoomId = request.RoomId,
                RoomCapacity = request.RoomCapacity,
                RoomNumber = request.RoomNumber,
                Notes = request.Notes,
               ReservationDates = request.ReservationDates,
            };

            await _context.Rooms.AddAsync(room, cancellationToken);
            await _context.Dates.AddRangeAsync(room.ReservationDates, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

          

            return Unit.Value;
        }
    }
}
