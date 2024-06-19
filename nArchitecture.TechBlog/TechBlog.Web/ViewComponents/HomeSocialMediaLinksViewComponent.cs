﻿using Microsoft.AspNetCore.Mvc;
using TechBlog.Service.Services.Abstractions;

namespace TechBlog.Web.ViewComponents
{
    public class HomeSocialMediaLinksViewComponent : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;
        public HomeSocialMediaLinksViewComponent(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialMediaAccounts = await _socialMediaService.GetAllSocialMediaAccountsAsync();
            return View(socialMediaAccounts);
        }
    }
}
