# MG3
## Devlog
Write your Devlog here.
1. When I added a float, int, bool, and string as public member variables to the Timer class, the Inspector showed that the default value for a float is 0, for an int is 0, for a bool is false (the checkbox is unchecked), and for a string is empty.

2. My code does not call the Update method. Since Timer, KickWeapon, and TimerText are MonoBehaviours attached to GameObjects, Unity automatically calls their Update method once every frame while the game is running.

3. When the player presses space, the Player class calls ActivateKick, which turns on the kick and starts its Timer with the number of seconds in _lifetimeSeconds. Every frame, the Timer's Update method subtracts Time.deltaTime from the time left. At the same time, KickWeapon's own Update method checks every frame whether the timer is finished. Once the time runs out, it turns the kick off, so the kick only stays active for a split second instead of forever.
## Open-Source assets
- [Cat fighter spritesheet](https://opengameart.org/content/cat-fighter-sprite-sheet)
- [Food sprites](https://rcpstd.itch.io/pixel-food-pack)