using System.ComponentModel.DataAnnotations;

namespace ShopApp.Models;

public class RegisterUserViewModel
{
    [Required(ErrorMessage = "Аты-жөні міндетті")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "2-50 таңба аралығында болуы керек")]
    [Display(Name = "Аты-жөні")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email міндетті")]
    [EmailAddress(ErrorMessage = "Email форматы дұрыс емес")]
    [Display(Name = "Email")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Жасы міндетті")]
    [Range(18, 100, ErrorMessage = "Жас 18-100 аралығында болуы керек")]
    [Display(Name = "Жасы")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Құпиясөз міндетті")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Кемінде 6 таңба")]
    [DataType(DataType.Password)]
    [Display(Name = "Құпиясөз")]
    public string Password { get; set; } = string.Empty;

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Құпиясөздер сәйкес емес")]
    [Display(Name = "Құпиясөзді растау")]
    public string ConfirmPassword { get; set; } = string.Empty;

    [RegularExpression(@"^\+?7\d{10}$", ErrorMessage = "Телефон форматы: +7XXXXXXXXXX")]
    [Display(Name = "Телефон")]
    public string? Phone { get; set; }
}