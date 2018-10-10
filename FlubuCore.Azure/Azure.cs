
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;

namespace FlubuCore.Azure
{
    public class Azure
    {
        
        public Account Account ()
        {
            return new Account();
        }
        public Acr Acr ()
        {
            return new Acr();
        }
        public Acs Acs ()
        {
            return new Acs();
        }
        public Aks Aks ()
        {
            return new Aks();
        }
        public Bot Bot ()
        {
            return new Bot();
        }
        public Cdn Cdn ()
        {
            return new Cdn();
        }
        public Cloud Cloud ()
        {
            return new Cloud();
        }
        public Container Container ()
        {
            return new Container();
        }
        public Cosmosdb Cosmosdb ()
        {
            return new Cosmosdb();
        }
        public Deployment Deployment ()
        {
            return new Deployment();
        }
        public Disk Disk ()
        {
            return new Disk();
        }
        public Dms Dms ()
        {
            return new Dms();
        }
        public Extension Extension ()
        {
            return new Extension();
        }
        public Feature Feature ()
        {
            return new Feature();
        }
        public Functionapp Functionapp ()
        {
            return new Functionapp();
        }
        public Group Group ()
        {
            return new Group();
        }
        public Identity Identity ()
        {
            return new Identity();
        }
        public Image Image ()
        {
            return new Image();
        }
        public Keyvault Keyvault ()
        {
            return new Keyvault();
        }
        public Lab Lab ()
        {
            return new Lab();
        }
        public Lock Lock ()
        {
            return new Lock();
        }
        public Managedapp Managedapp ()
        {
            return new Managedapp();
        }
        public Provider Provider ()
        {
            return new Provider();
        }
        public Redis Redis ()
        {
            return new Redis();
        }
        public Resource Resource ()
        {
            return new Resource();
        }
        public Sig Sig ()
        {
            return new Sig();
        }
        public Signalr Signalr ()
        {
            return new Signalr();
        }
        public Snapshot Snapshot ()
        {
            return new Snapshot();
        }
        public Tag Tag ()
        {
            return new Tag();
        }
        public Vm Vm ()
        {
            return new Vm();
        }
        public Vmss Vmss ()
        {
            return new Vmss();
        }
        public Webapp Webapp ()
        {
            return new Webapp();
        }
        public Ad Ad ()
        {
            return new Ad();
        }
        public Advisor Advisor ()
        {
            return new Advisor();
        }
        public Ams Ams ()
        {
            return new Ams();
        }
        public Appservice Appservice ()
        {
            return new Appservice();
        }
        public Backup Backup ()
        {
            return new Backup();
        }
        public Batch Batch ()
        {
            return new Batch();
        }
        public Batchai Batchai ()
        {
            return new Batchai();
        }
        public Billing Billing ()
        {
            return new Billing();
        }
        public Cognitiveservices Cognitiveservices ()
        {
            return new Cognitiveservices();
        }
        public Consumption Consumption ()
        {
            return new Consumption();
        }
        public Dla Dla ()
        {
            return new Dla();
        }
        public Dls Dls ()
        {
            return new Dls();
        }
        public Eventgrid Eventgrid ()
        {
            return new Eventgrid();
        }
        public Eventhubs Eventhubs ()
        {
            return new Eventhubs();
        }
        public Alias Alias ()
        {
            return new Alias();
        }
        public Iot Iot ()
        {
            return new Iot();
        }
        public Network Network ()
        {
            return new Network();
        }
        public Monitor Monitor ()
        {
            return new Monitor();
        }
        public Managementpartner Managementpartner ()
        {
            return new Managementpartner();
        }
        public Mesh Mesh ()
        {
            return new Mesh();
        }
        public Mysql Mysql ()
        {
            return new Mysql();
        }
        public Postgres Postgres ()
        {
            return new Postgres();
        }
        public Graph Graph ()
        {
            return new Graph();
        }
        public Hanainstance Hanainstance ()
        {
            return new Hanainstance();
        }
        public Storage Storage ()
        {
            return new Storage();
        }
        public Iotcentral Iotcentral ()
        {
            return new Iotcentral();
        }
        public Maps Maps ()
        {
            return new Maps();
        }
        public Mariadb Mariadb ()
        {
            return new Mariadb();
        }
        public Policy Policy ()
        {
            return new Policy();
        }
        public Relay Relay ()
        {
            return new Relay();
        }
        public Reservations Reservations ()
        {
            return new Reservations();
        }
        public Role Role ()
        {
            return new Role();
        }
        public Search Search ()
        {
            return new Search();
        }
        public Servicebus Servicebus ()
        {
            return new Servicebus();
        }
        public Sf Sf ()
        {
            return new Sf();
        }
        public Sql Sql ()
        {
            return new Sql();
        }
        
            public AzureConfigureTask Configure()
            {
                return new AzureConfigureTask();
            }

            public AzureFeedbackTask Feedback()
            {
                return new AzureFeedbackTask();
            }

            public AzureFindTask Find(string searchQuery)
            {
                return new AzureFindTask(searchQuery);
            }

            public AzureInteractiveTask Interactive()
            {
                return new AzureInteractiveTask();
            }

            public AzureLoginTask Login()
            {
                return new AzureLoginTask();
            }

            public AzureLogoutTask Logout()
            {
                return new AzureLogoutTask();
            }
        
    }
}

