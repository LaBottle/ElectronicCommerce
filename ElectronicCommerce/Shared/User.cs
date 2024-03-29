﻿namespace ElectronicCommerce.Shared;

public class User {
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public string Address { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; } = DateTime.Now;
}