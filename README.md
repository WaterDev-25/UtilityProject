# UtilityProject
A dll for lazy developers

# Setup Project:

```
// Exemple of code

using UtilityProject;
using UtilityProject.Server;

namespace UtilityProjectTest
{
    class Program : Mono
    {
        static void Main(string[] args)
        {
            Server.CreateServer(4444);
        }
    }
}
```

# Functions:

```Server.CreateServer(4444);```

```Client.ConnectToServer("127.0.0.1", 4444);```

```Client.SendPacket("Exemple of packet");```

```print(args);```

```println(args);```

```delay(args);```
