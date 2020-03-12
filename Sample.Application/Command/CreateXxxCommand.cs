using System;
using MediatR;
using Sample.Application.Model;

namespace Sample.Application.Command
{
    public class CreateXxxCommand : IRequest<xxxContext>
    {

        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}
