using Dars2._3.Models;

namespace Dars2._3.Services;

internal class CourseService
{
    List<Course> Courses;
    public CourseService()
    {
        Courses = new List<Course>();
    }
    public List<Course> GetAllCourses()
    {
        return Courses;
    }
    public Guid AddCourse(Course course)
    {
        course.CourseId = Guid.NewGuid();
        Courses.Add(course);
        return course.CourseId;
    }
    public Course? GetCourseById(Guid courseId)
    {
        foreach (var c in Courses)
        {
            if (c.CourseId == courseId)
            {
                return c;
            }
        }
        return null;
    }
    public bool DeleteCourse(Guid courseId)
    {
        foreach (var c in Courses)
        {
            if (c.CourseId == courseId)
            {
                Courses.Remove(c);
                return true;
            }
        }
        return false;
    }
    public bool UpdateCourse(Guid courseId, Course newCourse)
    {
        for (var i = 0; i < Courses.Count; i++)
        {
            if (Courses[i].CourseId == courseId)
            {
                Courses[i].DurationHours = newCourse.DurationHours;
                Courses[i].Instructor = newCourse.Instructor;
                Courses[i].Price = newCourse.Price;
                Courses[i].HasSertificate = newCourse.HasSertificate;
                Courses[i].Level = newCourse.Level;
                Courses[i].Title = newCourse.Title;
                return true;
            }
        }
        return false;
    }
    public List<Course>? GetCourseByLevel(string level)
    {
        var list = new List<Course>();
        foreach (var c in Courses)
        {
            if (c.Level == level)
            {
                list.Add(c);
            }
        }
        if (list.Count == 0)
        {
            return null;
        }
        return list;
    }
}
