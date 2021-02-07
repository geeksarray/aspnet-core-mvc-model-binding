# ASP.NET Core MVC Model binding

This article explains what is model binding in ASP.NET Core MVC and how to use its different attributes like BindNever, BindRequired, FromHeader, FromQuery, FromRoute,  FromForm, FromServices, FromBody, ModelBinder, and model binding to a list of complex objects.

## What is MVC Model Binding

MVC controller action method uses Model binding to work directly with Model types, as model binding maps HTTP request data to action method parameters by name. MVC model binding will check for the value of each parameter by name and the name of the public settable property of the Model. These parameters can be primitive like string, int, or complex types. Model binders will map data between HTTP requests and models.

Model binding extract data from various sources like route, form fields of View, or query string, convert strings to .NET data type and provides this extracted data to controller and razor pages in method parameters.

## Files

1. [Product Model](https://github.com/geeksarray/aspnet-core-mvc-model-binding/blob/main/Areas/Products/Models/Product.cs)
1. [Product Repository](https://github.com/geeksarray/aspnet-core-mvc-model-binding/blob/main/Areas/Products/Models/ProductRepository.cs)
1. [Product Controller](https://github.com/geeksarray/aspnet-core-mvc-model-binding/blob/main/Areas/Products/Controllers/ProductController.cs)

### you can bind list of model objects and display in table like

![ASP.NET Core MVC Model Binding to List of Objects](https://geeksarray.com/images/blog/asp-net-core-mvc-model-binding-to-list-object.png)

Fore more detailed description and steps please visit - https://geeksarray.com/blog/aspnet-core-mvc-model-binding

