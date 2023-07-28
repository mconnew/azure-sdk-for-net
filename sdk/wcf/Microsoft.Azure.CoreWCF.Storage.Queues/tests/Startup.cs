﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Contracts;
using CoreWCF.Channels;
using CoreWCF.Configuration;
using CoreWCF.AzureQueueStorage.Tests.Helpers;
using CoreWCF.Queue.Common.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NUnit;
using Azure.Storage.CoreWCF.Channels;
using Azure.Storage.Queues;
using System.Collections.Generic;
using System.Web.Services.Description;

namespace CoreWCF.AzureQueueStorage.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<TestService>();
            services.AddServiceModelServices();

            //add the disposable queue to DI
            services.AddSingleton(provider =>
            {
                QueueTestBase queueTestBase = new QueueTestBase(true);
                Task<DisposingQueue> task = queueTestBase.GetTestQueueAsync();
                task.Wait();
                return task.Result;
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            DisposingQueue disposingQueue = app.ApplicationServices.GetRequiredService<DisposingQueue>();

            app.UseServiceModel(services =>
            {
                services.AddService<TestService>();
                services.AddServiceEndpoint<TestService, ITestContract>(new AzureQueueStorageBinding(),
                    ContrsuctURI(disposingQueue.Queue.Uri));
   
            });
        }
}


