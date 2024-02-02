using BookShopAPI.DTOs.Authantication;

namespace BookShopAPI.Interfaces
{
    public class IAdmin
    {
        //Filltering Event 
        Task<List<EventInfoDTO>> GetEvents(string? title, DateTime? time, int? type);
        //GetEventDetailsById
        Task<EventDetailsDTO> GetEventDetails(int Id);
        //Registraition
        Task CreateNewAccount(RegistrationDTO dto);
        //Login
        Task Login(LoginDTO dto);
        //ResetPassword
        Task ResetPassword(ResetPasswordDTO dto);
    }
}
