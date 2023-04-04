// If within a particular function you use a variable named response to hold an HttpResponse ,
// then use the same variable name consistently in the other functions that use HttpResponse objects.
// If you name a method processVerificationRequest, then use a similar name,
// such as processDeletionRequest, for the methods that process other kinds of requests.
public class ExampleClass
{
    private HttpResponse response;

    public void ProcessVerificationRequest()
    {
        // Use the response variable consistently throughout this function
        response.SendVerificationResponse();
    }

    public void ProcessDeletionRequest()
    {
        // Use the response variable consistently throughout this function
        response.SendDeletionResponse();
    }

    // Use a similar naming convention for methods that process other kinds of requests
    public void ProcessUpdateRequest()
    {
        // Use the response variable consistently throughout this function
        response.SendUpdateResponse();
    }
}