using System;
using System.Collections.Generic;

namespace testDB;

public partial class User 
{
    public int? Id { get; set; }

    public string Name { get; set; } = null!;

    public string Mail { get; set; } = null!;
    public User(int? id, string name, string mail)
    {
        Id = id;
        Name = name;
        Mail = mail;
    }
    public override string ToString()
    {
        return $"{Id}, {Name}, {Mail}";
    }
}

