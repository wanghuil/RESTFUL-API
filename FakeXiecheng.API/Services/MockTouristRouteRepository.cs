//using FakeXiecheng.API.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace FakeXiecheng.API.Services
//{
//    public class MockTouristRouteRepository : ITouristRouteRepository
//    {
//        private List<TouristRoute> _routes;

//        public MockTouristRouteRepository()
//        {
//            if (_routes == null)
//            {
//                InitializeTouristRoutes();
//            }
//        }

//        private void InitializeTouristRoutes()
//        {
//            _routes = new List<TouristRoute>
//            {
//                new TouristRoute {
//                    Id = Guid.NewGuid(),
//                    Title = "Huangshan",
//                    Description="Huangshan is really fun",
//                    OriginalPrice = 1299,
//                    Features = "<p>Food, lodging, travel, shopping and entertainment</p>",
//                    Fees = "<p>Transportation expenses are at your own expense</p>",
//                    Notes="<p>Beware of danger</p>"
//                },
//                new TouristRoute {
//                    Id = Guid.NewGuid(),
//                    Title = "Huashan",
//                    Description="Huashan is really fun",
//                    OriginalPrice = 1299,
//                    Features = "<p>Food, lodging, travel, shopping and entertainment</p>",
//                    Fees = "<p>Transportation expenses are at your own expense</p>",
//                    Notes="<p>Beware of danger</p>"
//                }
//            };
//        }

//        public IEnumerable<TouristRoute> GetTouristRoutes()
//        {
//            return _routes;
//        }

//        public TouristRoute GetTouristRoute(Guid touristRouteId)
//        {
//            // linq
//            return _routes.FirstOrDefault(n => n.Id == touristRouteId);
//        }
//    }
//}
