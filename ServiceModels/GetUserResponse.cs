using System.Collections.Generic;
using innovationcast_backend_challenge.Dtos;

namespace innovationcast_backend_challenge.ServiceModels
{
    public class GetUserResponse
    {
        public Dictionary<int,UserDto> Users { get; set; }
    }
}