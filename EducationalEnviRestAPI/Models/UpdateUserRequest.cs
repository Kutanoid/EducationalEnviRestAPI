﻿namespace EducationalEnviRestAPI.Models;

public class UpdateUserRequest
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}