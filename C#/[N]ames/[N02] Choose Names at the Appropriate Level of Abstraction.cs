// Consider the Modem interface below:

public interface Modem
{
    bool Dial(string phoneNumber);
    bool Disconnect();
    bool Send(char c);
    char Recv();
    string GetConnectedPhoneNumber();
}
// At first this looks fine. The functions all seem appropriate.
// Indeed, for many applications they are. But now consider an application in which some modems aren't connected by dialling.
// Rather they are connected permanently by hard wiring them together
// (think of the cable modems that provide Internet access to most homes nowadays).
// Perhaps some are connected by sending a port number to a switch over a USB connection.
// Clearly the notion of phone numbers is at the wrong level of abstraction. A better naming strategy for this scenario might be:

public interface Modem
{
    bool Connect(string connectionLocator);
    bool Disconnect();
    bool Send(char c);
    char Recv();
    string GetConnectedLocator();
}
// Now the names don't make any commitments about phone numbers.
// They can still be used for phone numbers, or they could be used for any other kind of connection strategy.