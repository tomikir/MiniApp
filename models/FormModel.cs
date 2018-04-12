using System.ComponentModel;

public class FormModel
{
    [DisplayName("First name")]
    public string FirstName { get; set; }
	
	[DisplayName("Last name")]
	public string LastName { get; set; }
}