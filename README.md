# ScanEventAPI

List of assumptions:
1.	A project exists in the solution that consumes this API and displays the results to the user.
2.	The GET method query parameters are validated before reaching the GET method
3.	The response of the GET method is stored somewhere in the application to keep a track of the last event scanned against a parcel and any pickup or delivery times. 

List of improvements:
1.	Create a database and link to the application. Create normalized table structure and procedures to retrieve and save the results from the database based on the HTTP methods.
2.	Create proper validation methods to ensure only appropriate parameter values reach the API methods.
3.	Create async methods to handle concurrent HTTP requests  
4.	Implement try catch block and return error codes based on the errors caught in the catch block, if any.
5.	Implement response caching for increase in response time.
6.	Expanding logging by capturing log information to a file to future references.
![image](https://user-images.githubusercontent.com/41140089/215387191-edb50f84-8dff-4346-9b1a-b060b1a385e7.png)
