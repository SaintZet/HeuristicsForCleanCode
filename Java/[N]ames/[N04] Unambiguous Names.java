private String doRename() throws Exception
{
    if(refactorReferences)
        renameReferences();
    renamePage();
    pathToRename.removeNameFromEnd();
    pathToRename.addNameToEnd(newName);
    return PathParser.render(pathToRename);
}
// The name of this function does not say what the function does except in broad and vague terms. 
// This is emphasized by the fact that there is a function named renamePage inside the function named doRename! 
// What do the names tell you about the difference between the two functions? Nothing.

// A better name for that function is renamePageAndOptionallyAllReferences. 
// This may seem long, and it is, but it's only called from one place in the module, so it's explanatory value outweighs the length.