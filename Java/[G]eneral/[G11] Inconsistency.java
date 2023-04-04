public class ExampleClass {
    private HttpServletResponse response;

    public void processVerificationRequest() {
        // Use the response variable consistently throughout this function
        response.sendVerificationResponse();
    }

    public void processDeletionRequest() {
        // Use the response variable consistently throughout this function
        response.sendDeletionResponse();
    }

    // Use a similar naming convention for methods that process other kinds of requests
    public void processUpdateRequest() {
        // Use the response variable consistently throughout this function
        response.sendUpdateResponse();
    }
}
