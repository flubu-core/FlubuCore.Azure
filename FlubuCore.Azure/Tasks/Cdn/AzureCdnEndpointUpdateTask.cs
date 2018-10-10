
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnEndpointUpdateTask : ExternalProcessTaskBase<AzureCdnEndpointUpdateTask>
     {
        
        /// <summary>
        /// Update a CDN endpoint to manage how content is delivered.
        /// </summary>
        public AzureCdnEndpointUpdateTask(string name = null ,  string profileName = null ,  string resourceGroup = null)
        {
            WithArguments("az cdn endpoint update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
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
        public AzureCdnEndpointUpdateTask ContentTypesToCompress(string contentTypesToCompress = null)
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
        public AzureCdnEndpointUpdateTask EnableCompression(string enableCompression = null)
        {
            WithArguments("--enable-compression");
            if (!string.IsNullOrEmpty(enableCompression))
            {
                 WithArguments(enableCompression);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.
        /// </summary>
        public AzureCdnEndpointUpdateTask NoHttp(string noHttp = null)
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
        public AzureCdnEndpointUpdateTask NoHttps(string noHttps = null)
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
        public AzureCdnEndpointUpdateTask OriginHostHeader(string originHostHeader = null)
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
        public AzureCdnEndpointUpdateTask OriginPath(string originPath = null)
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
        public AzureCdnEndpointUpdateTask QueryStringCaching(string queryStringCaching = null)
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
        public AzureCdnEndpointUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureCdnEndpointUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureCdnEndpointUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureCdnEndpointUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureCdnEndpointUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
