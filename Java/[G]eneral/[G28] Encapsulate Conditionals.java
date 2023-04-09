if (shouldBeDeleted(timer))
    
//is preferable to

if (timer.hasExpired() && !timer.isRecurrent())
