﻿

namespace Infrastructure.Model;

public class CourseResult
{

    public bool Succeeded { get; set; }
    public int TotalPages { get; set; }
    public int TotalItems { get; set; }

    public IEnumerable<CourseModel>? Courses { get; set; }

}
