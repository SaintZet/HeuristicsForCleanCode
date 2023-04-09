private string DoRename()
{
    if(_refactorReferences)
        RenameReferences();

    RenamePage();
    _pathToRename.RemoveNameFromEnd();
    _pathToRename.AddNameToEnd(newName);

    return _pathParser.Render(pathToRename);
}
// The name of this function does not say what the function does except in broad and vague terms.
// This is emphasized by the fact that there is a function named RenamePage inside the function named DoRename!
// What do the names tell you about the difference between the two functions? Nothing.

// A better name for that function is RenamePageAndOptionallyAllReferences.
// This may seem long, and it is, but it's only called from one place in the module, so it's explanatory value outweighs the length.