using System.ComponentModel.DataAnnotations;

namespace ASPNet.API.Models.DTOs;

public class LoginRequestDTO
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Username { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}