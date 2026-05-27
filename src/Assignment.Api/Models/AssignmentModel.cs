namespace Assignment.Api.Models;

public class AssignmentModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
    public int Hours { get; set; }
    public string Status { get; set; } = "not-started";
}
