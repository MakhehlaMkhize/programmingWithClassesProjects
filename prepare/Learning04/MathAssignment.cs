public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problem;

    public MathAssignment (string textBookSection, string problem, string studentName, string topic) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problem = problem;
    }
    public string GetHomework()
    {
        return $"Section {_textBookSection} Problem {_problem}";
    }
}       