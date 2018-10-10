
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Redis;

namespace FlubuCore.Azure
{
    public class Redis
    {
        
        
            public AzureRedisCreateTask RedisCreate(string location ,  string name ,  string resourceGroup ,  string sku ,  string vmSize)
            {
                return new AzureRedisCreateTask(location,  name,  resourceGroup,  sku,  vmSize);
            }

            public AzureRedisDeleteTask RedisDelete(string name ,  string resourceGroup)
            {
                return new AzureRedisDeleteTask(name,  resourceGroup);
            }

            public AzureRedisExportTask RedisExport(string container ,  string name ,  string prefix ,  string resourceGroup)
            {
                return new AzureRedisExportTask(container,  name,  prefix,  resourceGroup);
            }

            public AzureRedisForceRebootTask RedisForceReboot(string name ,  string rebootType ,  string resourceGroup)
            {
                return new AzureRedisForceRebootTask(name,  rebootType,  resourceGroup);
            }

            public AzureRedisImportTask RedisImport(string fileFormat ,  string files ,  string name ,  string resourceGroup)
            {
                return new AzureRedisImportTask(fileFormat,  files,  name,  resourceGroup);
            }

            public AzureRedisImportMethodTask RedisImportMethod(string fileFormat ,  string files ,  string name ,  string resourceGroup)
            {
                return new AzureRedisImportMethodTask(fileFormat,  files,  name,  resourceGroup);
            }

            public AzureRedisRegenerateKeysTask RedisRegenerateKeys(string keyType ,  string name ,  string resourceGroup)
            {
                return new AzureRedisRegenerateKeysTask(keyType,  name,  resourceGroup);
            }

            public AzureRedisUpdateTask RedisUpdate(string name ,  string resourceGroup)
            {
                return new AzureRedisUpdateTask(name,  resourceGroup);
            }

            public AzureRedisUpdateSettingsTask RedisUpdateSettings(string name ,  string redisConfiguration ,  string resourceGroup)
            {
                return new AzureRedisUpdateSettingsTask(name,  redisConfiguration,  resourceGroup);
            }

            public AzureRedisPatchScheduleTask RedisPatchSchedule()
            {
                return new AzureRedisPatchScheduleTask();
            }

            public AzureRedisPatchScheduleDeleteTask RedisPatchScheduleDelete(string name ,  string resourceGroup)
            {
                return new AzureRedisPatchScheduleDeleteTask(name,  resourceGroup);
            }

            public AzureRedisPatchScheduleSetTask RedisPatchScheduleSet(string name ,  string resourceGroup ,  string scheduleEntries)
            {
                return new AzureRedisPatchScheduleSetTask(name,  resourceGroup,  scheduleEntries);
            }
        
    }
}

