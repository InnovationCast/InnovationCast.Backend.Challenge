using System.Linq;
using innovationcast_backend_challenge.Dtos;
using innovationcast_backend_challenge.ServiceModels;
using Microsoft.AspNetCore.Mvc;

namespace innovationcast_backend_challenge.Controllers
{
    public class MainController : Controller
    {
        public MainController()
        {
        }

        // This action responds to the url /main/users/42,24
        public GetUserResponse Users(int[] id)
        {
            return new GetUserResponse
            {
                Users=id.ToDictionary(i => i, i => new UserDto
                {
                    Id = i,
                    Username = $"User {i}",
                    Email = $"user-{i}@example.com"
                })
            };
        }

        // TODO: An action to return a paged list of comments

        // TODO: An action to add a comment
    }
}