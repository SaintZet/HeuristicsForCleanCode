// Consider the code below. What does it do?
// If I show you the code with well-chosen names, it will make perfect sense to you,
// but like this it's just a hodge-podge of symbols and magic numbers.

public int Score()
{
    int score = 0;
    int frame = 0;

    for (int frameNumber = 0; frameNumber < 10; frameNumber++)
    {
        if (IsStrike(frame))
        {
            score += 10 + NextTwoBallsForStrike(frame);
            frame += 1;
        }
        else if (IsSpare(frame))
        {
            score += 10 + NextBallForSpare(frame);
            frame += 2;
        }
        else
        {
            score += TwoBallsInFrame(frame);
            frame += 2;
        }
    }
    return score;
}
// Here is the code the way it should be written.
// This snippet is actually less complete than the one above.
// Yet you can infer immediately what it is trying to do,
// and you could very likely write the missing functions based on that inferred meaning.
// The magic numbers are no longer magic, and the structure of the algorithm is compellingly descriptive.

public int Score()
{
    int score = 0;
    int frame = 0;

    for (int frameNumber = 0; frameNumber < 10; frameNumber++)
    {
        if (IsStrike(frame))
        {
            score += 10 + NextTwoBallsForStrike(frame);
            frame += 1;
        }
        else if (IsSpare(frame))
        {
            score += 10 + NextBallForSpare(frame);
            frame += 2;
        }
        else
        {
            score += TwoBallsInFrame(frame);
            frame += 2;
        }
    }
    return score;
}
// You can infer the implementation of IsStrike() by looking at the code above.
// When you read the IsStrike method, it will be "pretty much what you expected".

private bool IsStrike(int frame)
{
    return _rolls[frame] == 10;
}