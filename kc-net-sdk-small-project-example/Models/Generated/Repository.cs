// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace KcNetSdkSmallProjectExample.Models
{
    public partial class Repository
    {
        public const string Codename = "repository";
        public const string DescriptionCodename = "description";
        public const string NameCodename = "name";
        public const string UrlCodename = "url";

        public string Description { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}