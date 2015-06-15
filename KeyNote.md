### Passing Object Between WebForm Pages

firstPage.aspx Code

```
Session["Item"] = myObjectInstance;
```

secondPage.aspx Code

```
// Null value check before using it

var myObjectInstance = (MyObjectInstance)Session["Item"];
```