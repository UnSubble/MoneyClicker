using System;

public interface Event
{
    public bool HasEnded();

    public void Handle();

}
