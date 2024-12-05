import { Employee } from "../app/models/employee";

export class EmployeeCurdService
{
    public employees: Employee[] ;
        constructor() {
            this.employees= [
                new Employee(1, "John", 30, "images/1.png", "john@example.com"),
                new Employee(2, "Smith", 25, "images/2.png", "smith@example.com"),
                new Employee(3, "Mark", 28, "images/3.png", "mark@example.com")];
        }
    public getEmployees(): Employee[] {
        return this.employees;
    }
    public getEmployee(id: number): any {
        return this.employees.find(emp => emp.id == id);
    }
    public addEmlpoyee(employee: Employee): void {
        this.employees.push(employee);
    }
    public deleteEmployee(id: number): void {
        this.employees = this.employees.filter(emp => emp.id != id);
        console.log(this.employees);
    }
    public updateEmployee(employee: Employee): void {
        let index = this.employees.findIndex(emp => emp.id == employee.id);
        this.employees[index] = employee;
    }
}