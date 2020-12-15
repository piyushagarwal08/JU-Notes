Public Class Form1
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      'defining the main menu bar
      Dim mnuBar As New MainMenu()
      'defining the menu items for the main menu bar
      Dim myMenuItemFile As New MenuItem("&File")
      Dim myMenuItemEdit As New MenuItem("&Edit")
      Dim myMenuItemView As New MenuItem("&View")
      Dim myMenuItemProject As New MenuItem("&Project")

      'adding the menu items to the main menu bar
      mnuBar.MenuItems.Add(myMenuItemFile)
      mnuBar.MenuItems.Add(myMenuItemEdit)
      mnuBar.MenuItems.Add(myMenuItemView)
      mnuBar.MenuItems.Add(myMenuItemProject)

     ' defining some sub menus
      Dim myMenuItemNew As New MenuItem("&New")
      Dim myMenuItemOpen As New MenuItem("&Open")
      Dim myMenuItemSave As New MenuItem("&Save")

      'add sub menus to the File menu
      myMenuItemFile.MenuItems.Add(myMenuItemNew)
      myMenuItemFile.MenuItems.Add(myMenuItemOpen)
      myMenuItemFile.MenuItems.Add(myMenuItemSave)

      'add the main menu to the form
      Me.Menu = mnuBar
     
      ' Set the caption bar text of the form.  
      Me.Text = "tutorialspoint.com"
   End Sub
End Class