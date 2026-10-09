using System.ComponentModel.DataAnnotations;

namespace Assignment1_EquipmentTool.Models;

public class EquipmentRequest
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please enter a name.")]
    public string Name { get; set; } =  string.Empty;
    
    [Required(ErrorMessage = "Please enter your email address.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please enter your phone number.")]
    [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must use the format xxx-xxx-xxxx.")]    
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please enter your Role Student or Professor.")]
    public string Role { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please enter an equipment type.")]
    [Display(Name = "Equipment Type")]
    public EquipmentType? EquipmentType { get; set; } = null;
    
    [Required(ErrorMessage = "Please enter request details.")]
    [Display(Name = "Request Details")]
    public string RequestDetails { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please enter a time.")]
    [Range (1, int.MaxValue, ErrorMessage = "Please enter a duration period that is greater that zero.")]
    [Display(Name = "Time Period")]
    public int? Duration { get; set; } = null;
    
}