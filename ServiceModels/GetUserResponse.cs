using System.Collections.Generic;
using InnovationCast.Backend.Challenge.Dtos;

namespace InnovationCast.Backend.Challenge.ServiceModels
{
    public class GetUserResponse
    {
        public Dictionary<int,UserDto> Users { get; set; }
    }
}