using System;

namespace Zookeeper.Tools;

public interface IMyLogger
{
    void Log(Exception exception, string message);
}