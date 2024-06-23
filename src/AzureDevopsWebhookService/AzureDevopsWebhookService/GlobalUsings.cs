﻿global using AzureDevopsWebhookService;
global using AzureDevopsWebhookService.API;
global using AzureDevopsWebhookService.API.Middelware;
global using AzureDevopsWebhookService.Application;
global using AzureDevopsWebhookService.Contracts.Constant;
global using AzureDevopsWebhookService.Contracts.EventModels;
global using AzureDevopsWebhookService.Contracts.EventModels.SharedModels;
global using AzureDevopsWebhookService.Contracts.EventModels.SharedModels.ResourcesModels;
global using MassTransit;
global using MediatR;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using OpenTelemetry.Instrumentation.AspNetCore;
global using OpenTelemetry.Logs;
global using OpenTelemetry.Metrics;
global using OpenTelemetry.Resources;
global using OpenTelemetry.Trace;
global using Serilog;
global using Serilog.Events;
global using Serilog.Sinks.Grafana.Loki;
global using System.Runtime.InteropServices;
global using System.Threading.Channels;