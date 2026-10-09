namespace Assignment1_EquipmentTool.Models;

public class Repository
{
    private static readonly List<EquipmentRequest> requests = new();
    
    private static int nextId = 1;
    
    public static IEnumerable<EquipmentRequest> Requests => requests;
    
    public static void  AddRequest(EquipmentRequest request)
    {
        request.Id = nextId++;
        requests.Add(request);
    }
}