﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Core.Attributes;

namespace DataAccess.Core.Models
{
    [ModelMetadataType(typeof(ColorMetaData))]
    public partial class Color
    {

    }

    public partial class ColorMetaData
    {
        [Key]
        public System.Guid Uid { get; set; }

        [LocaleMessageRequired]
        [LocaleMessageStringLength(10)]
        [Display(ResourceType = typeof(LocaleResources.Core.Contents.Color), Name = "Name")]
        public string Name { get; set; }

        [LocaleMessageStringLength(255)]
        [Display(ResourceType = typeof(LocaleResources.Core.Contents.Color), Name = "Description")]
        public string Description { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}