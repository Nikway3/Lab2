using Isu.Extra.Entities.Lessons;

namespace Isu.Extra.Entities.Student;

public class Flow
{
    private const int MaxStudentsInFlow = 30;
    private readonly List<GradeStudent> _flowStudents = new List<GradeStudent>();
    private int _flowNumber = 1;
    private Schedule _schedule;

    public int NewFlowNumberGenerator()
    {
        return _flowNumber++;
    }

    public Flow(Schedule flowLessons)
    {
        _schedule = flowLessons;
        FlowNumber = NewFlowNumberGenerator();
    }

    public int FlowNumber { get; }

    public Schedule GetFlowLessons()
    {
        return _schedule;
    }

    public void AddLesson(int weekday, Lessons.Lessons lesson)
    {
        _schedule.AddLesson(weekday, lesson);
    }

    public bool IsFull()
    {
        return _flowStudents.Count == MaxStudentsInFlow;
    }
}