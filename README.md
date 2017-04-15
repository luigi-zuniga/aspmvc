# The model MVC (Model-View-Controller)

Strictly speaking you can pass a single object into view, which would be the Model.
But sometimes the sight needs more information. That's where the ViewBag comes in. Using the ViewBag one can pass any additional data / object that is needed in the view,
Such as a title, or a boolean to control whether the view is opened in edit mode or in New Record mode, etc.

* ViewBag and ViewData

# ViewBag - ViewData - TempData (TempData Keep Method)
> Used to pass data from Controller to Corresponding view
- ViewData is a dictionary of objects that is derived from ViewDataDictionary class and is accessible using strings as keys
- ViewBag is a simple transport method between the view and controller.
- VieBag is a dynamic container
- ViewData requires typecasting for complex data type check for null values to avoid error
- ViewBag doesnot requiere typecasting for complex data type

```sh
  ViewBag.MyName = "Name",
  ViewData["MyName"] = "Name"
```
# TempData
>TempData is also a dictionary object derived from TempDataDictionary class and Stored in short lives session
>It Help to maintain data when you move from one controller to other controller or from one action to other action

```sh
TempData["MyName"]="Name"
```
This Method can pass value be preserved, Only when we want to redirect on Second Page the use value Keep  
```sh
TempData.Keep();
```

ASP.net MVC
----

**By Luigi, Yeah!**
