using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HotelManagementAF.Entities;

public class Reservation : IValidatableObject
{
	public int Id { get; set; }
	public string Fname { get; set; }
	public string Lname { get; set; }
	public string BirthDay { get; set; }
	public string Gender { get; set; }
	public string PhoneNumber { get; set; }
	public string EmailAddress { get; set; }
	public int NumberGuest { get; set; }
	public string StreetAddress { get; set; }
	public string AptSuite { get; set; }
	public string City { get; set; }
	public string State { get; set; }
	public string ZipCode { get; set; }
	public string RoomType { get; set; }
	public string RoomFloor { get; set; }
	public string RoomNumber { get; set; }
	public double TotalBill { get; set; }
	public string PaymentType { get; set; }
	public string CardType { get; set; }
	public string CardNumber { get; set; }
	public string CardExp { get; set; }
	public string CardCvc { get; set; }
	public DateTime ArrivalTime { get; set; }
	public DateTime LeavingTime { get; set; }
	public bool CheckIn { get; set; }
	public int BreakFast { get; set; }
	public int Launch { get; set; }
	public int Dinner { get; set; }
	public bool Cleaning { get; set; }
	public bool Towel { get; set; }
	public bool Surprise { get; set; }
	public bool SupplyStatus { get; set; }
	public int FoodBill { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        List<ValidationResult> results = new List<ValidationResult>();
		if (!IsallDataFilled())
		{
			results.Add(new ValidationResult("not all data is provided, there is some missing fields"));
			return results;
		}
		if(!IsValidEmail(EmailAddress))
            results.Add(new ValidationResult("Email address is not valid", new[] { nameof(EmailAddress) }));

        if (!IsValidPhoneNumber(PhoneNumber))
			results.Add(new ValidationResult("phone number is not valid", new[] { nameof(PhoneNumber) }));
    
		if(!IsValidCardNumber(CardNumber))
            results.Add(new ValidationResult("card number is not valid", new[] { nameof(CardNumber) }));
		
		if(!IsValidExpData(CardExp))
			results.Add(new ValidationResult("card expiration date is not valid", new[] { nameof(CardExp) }));

        return results;
	}
	private bool IsValidEmail(string email)
	{
        var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        return regex.IsMatch(email);
    }
    private bool IsValidPhoneNumber(string phoneNumber)
    {
        var regex = new Regex(@"^(010|011|012)\d{8}$");
        return regex.IsMatch(phoneNumber);
    }
    private bool IsValidCardNumber(string cardNumber)
    {
        var regex = new Regex(@"^\d{4}-\d{4}-\d{4}-\d{4}$");
        return regex.IsMatch(cardNumber);
    }
	private bool IsValidExpData(string cardExp)
	{
        var regex = new Regex(@"\d{2}/\d{2}");
        return regex.IsMatch(cardExp);
    }
	private bool IsallDataFilled()
	{
		foreach(var property in typeof(Reservation).GetProperties())
		{
			if (property.Name != nameof(Id) && property.GetValue(this) is null || property.GetValue(this).Equals(string.Empty))
				return false;
		}
		return true;
	}
}
