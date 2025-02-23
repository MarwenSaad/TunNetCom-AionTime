﻿global using AzureDevopsService.Contracts.AzureRequestModel;
global using AzureDevopsService.Contracts.AzureRequestResourceModel;
global using AzureDevopsService.Contracts.AzureResponceModel;
global using AzureDevopsService.Contracts.AzureResponceModel.BadRequest;
global using AzureDevopsService.Contracts.AzureResponceModel.SuccessResponce;
global using AzureDevopsService.Contracts.Constant;
global using AzureDevopsService.Contracts.Internal.Interface;
global using AzureDevopsService.Infrasructure.AzureDevopsExternalResourceService;
global using AzureDevopsService.Infrasructure.AzureDevopsExternalResourceService.ServiceHelper;
global using AzureDevopsService.Infrasructure.AzureDevopsExternalResourceService.ServiceHelper.WorkItem;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using OneOf;
global using System.Net;
global using System.Net.Http.Headers;
global using System.Net.Http.Json;