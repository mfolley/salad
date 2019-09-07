# salad
This solution demonstrates some of the problems faced when processing data in a distributed asynchronous system.

The goal is to make the tests pass. There are some rules to follow though:
- Don't change the configuration of the system, for example the number of actors in each pool or the communication routes
- Don't modify the data that's being processed
- Don't modify the logic that's currently in the actors

You can, however:
- Extend or add to the data that's being processed, for example with additional metadata
- Extend or add logic in the actors
