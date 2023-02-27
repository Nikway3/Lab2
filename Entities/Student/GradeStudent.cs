using Isu.Entities;
using Isu.Extra.Entities.Student;

namespace Isu.Extra.Entities.Student;

public class GradeStudent
{
    private readonly string _name;
    private int _id;
    private Group _group;

    public GradeStudent(string name, int id, GradeGroup group)
    {
        _name = name;
        _id = id;
        _group = group;
    }
}