using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TodoAppWithJWT.Models.DTOs.Requests{
    public class TokenRequest{
        [Required]
        public string Token {get;set;}

        [Required]
        public string RefreshToken {get;set;}
    }
}