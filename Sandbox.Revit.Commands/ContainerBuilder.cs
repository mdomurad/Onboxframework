﻿using Onbox.Di.V1;
using Onbox.Json.V1;
using Onbox.Mvc.V1;

namespace Onbox.Sandbox.Revit.Commands
{
    public static class ContainerBuilder
    {
        public static Container Build()
        {
            var container = new Container();
            container.AddTransient<IOrderView, OrderView>();
            container.AddTransient<IServerService, MockServerService>();
            container.AddTransient<IMessageService, MessageBoxService>();

            container.AddSingleton<SomeService>();

            container.AddJson();

            return container;
        }
    }

    public class SomeService
    {
        public SomeService(IMessageService messageService)
        {
            messageService.Show("Instantiated service");
        }
    }
}
