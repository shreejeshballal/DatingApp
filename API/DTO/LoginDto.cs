using System;

namespace API.DTO;

public class LoginDto
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}
