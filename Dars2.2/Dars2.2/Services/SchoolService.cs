using Dars2._2.Models;

namespace Dars2._2.Services;

public class SchoolService
{
    public List<School> Schools = new List<School>();

    public Guid AddSchool(School school)
    {
        school.SchoolId = Guid.NewGuid();
        Schools.Add(school);
        return school.SchoolId;
    }
    public Guid DeleteSchool(Guid schoolId)
    {
        School school = null;
        foreach (var s in Schools)
        {
            if (s.SchoolId == schoolId)
            {
                school = s;
                break;
            }
        }
        if (school != null)
        {
            Schools.Remove(school);
            return schoolId;
        }
        return Guid.Empty;
    }
    public List<School> GetAll()
    {
        return Schools;
    }
    public void UpdateSchool(School updatedSchool)
    {
        School exestingSchool = null;
        foreach (var s in Schools)
        {
            if (s.SchoolId == updatedSchool.SchoolId)
            {
                exestingSchool = s;
                break;
            }
        }
        if (exestingSchool != null)
        {
            exestingSchool.Number = updatedSchool.Number;
            exestingSchool.Capacity = updatedSchool.Capacity;
            exestingSchool.CurrentStudents = updatedSchool.CurrentStudents;
            exestingSchool.Location = updatedSchool.Location;
            exestingSchool.IsFree = updatedSchool.IsFree;
            exestingSchool.Language = updatedSchool.Language;
        }
    }
    public School GetById(Guid schoolId)
    {
        School school = null;
        foreach (var s in Schools)
        {
            if (s.SchoolId == schoolId)
            {
                school = s;
                break;
            }
        }
        return school;
    }
}
