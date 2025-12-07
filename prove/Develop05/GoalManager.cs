using System;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public void CompleteTask(Goal goal)
    {
        switch (goal.GetGoalType())
        {
            case "Simple Goal" || :
            _score += goal.GetPoints();
            goal.SetCompletion(true);
            break;

            case "Eternal Goal":
            _score += goal.GetPoints();
            break;

            case "Checklist Goal":
            if 

                    
        }  
    }
}