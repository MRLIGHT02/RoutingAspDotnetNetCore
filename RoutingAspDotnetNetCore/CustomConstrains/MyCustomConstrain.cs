
namespace RoutingAspDotnetNetCore.CustomConstrains
{
    public class MyCustomConstrain : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            throw new NotImplementedException();
        }
    }
}
