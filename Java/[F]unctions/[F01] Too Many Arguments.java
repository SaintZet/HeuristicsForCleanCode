// In this example, the SendMessage() method takes 6 arguments, which can cause problems when reading and using the code.
// In addition, these arguments do not give a clear understanding of what is happening inside the method.
public void sendMessage(String message, String recipient, boolean isUrgent, boolean isPrivate, boolean isEncrypted, boolean isSigned) {
    // message sending code
}

// Instead, we could use an object to group these arguments:
public class Message {
    private String message;
    private boolean isUrgent;
    private boolean isPrivate;
    private boolean isEncrypted;
    private boolean isSigned;

    // getters and setters for all fields
}

public void sendMessage(Message message, String recipient) {
    // message sending code
}

// This approach makes the code more readable and understandable,
// since we have only one argument that contains all the necessary data for sending a message.