
using System.Text.RegularExpressions;

namespace RoutingAspDotnetNetCore.CustomConstrains
{
    public class MyCustomConstrain : IRouteConstraint
    {
        //Eg:sales-report/2020/apr
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.ContainsKey(routeKey))
            {
                // return false
                return false;
            }
            Regex regex = new Regex("^(apr|july|oct|jan)$");
            string? monthValue = Convert.ToString(values[routeKey]);

            if (regex.IsMatch(monthValue))
            {
                return true;// it's a match
            }
            return false;
        }
    }
}
