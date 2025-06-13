namespace Kolokwium.DTOs;


public class AddTreeRequest
{
    public TreeDto? Tree { get; set; }
    public List<AddResponsibleDto>? Responsible { get; set; }
}

public class TreeDto
{
    public int Quantity { get; set; }
    public string Species { get; set; }
    public string Nursery { get; set; }
}

public class AddResponsibleDto
{
    public int EmployeeId { get; set; }
    public string Role { get; set; }
}