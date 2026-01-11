# WPFTreeView
WPF TreeView example with ViewModel and View separated in different projects 

## WPFTreeView Project: 
Main Project which creates the View (Usercontrol) and connects to the ViewModel vie DataTemplate dictionary
The styles are loaded in this project to prove that it does not have to be bound to the xml View

## WPFTreeView.View Project: 
TreeView with __SelectedItem binding property__ and cleanup

## WPFTreeView.ViewModel Project: 
ViewModel to load the items and control the selection
