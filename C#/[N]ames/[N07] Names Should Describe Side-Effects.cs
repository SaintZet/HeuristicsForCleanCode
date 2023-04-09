public ObjectOutputStream GetOos()
{
    if (_oos == null) {
        _oos = new ObjectOutputStream(_socket.GetOutputStream());
    }

    return _oos;
}
// This function does a bit more than get an "oos";
// it creates the "oos" if it hasn't been created already.
// Thus, a better name might be CreateOrReturnOos.