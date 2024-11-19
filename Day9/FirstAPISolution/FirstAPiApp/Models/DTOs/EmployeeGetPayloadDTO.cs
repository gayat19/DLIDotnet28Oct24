namespace FirstAPiApp.Models.DTOs
{
    public class PaginationDTO
    {
        public int PageNumber { get; set; } = 1;
        public int TotalCount { get; set; } = 5;
    }
    public class EmployeeFilterDTO
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int DepatmentID { get; set; } = -1;
    }
    public class EmployeeGetPayloadDTO
    {
        public EmployeeGetPayloadDTO()
        {
            Pagination = new PaginationDTO();
            EmployeeFilter = new EmployeeFilterDTO();
        }
        public PaginationDTO Pagination { get; set; }
        public EmployeeFilterDTO EmployeeFilter { get; set; }

        //Employee Name - Asc =1, Desc =-1
        //Employee Email - Asc =2, Desc =-2
        //Employee Departmet - Asc =3, Desc =-3
        public int SortingOrder { get; set; } = 1;
    }
}
