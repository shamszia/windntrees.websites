﻿using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Core.Models
{
    [ModelMetadataType(typeof(AspNetRolesMetaData))]
    public partial class AspNetRoles
    {

    }

    /// <summary>
    /// ApplicationContext repository class, should not be used for database model extension.
    /// </summary>
    public class AspNetRolesMetaData
    {
        [Key]
        public string Id { get; set; }
        [LocaleStringLength(256)]
        public string Name { get; set; }
        [LocaleStringLength(256)]
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }
    }
}
