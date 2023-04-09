public interface IStack
{
    object Pop();
    void Push(object o);
    double PercentFull();
    class EmptyException : Exception { }
    class FullException : Exception { }
}

// The PercentFull function is at the wrong level of abstraction.
// Although there are many implementations of Stack where the concept of fullness is reasonable, 
// there are other implementations that simply could not know how full they are. 
// So the function would be better placed in a derivative interface such as BoundedStack.

// Perhaps you are thinking that the implementation could just return zero if the stack were boundless. 
// The problem with that is that no stack is truly boundless. 
// You cannot really prevent an OutOfMemoryException by checking for

stack.PercentFull() < 50.0.

// Implementing the function to return 0 would be telling a lie.
