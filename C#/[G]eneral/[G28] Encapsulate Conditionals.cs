if (ShouldBeDeleted(timer))
    
//is preferable to

if (timer.HasExpired() && !timer.IsRecurrent())
