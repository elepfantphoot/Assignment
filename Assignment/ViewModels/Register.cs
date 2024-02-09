using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class Register
{
	[Required]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only letters are allowed")]
    public string FirstName { get; set; }

	[Required]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only letters are allowed")]
    public string LastName { get; set; }

	[Required]
	[RegularExpression(@"^\d{16}$", ErrorMessage = "Credit Card number must be 16 digits")]
	public string CreditCardNo { get; set; }

	[Required]
	[RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number must be 10 digits")]
	public string MobileNo { get; set; }

	[Required]
	[StringLength(100)]
	public string BillingAddress { get; set; }

	[Required]
	[StringLength(100)]
	public string ShippingAddress { get; set; }

	[Required]
	[DataType(DataType.EmailAddress)]
	[EmailAddress(ErrorMessage = "Invalid Email Address")]
	public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{12,}$",
        ErrorMessage = "Password must be 12 characters minimum, with at least 1 uppercase, 1 lowercase, 1 number, and 1 special character")]
    public string Password { get; set; }

    [Required]
	[DataType(DataType.Password)]
	[Compare(nameof(Password), ErrorMessage = "Password and confirmation password does not match")]
	public string ConfirmPassword { get; set; }

	[Required]
	[RegularExpression(@"^.*\.jpg$", ErrorMessage = "Photo must be in .jpg format")]
	public string Photo { get; set; }
}
