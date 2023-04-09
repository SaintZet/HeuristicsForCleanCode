// Consider the code below. What does it do? 
// If I show you the code with well-chosen names, it will make perfect sense to you, 
// but like this it's just a hodge-podge of symbols and magic numbers.

public int score() {
    int score = 0;
    int frame = 0;
    for (int frameNumber = 0; frameNumber < 10; frameNumber++) {
        if (isStrike(frame)) {
            score += 10 + nextTwoBallsForStrike(frame);
            frame += 1;
        } else if (isSpare(frame)) {
            score += 10 + nextBallForSpare(frame);
            frame += 2;
        } else {
            score += twoBallsInFrame(frame);
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

public int score() {
    int score = 0;
    int frame = 0;
    for (int frameNumber = 0; frameNumber < 10; frameNumber++) {
        if (isStrike(frame)) {
            score += 10 + nextTwoBallsForStrike(frame);
            frame += 1;
        } else if (isSpare(frame)) {
            score += 10 + nextBallForSpare(frame);
            frame += 2;
        } else {
            score += twoBallsInFrame(frame);
            frame += 2;
        }
    }
    return score;
}
// You can infer the implementation of isStrike() by looking at the code above. 
// When you read the isStrike method, it will be "pretty much what you expected".

private boolean isStrike(int frame) {
    return rolls[frame] == 10;
}