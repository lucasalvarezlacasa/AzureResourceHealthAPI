# AzureResourceHealthAPI
This is a basic example created for communicating with the Azure Resource Health API. You will need to have access to http://portal.azure.com in order to register a new application and obtain the required values for this sample to work.

Before using it, go to **SubscriptionHelper.cs** and complete the necessary variables in there:

1) **tenantId**: this is the tenant id for your organization. To retrieve it:
- Click on Azure Active Directory.
- Select Properties.
- Copy the value that appears below Directory ID.

![alt text](https://github.com/lucasalvarezlacasa/AzureResourceHealthAPI/blob/master/ReadmeIMGs/img1.png)

2) **appId** and **appKey**: to obtain these values, you will need to register a new application in the Azure portal and give the corresponding permissions to it.
- Click on Azure Active Directory.
- Click on App Registrations and then New application registration.
- Choose a name for your app, select Web app / API as the application type (since this is a console app) and finally complete the Sign-on URL (you can use https://localhost for this one, since it's not relevant at all). Then hit on Create.

![alt text](https://github.com/lucasalvarezlacasa/AzureResourceHealthAPI/blob/master/ReadmeIMGs/img2.png)

- Now that the application is created, you can automatically obtain the first value that we needed: **appId**. It's located on the top right corner.

![alt text](https://github.com/lucasalvarezlacasa/AzureResourceHealthAPI/blob/master/ReadmeIMGs/img3.png)

- Now we need to generate the secret key for our application, this is, the **appKey**. For this, click on Keys and generate a new one. You can select Never Expires as the duration for it. After saving, you will have one opportunity in order to copy the secret, since it won't be displayed after that anymore.

![alt text](https://github.com/lucasalvarezlacasa/AzureResourceHealthAPI/blob/master/ReadmeIMGs/img4.png)

![alt text](https://github.com/lucasalvarezlacasa/AzureResourceHealthAPI/blob/master/ReadmeIMGs/img5.png)


Read these two links for a deeper understanding: 
- https://docs.microsoft.com/en-us/azure/active-directory/develop/active-directory-integrating-applications
- https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-create-service-principal-portal


3) **subscriptionId**: this is the subscription you will use for getting the resource information. To find the ID, just type down the name of the subscription in the Azure portal search bar and then click on it. After that, you will get redirected to the subscription detail page where the id can be found.

4) Permissions: 

Thanks everybody!
