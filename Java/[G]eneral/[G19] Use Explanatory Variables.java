Matcher match = headerPattern.matcher(line);
if(match.find())
{
    String key = match.group(1);
    String value = match.group(2);
    headers.put(key.toLowerCase(), value);
}
//The simple use of explanatory variables makes it clear that the first matched group is the key, and the second matched group is the value.

// It is hard to overdo this. More explanatory variables are generally better than fewer.
// It is remarkable how an opaque module can suddenly become transparent simply by breaking the calculations up into well-named intermediate values.
