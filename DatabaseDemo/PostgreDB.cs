using DatabaseDemo.model;
using LinqToDB;
using LinqToDB.Data;

namespace DatabaseDemo
{
    public class PostgreDB : DataConnection
    {
        public ITable<Employees> Employeeses => GetTable<Employees>();
    }
}