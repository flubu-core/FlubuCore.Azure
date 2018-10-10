using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context.FluentInterface.Interfaces;

// ReSharper disable once CheckNamespace
namespace FlubuCore.Context
{
    public static class AzureExtension
    {
        /// <summary>
        /// Azure specific tasks.
        /// </summary>
        /// <param name="flubu"></param>
        /// <returns></returns>
        public static Azure.Azure Azure(this ITaskFluentInterface flubu)
        {
            return new Azure.Azure();
        }
    }
}
