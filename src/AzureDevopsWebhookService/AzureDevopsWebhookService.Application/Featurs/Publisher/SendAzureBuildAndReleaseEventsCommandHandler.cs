﻿namespace AzureDevopsWebhookService.Application.Featurs.Publisher
{
    public class SendAzureBuildAndReleaseEventsCommandHandler(IPublishEndpoint publishEndpoint)
        : IRequestHandler<AzureWebhookModelEvent<BuildAndReleaseResource>, HttpStatusCode>
    {
        private readonly IPublishEndpoint _publishEndpoint = publishEndpoint;

        public async Task<HttpStatusCode> Handle(AzureWebhookModelEvent<BuildAndReleaseResource> request, CancellationToken cancellationToken)
        {
            await _publishEndpoint.Publish(request, cancellationToken);
            return HttpStatusCode.OK;
        }
    }
}