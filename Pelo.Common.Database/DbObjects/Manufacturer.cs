namespace Pelo.Common.Database.DbObjects;

public class Manufacturer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid? CreatedByUser { get; set; }
    public string CreatedByUserName { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public Guid? UpdatedByUser { get; set; }
    public string UpdatedByUserName { get; set; }
    public bool IsDeleted { get; set; }
}