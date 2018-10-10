
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Bot;

namespace FlubuCore.Azure
{
    public class Bot
    {
        
        
            public AzureBotCreateTask BotCreate(string kind ,  string name ,  string resourceGroup)
            {
                return new AzureBotCreateTask(kind,  name,  resourceGroup);
            }

            public AzureBotDeleteTask BotDelete(string name ,  string resourceGroup)
            {
                return new AzureBotDeleteTask(name,  resourceGroup);
            }

            public AzureBotDownloadTask BotDownload(string name ,  string resourceGroup)
            {
                return new AzureBotDownloadTask(name,  resourceGroup);
            }

            public AzureBotPreparePublishTask BotPreparePublish(string name ,  string projName ,  string resourceGroup ,  string slnName)
            {
                return new AzureBotPreparePublishTask(name,  projName,  resourceGroup,  slnName);
            }

            public AzureBotPublishTask BotPublish(string name ,  string resourceGroup)
            {
                return new AzureBotPublishTask(name,  resourceGroup);
            }

            public AzureBotUpdateTask BotUpdate(string name ,  string resourceGroup)
            {
                return new AzureBotUpdateTask(name,  resourceGroup);
            }

            public AzureBotAuthsettingTask BotAuthsetting()
            {
                return new AzureBotAuthsettingTask();
            }

            public AzureBotAuthsettingCreateTask BotAuthsettingCreate(string clientId ,  string clientSecret ,  string name ,  string providerScopeString ,  string resourceGroup ,  string service ,  string settingName)
            {
                return new AzureBotAuthsettingCreateTask(clientId,  clientSecret,  name,  providerScopeString,  resourceGroup,  service,  settingName);
            }

            public AzureBotAuthsettingDeleteTask BotAuthsettingDelete(string name ,  string resourceGroup ,  string settingName)
            {
                return new AzureBotAuthsettingDeleteTask(name,  resourceGroup,  settingName);
            }

            public AzureBotDirectlineTask BotDirectline()
            {
                return new AzureBotDirectlineTask();
            }

            public AzureBotDirectlineCreateTask BotDirectlineCreate(string name ,  string resourceGroup)
            {
                return new AzureBotDirectlineCreateTask(name,  resourceGroup);
            }

            public AzureBotDirectlineDeleteTask BotDirectlineDelete(string name ,  string resourceGroup)
            {
                return new AzureBotDirectlineDeleteTask(name,  resourceGroup);
            }

            public AzureBotEmailTask BotEmail()
            {
                return new AzureBotEmailTask();
            }

            public AzureBotEmailCreateTask BotEmailCreate(string emailAddress ,  string name ,  string password ,  string resourceGroup)
            {
                return new AzureBotEmailCreateTask(emailAddress,  name,  password,  resourceGroup);
            }

            public AzureBotEmailDeleteTask BotEmailDelete(string name ,  string resourceGroup)
            {
                return new AzureBotEmailDeleteTask(name,  resourceGroup);
            }

            public AzureBotFacebookTask BotFacebook()
            {
                return new AzureBotFacebookTask();
            }

            public AzureBotFacebookCreateTask BotFacebookCreate(string appid ,  string name ,  string pageId ,  string resourceGroup ,  string secret ,  string token)
            {
                return new AzureBotFacebookCreateTask(appid,  name,  pageId,  resourceGroup,  secret,  token);
            }

            public AzureBotFacebookDeleteTask BotFacebookDelete(string name ,  string resourceGroup)
            {
                return new AzureBotFacebookDeleteTask(name,  resourceGroup);
            }

            public AzureBotKikTask BotKik()
            {
                return new AzureBotKikTask();
            }

            public AzureBotKikCreateTask BotKikCreate(string key ,  string name ,  string resourceGroup ,  string userName)
            {
                return new AzureBotKikCreateTask(key,  name,  resourceGroup,  userName);
            }

            public AzureBotKikDeleteTask BotKikDelete(string name ,  string resourceGroup)
            {
                return new AzureBotKikDeleteTask(name,  resourceGroup);
            }

            public AzureBotMsteamsTask BotMsteams()
            {
                return new AzureBotMsteamsTask();
            }

            public AzureBotMsteamsCreateTask BotMsteamsCreate(string name ,  string resourceGroup)
            {
                return new AzureBotMsteamsCreateTask(name,  resourceGroup);
            }

            public AzureBotMsteamsDeleteTask BotMsteamsDelete(string name ,  string resourceGroup)
            {
                return new AzureBotMsteamsDeleteTask(name,  resourceGroup);
            }

            public AzureBotSkypeTask BotSkype()
            {
                return new AzureBotSkypeTask();
            }

            public AzureBotSkypeCreateTask BotSkypeCreate(string name ,  string resourceGroup)
            {
                return new AzureBotSkypeCreateTask(name,  resourceGroup);
            }

            public AzureBotSkypeDeleteTask BotSkypeDelete(string name ,  string resourceGroup)
            {
                return new AzureBotSkypeDeleteTask(name,  resourceGroup);
            }

            public AzureBotSlackTask BotSlack()
            {
                return new AzureBotSlackTask();
            }

            public AzureBotSlackCreateTask BotSlackCreate(string clientId ,  string clientSecret ,  string name ,  string resourceGroup ,  string verificationToken)
            {
                return new AzureBotSlackCreateTask(clientId,  clientSecret,  name,  resourceGroup,  verificationToken);
            }

            public AzureBotSlackDeleteTask BotSlackDelete(string name ,  string resourceGroup)
            {
                return new AzureBotSlackDeleteTask(name,  resourceGroup);
            }

            public AzureBotSmsTask BotSms()
            {
                return new AzureBotSmsTask();
            }

            public AzureBotSmsCreateTask BotSmsCreate(string accountSid ,  string authToken ,  string name ,  string phone ,  string resourceGroup)
            {
                return new AzureBotSmsCreateTask(accountSid,  authToken,  name,  phone,  resourceGroup);
            }

            public AzureBotSmsDeleteTask BotSmsDelete(string name ,  string resourceGroup)
            {
                return new AzureBotSmsDeleteTask(name,  resourceGroup);
            }

            public AzureBotTelegramTask BotTelegram()
            {
                return new AzureBotTelegramTask();
            }

            public AzureBotTelegramCreateTask BotTelegramCreate(string accessToken ,  string name ,  string resourceGroup)
            {
                return new AzureBotTelegramCreateTask(accessToken,  name,  resourceGroup);
            }

            public AzureBotTelegramDeleteTask BotTelegramDelete(string name ,  string resourceGroup)
            {
                return new AzureBotTelegramDeleteTask(name,  resourceGroup);
            }

            public AzureBotWebchatTask BotWebchat()
            {
                return new AzureBotWebchatTask();
            }
        
    }
}

