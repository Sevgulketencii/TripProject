using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripProject.CQRS.Handlers.DestinationHandlers;
using TripProject.CQRS.Queries.DestinationQueries;
using TripProject.CQRS.Results.DestinationResults;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _destinationHandler;
        private readonly GetDestinationByIdQueryHandler _destinationByIdHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler destinationHandler, GetDestinationByIdQueryHandler destinationByIdHandler)
        {
            _destinationHandler = destinationHandler;
            _destinationByIdHandler = destinationByIdHandler;
        }

        public IActionResult Index()
        {
            var values = _destinationHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var values = _destinationByIdHandler.Handle(new GetDestinationByIdQuery(id));
            return View(values);
        }
    }
}
