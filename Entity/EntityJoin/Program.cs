/*
Для объединения трех таблиц в Entity Framework Core можно использовать метод Join. Давайте рассмотрим пример с тремя таблицами.

Предположим, у нас есть три таблицы, которые связаны между собой:

Country (Страна):
Id (идентификатор)
Name (название страны)
Company (Компания):
Id (идентификатор)
Name (название компании)
CountryId (идентификатор страны, к которой принадлежит компания)
Country (ссылка на объект страны)
Users (список пользователей, работающих в компании)
User (Пользователь):
Id (идентификатор)
Name (имя пользователя)
Age (возраст пользователя)
CompanyId (идентификатор компании, в которой работает пользователь)
Company (ссылка на объект компании)
*/

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace YourNamespace
{
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CountryId { get; set; }
        public Country? Country { get; set; }
        public List<User> Users { get; set; } = new();
    }

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=helloapp.db");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        using (var db = new YourNamespace.ApplicationContext())
        {
            var usersWithCompanyAndCountry = db.Users
                .Join(
                    db.Companies, // вторая таблица
                    u => u.CompanyId,// свойство-селектор объекта из первой таблицы
                    c => c.Id,// свойство-селектор объекта из второй таблицы
                    (u, c) => new// результат
                    {
                        UserName = u.Name,// свойство из первой таблицы
                        CompanyName = c.Name,// свойство из второй таблицы
                        CompanyId = c.Id// свойство из второй таблицы
                    })
                .Join(
                    db.Countries,// третья таблица
                    uc => uc.CompanyId,// свойство-селектор объекта из предыдущего результата
                    co => co.Id,// свойство-селектор объекта из третьей таблицы
                    (uc, co) => new// результат
                    {
                        UserName = uc.UserName,// свойство из предыдущего результата
                        CompanyName = uc.CompanyName,// свойство из предыдущего результата
                        CountryName = co.Name// свойство из третьей таблицы
                    });

            foreach (var user in usersWithCompanyAndCountry)
            {
                Console.WriteLine($"User: {user.UserName}, Company: {user.CompanyName}, Country: {user.CountryName}");
            }
        }
    }
}
