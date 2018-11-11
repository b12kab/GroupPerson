I created this to help me figure out what was going on with GroupDisplayBinding. All other examples I found used ObservableCollection, which I could not figure out how to use a MVVM selection instead of a code behind item touch or item selected. 

[The original article](http://xamarinhelp.com/xamarin-forms-listview-grouping/) didn't have a zip or a git repo, so I thought I'd create my own.

###### In the releases:

V1 is pretty much like the original article, except that it used a ViewModel, removed the item touch and had the item selected in the ViewModel.

V1.1 was an experiment to see how this actually was working and hopefully be able to dynamically create this list, not just as a part of the array on the instantiation of the PersonList object. If I could delete this, I would :)

V2 is where I determined that only on the instantiation of the PersonList object is where the GroupDisplayBinding worked.

V3 I found that I had a mistake in V2 in why it wouldn't compile. Under further investigation, I found that properly adding the list or individual entries of People objects, it worked just fine. The updated ViewModel shows different ways of handing this.
