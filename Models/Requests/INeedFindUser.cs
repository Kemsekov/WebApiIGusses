namespace WebApi.Models.Requests
{
    public interface INeedFindUser
    {
        string FindUserBy{get;set;}
        string UserName{get;set;}
        string Email{get;set;}
        string Id{get;set;}
    }
}