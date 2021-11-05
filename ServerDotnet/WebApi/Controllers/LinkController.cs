﻿using Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.DTOs.Requests;
using WebApi.DTOs.Responses;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class LinkController: ControllerBase
    {
        private readonly LinkService _linkService;
        private readonly IMapper _mapper;

        public LinkController(LinkService linkService, IMapper mapper)
        {
            _linkService = linkService;
            _mapper = mapper;
        }

        [HttpPost("access")]
        public async Task<ActionResult<string>> ProcessAccess([FromBody]LinkAccessRequest linkAccessRequest)
        {
            return await _linkService.AccessProtectedLink(linkAccessRequest.Key, linkAccessRequest.Password);
        }

        [HttpGet("info")]
        public async Task<ActionResult<LinkInfoResponseDTO>> GetLinkInfo([FromQuery]string key)
        {
            var link = await _linkService.GetLinkInfo(key);
            return _mapper.Map<LinkInfoResponseDTO>(link);
        }

    }
}
