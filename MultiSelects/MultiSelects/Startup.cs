﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiSelects.Startup))]
namespace MultiSelects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
