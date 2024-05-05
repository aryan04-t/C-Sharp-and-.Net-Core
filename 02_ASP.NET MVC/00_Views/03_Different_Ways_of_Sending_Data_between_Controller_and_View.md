# Different Ways for Sending Data Between Controller and View: 

1. Controller to View: 
    - ViewBag.variableName = data 
    - ViewData["key"] = value 

2. Controller to Controller / Controller to View and Vice Versa: 
    - TempData can be used 
    - TempData also stores data in key-value pair like ViewData 


> For complex types do typecasting in the case of key-value pairs 



# Using Anchor Tag Helper 

<a asp-controller="Demo" asp-action="Method-2"> Click Me </a> 


# Add Middleware for Using Session for Storing Data: 
    - builder.Session.AddSession(); 
    - HttpContext.Session.SetString("username", "Aryan"); 
    - HttpContext.Session.GetString("username"); 
    - HttpContext.Session.Remove("username"); 


> Session uses cookies internally to store data 


# QueryString: 
    - !String.isNullOrEmpty(HttpContext.Request.Query["name"]) 