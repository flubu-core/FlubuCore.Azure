
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnEndpointCreateTask : ExternalProcessTaskBase<AzureCdnEndpointCreateTask>
     {
        
        /// <summary>
        /// Create a named endpoint to connect to a CDN.
        /// </summary>
        public AzureCdnEndpointCreateTask(string name = null ,  string origin = null ,  string profileName = null ,  string resourceGroup = null)
        {
            WithArguments("az cdn endpoint create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--origin");
            if (!string.IsNullOrEmpty(origin))
            {
                 WithArguments(origin);
            }

WithArguments("--profile-name");
            if (!string.IsNullOrEmpty(profileName))
            {
                 WithArguments(profileName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// </summary>
        public AzureCdnEndpointCreateTask ContentTypesToCompress(string contentTypesToCompress = null)
        {
            WithArguments("--content-types-to-compress");
            if (!string.IsNullOrEmpty(contentTypesToCompress))
            {
                 WithArguments(contentTypesToCompress);
            }

            return this;
        }

        /// <summary>
        /// If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.
        /// </summary>
        public AzureCdnEndpointCreateTask EnableCompression(string enableCompression = null)
        {
            WithArguments("--enable-compression");
            if (!string.IsNullOrEmpty(enableCompression))
            {
                 WithArguments(enableCompression);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureCdnEndpointCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.
        /// </summary>
        public AzureCdnEndpointCreateTask NoHttp(string noHttp = null)
        {
            WithArguments("--no-http");
            if (!string.IsNullOrEmpty(noHttp))
            {
                 WithArguments(noHttp);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.
        /// </summary>
        public AzureCdnEndpointCreateTask NoHttps(string noHttps = null)
        {
            WithArguments("--no-https");
            if (!string.IsNullOrEmpty(noHttps))
            {
                 WithArguments(noHttps);
            }

            return this;
        }

        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.
        /// </summary>
        public AzureCdnEndpointCreateTask OriginHostHeader(string originHostHeader = null)
        {
            WithArguments("--origin-host-header");
            if (!string.IsNullOrEmpty(originHostHeader))
            {
                 WithArguments(originHostHeader);
            }

            return this;
        }

        /// <summary>
        /// A directory path on the origin that CDN can use to retreive content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        public AzureCdnEndpointCreateTask OriginPath(string originPath = null)
        {
            WithArguments("--origin-path");
            if (!string.IsNullOrEmpty(originPath))
            {
                 WithArguments(originPath);
            }

            return this;
        }

        /// <summary>
        /// Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
        /// </summary>
        public AzureCdnEndpointCreateTask QueryStringCaching(string queryStringCaching = null)
        {
            WithArguments("--query-string-caching");
            if (!string.IsNullOrEmpty(queryStringCaching))
            {
                 WithArguments(queryStringCaching);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureCdnEndpointCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
