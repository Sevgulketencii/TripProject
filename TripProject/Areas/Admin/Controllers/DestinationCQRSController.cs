using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripProject.CQRS.Handlers.DestinationHandlers;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _destinationHandle;

        public DestinationCQRSController(GetAllDestinationQueryHandler destinationHandle)
        {
            _destinationHandle = destinationHandle;
        }

        public IActionResult Index()
        {
            var values = _destinationHandle.Handle();
            return View(values);
        }
    }
}
