namespace StructuralPatterns.SubmittingStudent.Bridges;

public class SubmittingStudent
{
    private IMentor _mentor;

    public SubmittingStudent(IMentor mentor)
    {
        _mentor = mentor ?? throw new ArgumentNullException();
    }

    public bool SubmitLab()
    {
        _mentor.SayHi();
        return _mentor.CheckLab();
    }
}
