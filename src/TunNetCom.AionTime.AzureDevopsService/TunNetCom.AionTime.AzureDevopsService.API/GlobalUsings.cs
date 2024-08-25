﻿global using FluentResults;
global using FluentValidation;
global using MediatR;
global using Microsoft.AspNetCore.Diagnostics;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Microsoft.IdentityModel.Tokens;
global using Newtonsoft.Json;
global using OneOf;
global using OpenTelemetry.Instrumentation.AspNetCore;
global using OpenTelemetry.Logs;
global using OpenTelemetry.Metrics;
global using OpenTelemetry.Resources;
global using OpenTelemetry.Trace;
global using Serilog;
global using Serilog.Events;
global using Serilog.Sinks.Grafana.Loki;
global using System;
global using System.Collections.Generic;
global using System.Collections.ObjectModel;
global using System.Net;
global using System.Net.Http.Headers;
global using System.Runtime.CompilerServices;
global using System.Text;
global using System.Text.Json.Serialization;
global using System.Text.RegularExpressions;
global using System.Threading;
global using System.Threading.Tasks;
global using TunNetCom.AionTime.AzureDevopsService.Application;
global using TunNetCom.AionTime.AzureDevopsService.Application.AzureDevopsExternalResourceService;
global using TunNetCom.AionTime.AzureDevopsService.Application.AzureDevopsExternalResourceService.OrganizationProjectService;
global using TunNetCom.AionTime.AzureDevopsService.Application.AzureDevopsExternalResourceService.ProfileUserService;
global using TunNetCom.AionTime.AzureDevopsService.Application.AzureDevopsExternalResourceService.WorkItem;
global using TunNetCom.AionTime.AzureDevopsService.Contracts.AzureRequestResourceModel;
global using TunNetCom.AionTime.AzureDevopsService.Contracts.AzureResponceModel;