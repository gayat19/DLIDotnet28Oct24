using FirstAPiApp.Contexts;
using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPiApp.Repositories
{
    public class DepartmentRepository : IRepository<int, Department>
    {
        readonly HRContext _hrContext;
        public DepartmentRepository(HRContext context)
        {
            _hrContext = context;
        }
        //public DepartmentRepository()
        //{
        //    _hrContext = new HRContext();
        //}
        public async Task<Department> AddAsync(Department item)
        {
            try
            {
                _hrContext.Add(item);
                await _hrContext.SaveChangesAsync();
                return item;
            }
            catch(Exception ex)
            {
                throw new Exception("Unable to add department " + ex.Message);
            }
        }

        public async Task<Department> DeleteAsync(int key)
        {
            var department = await GetAsync(key);
            if (department != null)
            {
                try
                {
                    _hrContext.Remove(department);
                    await _hrContext.SaveChangesAsync();
                    return department;
                }
                catch(Exception ex) 
                { 
                    throw new Exception("Unable to delete deparment "+ex.Message);
                }
            }
            throw new Exception("Unable to delete deparment");
        }

        public async Task<ICollection<Department>> GetAllAsync()
        {
            var departments = _hrContext.Departments;
            if (departments.Count() == 0)
                throw new Exception("No deparyments available in collection");
            return departments.ToList();
        }

        public async Task<Department> GetAsync(int key)
        {
            var department = _hrContext.Departments.FirstOrDefault(d=>d.DepartmentId == key);
            if (department == null)
                throw new Exception("No Department withthe given Id is available");
            return department;
        }

        public async Task<Department> UpdateAsync(int key, Department item)
        {
            var department = await GetAsync(key);
            if (department != null)
            {
                try
                {
                    _hrContext.Update(item);
                    await _hrContext.SaveChangesAsync();
                    return item;
                }
                catch (Exception ex)
                {
                    throw new Exception("Unable to update deparment " + ex.Message);
                }
            }
            throw new Exception("Unable to update deparment");
        }
    }
}
