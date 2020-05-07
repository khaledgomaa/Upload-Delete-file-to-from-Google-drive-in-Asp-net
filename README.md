# Upload-Delete-file-to-from-Google-drive-in-Asp-net

Welcome to this simple api 

prerequisites : 
- install google drive api v3 in your project from NuGet console using this command :- Install-Package Google.Apis.Drive.v3

- then you need to follow this docementation : https://www.iperiusbackup.net/en/how-to-enable-google-drive-api-and-get-client-credentials/ 
to create your project on google cloud using google drive api library and download the credentials.json file.

Explain :- 

1) googledrive.cs :- contains a three functions
You'll find two classes , googledrive.cs which contains a three functions :

- GetService() : responsible to establish the connection to google drive api , required before any operation upload , delete and so on to google drive api , 
some changes you should to do your own : 
var path = HttpContext.Current.Server.MapPath("/credentials.json"); line code in GetService() 
"/credentials.json" this file which you need to download after creating your project on google cloud platform then all you have to do just import the file to your project

-FileUpload() :- takes your image path on your pc then upload to google drive and return the id of the uploaded image which you can later delete or view the image using this id

DeleteFile() :- takes id of the image required to be deleted which already saved from the above step



2) ProductsController.cs :- just contains two functions 

- addproduct() : which takes filepath and send to googledrive.FileUpload()

-deleteProduct() : takes the fileId and delete it from google drive


