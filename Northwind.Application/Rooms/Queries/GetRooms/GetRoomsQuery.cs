using MediatR;
using Northwind.Application.Rooms.Models;
using System.Collections.Generic;


namespace Northwind.Application.Rooms.Queries
{
    public class GetRoomsQuery : IRequest<RoomListModel>
    {
        public IList<RoomPreviewModel> Rooms { get; set; }
    }
}
