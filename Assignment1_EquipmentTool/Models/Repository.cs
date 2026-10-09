namespace Assignment1_EquipmentTool.Models;

public class Repository
{
    private static readonly List<EquipmentRequest> requests = new();
    
    private static readonly List<Equipment> equipment = new()
    {
        new Equipment
        {
            Id = 1,
            Type = EquipmentType.Laptop,
            Description = "Dell Latitude laptop",
            Available = true
        },
        new Equipment
        {
            Id = 2,
            Type = EquipmentType.Phone,
            Description = "iPhone for testing mobile applications",
            Available = false
        },
        new Equipment
        {
            Id = 3,
            Type = EquipmentType.Tablet,
            Description = "iPad for presentations and testing",
            Available = true
        },
        new Equipment
        {
            Id = 4,
            Type = EquipmentType.Laptop,
            Description = "MacBook for software development",
            Available = false
        }
    };
    
    private static int nextId = 1;
    
    public static IEnumerable<EquipmentRequest> Requests => requests;
    
    public static IEnumerable<Equipment> Equipment => equipment;
    
    public static void  AddRequest(EquipmentRequest request)
    {
        request.Id = nextId++;
        requests.Add(request);
    }
}