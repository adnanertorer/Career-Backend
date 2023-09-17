namespace Career.BusinessLayer.CustomModels;

public class StatusResource
{
    public bool Status { get; set; }
    public int StatusInt { get; set; }
    public string ErrorStr { get; set; }
    public object? DynamicClass { get; set; }
}