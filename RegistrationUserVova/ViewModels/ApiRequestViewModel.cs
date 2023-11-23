namespace RegistrationUserVova.ViewModels
{
    public class ApiRequestViewModel
    {
        public string EndpointUrl { get; set; }
        public string HttpMethod { get; set; } 
        public object Payload { get; set; }
    }
}
