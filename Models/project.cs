using System.ComponentModel.DataAnnotations;

namespace COMP2139_Labs.Models;

public class project
{
    /// <summary>
    /// This is the primary key for the projects
    /// </summary>
    public int ProjectId { get; set; }
    
    /// <summary>
    /// The Name of the project
    /// [required]: Ensures this property must be set must have a project name
    /// </summary>
    
    [Required]
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime EndDate { get; set; }
    
    public string Status { get; set; }
}