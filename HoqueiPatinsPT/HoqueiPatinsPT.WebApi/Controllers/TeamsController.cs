using HoqueiPatinsPT.DataAccess;
using HoqueiPatinsPT.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HoqueiPatinsPT.WebApi.Controllers
{
    public class TeamsController : ApiController
    {
        public IHttpActionResult GetAllTeams()
        {
            List<Team> result;
            using(var uof = new UnitOfWork())
            {
                result = uof.TeamsRepository.GetAll().ToList();
                foreach(var team in result)
                {
                    team.MatchesAsAwayTeam.ToList();
                    team.MatchesAsHomeTeam.ToList();
                }
            }

            return Ok(result);
        }
    }
}
