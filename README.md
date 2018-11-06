I created this to help me figure out what was going on with GroupDisplayBinding. All other examples I found used ObservableCollection, which I could not figure out how to use a MVVM selection instead of a code behind item touch or item selected. 

[The original article](http://xamarinhelp.com/xamarin-forms-listview-grouping/) didn't have a zip or a git repo, so I thought I'd create my own.

###### In the releases:

V1 is pretty much like the original article, except that it used a ViewModel, removed the item touch and had the item selected in the ViewModel.

V1.1 was an experiment to see how this actually was working and hopefully be able to dynamically create this list, not just as a part of the array on the instantiation of the PersonList object. If I could delete this, I would :)

V2 is where I found that only on the instantiation of the PersonList object is where the GroupDisplayBinding worked. All my other experimentation had either the group with the letter and no data or no data at all on the ListView. I commented out the PersonList's Person property, to be sure that others were able to get this point only on instantiation would this work.