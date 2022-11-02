# BlazorModal

Simple Javascript-free Blazor Modal

Compatible with Bootstrap 3 and 4.

Sample code:

```
<Modal @ref="modal" DialogSize="Modal.enumDialogSize.Large">
    <ModalBody>
        Hello!!! Welcome to Blazor!
    </ModalBody>
</Modal>

<button class="btn btn-info" @onclick="openModal">Open Modal! </button>

@code
{
    Modal modal;
    void openModal()
    {
        modal.Show();
    }
}
```
Parameters: 

Dialog Size : Modal.enumDialogSize.Normal, Modal.enumDialogSize.Large, of Modal.enumDialogSize.FitScreen

displayCloseButton : boolean

bgColor: hex or string value
```
<ModalHeader>
<ModalBody>
<ModalFooter>
 ```
Events: Show, Hide

Nuget-package: https://www.nuget.org/packages/BlazorModal

In your _Host.cshtml or index.html:
```
<link href="your-app-name.styles.css" rel="stylesheet" />
```
In your _Imports.razor:
```
@using BlazorModal 
```

