﻿using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook.DataAcces;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
    {

    }
    public DbSet<Contact> Contacts { get; set; }
}
