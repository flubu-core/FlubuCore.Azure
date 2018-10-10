
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsPreviewTask : ExternalProcessTaskBase<AzureDlsFsPreviewTask>
     {
        
        /// <summary>
        /// Preview the content of a file in a Data Lake Store account.
        /// </summary>
        public AzureDlsFsPreviewTask(string account = null ,  string path = null)
        {
            WithArguments("az dls fs preview");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates that, if the preview is larger than 1MB, still retrieve it. This can potentially be very slow, depending on how large the file is.
        /// </summary>
        public AzureDlsFsPreviewTask Force(string force = null)
        {
            WithArguments("--force");
            if (!string.IsNullOrEmpty(force))
            {
                 WithArguments(force);
            }

            return this;
        }

        /// <summary>
        /// The amount of data to preview in bytes.
        /// </summary>
        public AzureDlsFsPreviewTask Length(string length = null)
        {
            WithArguments("--length");
            if (!string.IsNullOrEmpty(length))
            {
                 WithArguments(length);
            }

            return this;
        }

        /// <summary>
        /// The position in bytes to start the preview from.
        /// </summary>
        public AzureDlsFsPreviewTask Offset(string offset = null)
        {
            WithArguments("--offset");
            if (!string.IsNullOrEmpty(offset))
            {
                 WithArguments(offset);
            }

            return this;
        }
     }
}
