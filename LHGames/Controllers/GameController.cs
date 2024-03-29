﻿namespace StarterProject.Web.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;

    [Route("/")]
    public class GameController : Controller
    {
        AIHelper player = new AIHelper();

        [HttpPost]
        public string Index([FromForm]string map)
        {
            GameInfo gameInfo = JsonConvert.DeserializeObject<GameInfo>(map);
            var carte = AIHelper.DeserializeMap(gameInfo.CustomSerializedMap);

            // INSERT AI CODE HERE.

            //string action = AIHelper.CreateMoveAction(gameInfo.Player.Position);
            Point point = new point(gameInfo.Player.Position.X, gameInfo.Player.Position.Y-1);
            string action = AIHelper.CreateMoveAction(point);

            return action;
        }
    }
}
