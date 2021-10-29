﻿using System.IO;
using System.Threading.Tasks;
using Application.Exceptions;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class RedirectService
    {
        private readonly ILinkRepository _linkRepository;

        public RedirectService(ILinkRepository linkRepository)
        {
            _linkRepository = linkRepository;
        }
        
        public async Task<string> GetLink(string shortUrl)
        {
            var link = await _linkRepository.GetLink(shortUrl);
            if (link == null)
            {
                throw new NotFoundException(NotFoundException.LinkNotFound);
            }

            if (link.LinkType == LinkType.Public)
                return link.Target;

            return $"/p/{shortUrl}";
        }
    }
}