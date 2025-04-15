using System;
using System.Collections.Generic;

namespace BlogApi.Models;

public partial class Contact
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Message { get; set; }

    public DateTime? CreatedAt { get; set; }
}
