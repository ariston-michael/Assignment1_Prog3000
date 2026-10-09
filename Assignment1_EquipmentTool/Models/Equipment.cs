namespace Assignment1_EquipmentTool.Models;

public class Equipment
{
    public int Id { get; set; }
    public EquipmentType Type { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool Available { get; set; }
    
}