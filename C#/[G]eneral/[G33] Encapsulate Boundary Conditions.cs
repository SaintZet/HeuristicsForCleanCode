if(level + 1 < tags.Length)
{
    parts = new Parse(body, tags, level + 1, offset + endTag);
    body = null;
}
// Notice that level+1 appears twice.
// This is a boundary condition that should be encapsulated within a variable named something like nextLevel.

int nextLevel = level + 1;
if(nextLevel < tags.Length)
{
    parts = new Parse(body, tags, nextLevel, offset + endTag);
    body = null;
}
