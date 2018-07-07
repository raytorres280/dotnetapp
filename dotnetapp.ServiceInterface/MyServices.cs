using System;
using System.Collections.Generic;
using System.Linq;
using ServiceStack;
using ServiceStack.Templates;
using ServiceStack.DataAnnotations;
using dotnetapp.ServiceModel;

namespace dotnetapp.ServiceInterface
{
    [Exclude(Feature.Metadata)]
    [FallbackRoute("/{PathInfo*}", Matches="AcceptsHtml")]
    public class FallbackForClientRoutes
    {
        public string PathInfo { get; set; }
    }

    public class MyServices : Service
    {
        //Return index.html for unmatched requests so routing is handled on client
        public object Any(FallbackForClientRoutes request) => 
            new PageResult(Request.GetPage("/"));
        
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }

        //public HelloResponse Get(HelloTest request)
        //{
        //    Console.WriteLine("other route is working..");
        //    return new HelloResponse { Result = request.Test };
        //}

        public object Post(CreateHello request)
        {
            Console.WriteLine("made it thru, is it json?");
            return new HelloResponse { Result = "post result string" };
        }
    }
}
