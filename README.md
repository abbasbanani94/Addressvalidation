# Addressvalidation
windows form that validates addresses using USPS's API from csv file.
for ERP systems' users such as SalesForce and ZohoCrm they need to verify that the addresses of the US contacts are correct and formatted,
the form uses USPS address validation API to check wheter the address given is correct or not and returns the correct formatted one,
then creates a new file in the same location of the original with the word "Validated" after its name, the new file will add the new data to the previous
of the original file.

language used is C# and created by Visual Studio 2015

Notes : 
- make sure that the csv file doesn't have any commas, single or double qoutations.
- make sure that the csv file doesn't have any wrapped cells.

How it works :
1- the form takes a csv file that we need to verify addresses in by clicking on browse button and selecting the file.
2- type your USPS userId to the userId textbox in the form so you can use the api.
3- type the indexes of the address1, address2, city, state and zip code columns.
4- click on validate button.
5- the form will run the API request for each address and create a new file in the same location of the original.

