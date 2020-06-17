using Dapper;
using Microsoft.AspNet.Identity;
using System;
using System.Data;
using System.Linq;
using System.Web.Http;
using Maroto1P2WebAPI.Models;

namespace Maroto1P2WebAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/Player")]
    public class PlayerController : ApiController
    {

        // POST api/Player/RegisterPlayer
        [HttpPost]
        [Route("RegisterPlayer")]
        public IHttpActionResult RegisterPlayer(PlayerModel player)
        {
            using (IDbConnection cnn = new ApplicationDbContext().Database.Connection)
            {
                string sql = "INSERT INTO dbo.Players(Id, Name, BirthDay) " +
                    $"VALUES('{player.Id}','{player.Name}','{player.BirthDay}')";
                try
                {
                    cnn.Execute(sql);
                }
                catch (Exception ex)
                {
                    return BadRequest("Error inserting player in database: " + ex.Message);
                }

                return Ok();
            }
        }
        /*
        // GET api/Player/GetPlayerInfo
        [HttpGet]
        public PlayerModel GetPlayerInfo()
        {
            string authenticatedAspNetUserId = RequestContext.Principal.Identity.GetUserId();
            using (IDbConnection cnn = new ApplicationDbContext().Database.Connection)
            {
                string sql = $"SELECT Id, FirstName, LastName, NickName, City, Email, BirthDay, ConnectedSince " +
                    $"WHERE Id LIKE '{authenticatedAspNetUserId}'";
                var player = cnn.Query<PlayerModel>(sql).FirstOrDefault();
                return player;
            }
        }
        */
    }
}
