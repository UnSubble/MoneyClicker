using System;

public static class Objects
{
    public static T RequireNotNull<T>(T arg)
    {
        if (arg == null)
        {
            throw new ArgumentNullException();
        }
        return arg;
    }

    public static object[] RequireNotNullArray(params object[] args)
    {
        return RequireNotNullArray<object>(args);
    }

    public static T[] RequireNotNullArray<T>(params T[] args)
    {
        Objects.RequireNotNull(args);
        for (int i = 0; i < args.Length; i++)
        {
            T arg = args[i];
            if (arg == null)
            {
                throw new ArgumentNullException($"null entry at position:{i}");
            }
        }
        return args;
    }

}
