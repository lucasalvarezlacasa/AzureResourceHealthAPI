# AzureResourceHealthAPI
This is a basic example created for communicating with the Azure Resource Health API.
Before using it, go to SubscriptionHelper.cs and complete the necessary variables in there:

1) tenantId: this is the tenant id for your organization. Check how to obtain it here: https://stackoverflow.com/questions/26384034/how-to-get-the-azure-account-tenant-id

2) appId and appKey: to obtain these values, you will need to register a new application in the Azure portal. Since this will be a console application, I recommend you to add a new Web Api application into the Azure portal and then create a secret for it (used as appKey value here). Read this link for more details: https://docs.microsoft.com/en-us/azure/active-directory/develop/active-directory-integrating-applications

3) subscriptionId: this is the subscription you will use for getting the resource information. To find the ID, just type down the name of the subscription in the Azure portal search bar and then click on it. After that, you will get redirected to the subscription detail page where the id can be found.

Thanks everybody!
