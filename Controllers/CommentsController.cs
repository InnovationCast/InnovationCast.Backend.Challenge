using innovationcast_backend_challenge.Dtos;
using innovationcast_backend_challenge.ServiceModels;
using Microsoft.AspNetCore.Mvc;

namespace innovationcast_backend_challenge.Controllers
{
    public class ChallengeController : Controller
    {
        public ChallengeController()
        {
        }

        // This action responds to the url /challenge/getUser?id=42
        public GetUserResponse GetUser(int id)
        {
            return new GetUserResponse
            {
                User = new UserDto
                {
                    Id = id,
                    Username = $"User {id}",
                    Email = $"user-{id}@example.com"
                }
            };
        }

        // TODO: An action to return a paged list of comments

        // TODO An action to add a comment
    }
}