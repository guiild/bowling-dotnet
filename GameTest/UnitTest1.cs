using TestBowling;
using Xunit.Sdk;

namespace GameTest;

public class UnitTest1
{
    [Fact]
    public void TestLaunch_2_balls_without_spare_or_strike()
    {
        Bowling game = new Bowling();
        List<int> gameScores = new List<int>() { 2, 4 };
        foreach(int score in gameScores){
            game.NewThrow(score);
        }
        int result = game.GetCurrentScore();
        Assert.Equal(6, result);
    }
}