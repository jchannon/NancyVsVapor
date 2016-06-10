using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy;
using Nancy.Configuration;
using Nancy.Diagnostics;

namespace NancyVsVapor
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        public override void Configure(INancyEnvironment environment)
        {
            base.Configure(environment);
            environment.Tracing(enabled:false,displayErrorTraces:true);
        }
    }
}
