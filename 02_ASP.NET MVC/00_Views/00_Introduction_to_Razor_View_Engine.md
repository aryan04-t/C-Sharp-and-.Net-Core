# Razor View Engine:  

- Razor view engine is the default view engine which renders the view in ASP.NET Core apps.  
- RazorView is made up with 3 things:  
    1. Razor MarkUp 
    2. C# 
    3. HTML 
- Razor View has a file extension of .cshtml 
- Razor View Engine parses the the RazorView into "Pure HTML" after implementing all the logics which were written in RazorMarkUp and C#, and then the "Pure HTML" is rendered on the browser for the user 


# Razor Syntax (Transferring Data from Controller to View): 

- We can create a Customer.cs file in Models folder, and in this C# file we can define a customer class, this class can be included in the CustomerController.cs file and in this controller file we can create customers List and pass that customer list to ViewBag using different names, and then we can access the view bag of the specific view in the RazorView file 
- In Razor Syntax, you can access the variables value using @ in the beginning of variables 
- And if you want to use the @ symbol in you text, then you can use the escape sequence @@ to use @ as a text directly in your HTML texts 


# Note: 
> Whenever You Create Views, By Default Keep the Name of the View Same as its Calling Action Method 