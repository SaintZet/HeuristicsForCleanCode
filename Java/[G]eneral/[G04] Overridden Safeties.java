java.io.Serializable:

import java.io.Serializable;

@SuppressWarnings("serial")
public class MyClass implements Serializable {
    // fields, constructors and class methods
}
// Generally, using @SuppressWarnings should only be used when you are certain that
// a compiler warning is a false positive and cannot be corrected in a more correct way. 
// The use of @SuppressWarnings should be limited and only used where necessary.