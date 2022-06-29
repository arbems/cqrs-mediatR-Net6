﻿using CQRS_MediatR_NET_6.Models.Request;
using CQRS_MediatR_NET_6.Models.Response;
using MediatR;

namespace CQRS_MediatR_NET_6.Handlers.Queries;

public class GetPostByIdQueryHandler : IRequestHandler<GetPostByIdRequestModel, GetPostByIdResponseModel>
{
    public async Task<GetPostByIdResponseModel> Handle(GetPostByIdRequestModel request, CancellationToken cancellationToken)
    {
        // your logic get post...

        return new GetPostByIdResponseModel()
        {
            Body = "It is a long established fact that a reader will...",
            Id = Guid.Parse("556b8afa-5617-425c-87af-381f278ccf90"),
            Title = "What is Lorem Ipsum?",
            UserId = Guid.Parse("40cea88f-9cdb-4509-a8bd-a307d149daf0")
        };
    }
}