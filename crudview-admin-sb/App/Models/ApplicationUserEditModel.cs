﻿using SharedLibrary.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Application.Core.Models
{
    public partial class ApplicationUserEditModel
    {
        [Key]
        [Display(ResourceType = typeof(LocaleResources.Core.Contents.Account.User), Name = "UserId")]
        public string UserId { get; set; }

        [LocaleMessageRequired]
        [LocaleMessageStringLength(50)]
        [Display(ResourceType = typeof(LocaleResources.Core.Contents.Account.User), Name = "FirstName")]
        public string FirstName { get; set; }

        [LocaleMessageRequired]
        [LocaleMessageStringLength(50)]
        [Display(ResourceType = typeof(LocaleResources.Core.Contents.Account.User), Name = "LastName")]
        public string LastName { get; set; }

        [Display(ResourceType = typeof(LocaleResources.Core.Contents.Account.User), Name = "Sex")]
        public string Sex { get; set; }

        [Display(ResourceType = typeof(LocaleResources.Core.Contents.Account.User), Name = "Title")]
        public string Title { get; set; }

        [LocaleMessageRequired]
        [LocaleMessageStringLength(150)]
        [Display(ResourceType = typeof(LocaleResources.Core.Contents.Account.User), Name = "Email")]
        public string Email { get; set; }

        [LocaleMessageStringLength(50)]
        [Display(ResourceType = typeof(LocaleResources.Core.Contents.Account.User), Name = "ImageFile")]
        public string ImageFile { get; set; }

    }
}
