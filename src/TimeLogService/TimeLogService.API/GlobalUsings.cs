﻿global using AzureDevopsService.Contracts.AzureRequestResourceModel;
global using MediatR;
global using Microsoft.AspNetCore.Diagnostics;
global using Microsoft.AspNetCore.Mvc;
global using Newtonsoft.Json;
global using OpenTelemetry.Instrumentation.AspNetCore;
global using OpenTelemetry.Logs;
global using OpenTelemetry.Metrics;
global using OpenTelemetry.Resources;
global using OpenTelemetry.Trace;
global using Serilog;
global using Serilog.Events;
global using System.Net;
global using TimeLogService;
global using TimeLogService.API;
global using TimeLogService.API.Controllers;
global using TimeLogService.API.Middelware;
global using TimeLogService.Application;
global using TimeLogService.Application.Feature.MessageBroker.Producer.ProfileUser;
global using TimeLogService.Application.Feature.MessageBroker.Producer.Project;
global using TimeLogService.Application.Feature.MessageBroker.Producer.WorkItem;
global using TimeLogService.Application.Feature.OrganizationAction.Commands.AddOrganization;
global using TimeLogService.Application.Feature.OrganizationAction.Commands.DeletOrganization;
global using TimeLogService.Application.Feature.OrganizationAction.Commands.UpdateOrganization;
global using TimeLogService.Application.Feature.OrganizationAction.Queries.GetOrganization;
global using TimeLogService.Application.Feature.OrganizationAction.Queries.GetOrganizationById;
global using TimeLogService.Contracts.DTOs.Request;
global using TimeLogService.Infrastructure;
global using TimeLogService.Infrastructure.AionTimeContext;