// In this example, the SendMessage() method takes 6 arguments, which can cause problems when reading and using the code.
// In addition, these arguments do not give a clear understanding of what is happening inside the method.
public void SendMessage(string message, string recipient, bool isUrgent, bool isPrivate, bool isEncrypted, bool isSigned)
{
    // message sending code
}

// Instead, we could use an object to group these arguments:
public class Message
{
    private string message;
    private bool isUrgent;
    private bool isPrivate;
    private bool isEncrypted;
    private bool isSigned;

    // getters and setters for all fields
}

public void SendMessage(Message message, string recipient)
{
    // message sending code
}

// This approach makes the code more readable and understandable,
// since we have only one argument that contains all the necessary data for sending a message.