using BookShopAPI.Context;
using BookShopAPI.DTOs.Authantication;
using BookShopAPI.DTOs.Books;
using BookShopAPI.Helper.Enums;
using BookShopAPI.Interfaces;
using BookShopAPI.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static BookShopAPI.Helper.Enums.Enums;

namespace BookShopAPI.Controllers
{
    public class SharedController : ControllerBase, ISharedInterface
    {

        private readonly BookShopDbContext _BookShopDbContext;
        public SharedController(BookShopDbContext context)
        {
            _BookShopDbContext = context;
        }

        //***************************************************************************************************************************

        #region Get Information


        [HttpGet]
        [Route("[action]/{Id}")]
        public async Task<IActionResult> GetBookDetailsAction(int Id)
        {
            try
            {
                return Ok(await GetBookDetails(Id));
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = "Something Went Wrong" };
            }
        }



        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetBooksAction(string? title, string? Author, int? type)
        {
            try
            {
                return Ok(await GetBooks(title, Author, type));
            }
            catch (Exception ex)
            {
                throw new Exception("Test Exception");
            }
        }

        #endregion

        //*********************************************************************************************************************
        #region Authantication


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewAccountAction(RegistrationDTO dto)
        {
            try
            {
                await CreateNewAccount(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "New Account Has Been Activated" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Failed Createing Account  {ex.Message}" };
            }
        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> LoginAction(LoginDTO dto)
        {
            try
            {
                await Login(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Login Success" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Login Failed {ex.Message}" };
            }
        }


        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> ResetPasswordAction(ResetPasswordDTO dto)
        {
            try
            {
                await ResetPassword(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "ResetPassword Success" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"ResetPassword Failed {ex.Message}" };
            }
        }
        #endregion
        //***************************************************************

        #region Implementations Authantication

        [NonAction]
        public async Task CreateNewAccount(RegistrationDTO dto)
        {
            //validation
            if (string.IsNullOrEmpty(dto.Email))
                throw new Exception("Email Is Required");
            if (string.IsNullOrEmpty(dto.Phone))
                throw new Exception("Phone Is Required");
            if (string.IsNullOrEmpty(dto.Password))
                throw new Exception("Password Is Required");
            if (string.IsNullOrEmpty(dto.FirstName))
                throw new Exception("Name Is Required");
            if (string.IsNullOrEmpty(dto.LastName))
                throw new Exception("Name Is Required");
            Person user = new Person();
            user.Email = dto.Email;
            user.Phone = dto.Phone;
            user.Password = dto.Password;
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.BirthDate = dto.BirthDate;
            user.Gender = dto.Gender;
            user.IsActive = true;
            await _BookShopDbContext.AddAsync(user);
            await _BookShopDbContext.SaveChangesAsync();
        }

        [NonAction]
        public async Task Login(LoginDTO dto)
        {
            if (string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Password))
                throw new Exception("Email and Password are required");
            var login = await _BookShopDbContext.People
                 .Where(x => x.Email.Equals(dto.Email) && x.Password.Equals(dto.Password))
                 .SingleOrDefaultAsync();
            if (login == null)
            {
                throw new Exception("Email Or Password Is Not Correct");
            }
        }


        [NonAction]
        public async Task ResetPassword(ResetPasswordDTO dto)
        {
            if (string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Phone))
                throw new Exception("Email and Phone are required");
            var user = await _BookShopDbContext.People.Where(x => x.Email.Equals(dto.Email)
            && x.Phone.Equals(dto.Phone)).SingleOrDefaultAsync();
            if (user == null)
            {
                throw new Exception("User Not Found");
            }
            else
            {
                if (string.IsNullOrEmpty(dto.Password) || string.IsNullOrEmpty(dto.ConfirmPassword))
                    throw new Exception("Password and ConfirmPassword are required");
                else
                {
                    if (dto.Password.Equals(dto.ConfirmPassword))
                    {
                        user.Password = dto.ConfirmPassword;
                        _BookShopDbContext.Update(user);
                        await _BookShopDbContext.SaveChangesAsync();
                    }
                }

            }
        }
        #endregion

        //***********************************************************************************************************************
        #region Implementations Get Information


        /// <summary>
        /// Retrieves Book Detail
        /// </summary>
        [NonAction]
        public async Task<BookDetailsDTO> GetBookDetails(int Id)
        {
            var query = await (from e in _BookShopDbContext.Books
                               where e.Id == Id
                               select new BookDetailsDTO
                               {
                                   Id = e.Id,
                                   BookType = e.BookType,
                                   Title = e.Title,
                                   Author = e.Author,
                                   Description = e.Description,
                                   PublishedDate = e.PublishedDate,
                                   Price = e.Price,

                               }
                               ).SingleAsync();
            return query;
        }



        /// <summary>
        /// Retrieves  All Books In The Data base
        /// </summary>
        [NonAction]
        public async Task<List<BookCardDTO>> GetBooks(string? title, string? Author, int? type)
        {
            BooksType moo = BooksType.none;
            if (Enum.IsDefined(typeof(BooksType), type == null ? 1000 : type))
                moo = (BooksType)Enum.ToObject(typeof(BooksType), type);
            
            bool flag = title == null && Author == null && type == null ? true : false;
 
            var query = from t in _BookShopDbContext.Books
                        where t.BookType == moo
                        || flag
                        select t;


            List<BookCardDTO> result = new List<BookCardDTO>();
            foreach (var evt in query)
            {
                BookCardDTO temp = new BookCardDTO();
                temp.Id = evt.Id;
                temp.Title = evt.Title;
                temp.Author = evt.Author;
                temp.Price = evt.Price;
                result.Add(temp);
            }
            return result;
        }



            #endregion

        }
}
