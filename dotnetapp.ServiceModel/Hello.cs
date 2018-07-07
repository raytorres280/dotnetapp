using System;
using ServiceStack;

namespace dotnetapp.ServiceModel
{
    [Route("/hello/GetHello")]
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
        public Hello()
        {
            this.Name = "natti";
        }
    }

    [Route("/hello/GetTest", Verbs = "GET", Notes = "this is a test")]
    public class HelloTest : IReturn<HelloResponse>
    {
        public string Test { get; set; }
        public HelloTest()
        {
            this.Test = "testing the service models";
        }
    }

    [Route("/hello/CreateHello", Verbs = "POST", Notes = "creates a new obj in hello file")]
    public class CreateHello: IReturn<HelloResponse>
    {
        //public Pocos.Hello Hello { get; set; }
        public string Message { get; set; }
        public CreateHello()
        {
            Console.WriteLine("lets see the req.body");
            //this.Hello = new Pocos.Hello { Message = "first db object." };
            this.Message = "first post route";
        }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }

}
