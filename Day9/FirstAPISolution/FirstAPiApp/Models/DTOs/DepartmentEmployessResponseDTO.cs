namespace FirstAPiApp.Models.DTOs
{
    public class DepartmentEmployessResponseDTO
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<EmployeeDTO> Employees { get; set; }
    }
}
