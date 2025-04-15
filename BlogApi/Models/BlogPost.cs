using System;
using System.Collections.Generic;

namespace BlogApi.Models;

public partial class BlogPost
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? Url { get; set; }
}
