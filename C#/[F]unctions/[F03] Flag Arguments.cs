public void SendMessage(string message, string recipient, bool isUrgent, bool isPrivate, bool isEncrypted, bool isSigned)
{
    // message sending code
}

// It is possible to divide this method into several smaller and specialized ones.

// This approach will improve the readability and maintainability of the code,
// as each method will perform only one specific operation, and their names will reflect this operation.
// In addition, this will avoid the need to pass multiple arguments to methods,
// which will reduce the likelihood of errors and simplify code testing and debugging.

public void SendMessage(Message message, string recipient)
{
    // message sending code
}

public class Message
{
    public void MarkUrgent() { ... }

    public void MarkPrivate() { ... }

    public void Encrypt() { ... }

    public void Sign(string signatory) { .. }
}