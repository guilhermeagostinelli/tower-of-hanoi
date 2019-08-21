# Tower of Hanoi

Implementation of the famous puzzle "Tower of Hanoi" using C# / Windows Forms Application.

There's also a .vdproj file in the codebase used for creating an installer (.exe and .msi files).

## History and How to Play

The puzzle's main goal is to move disks from the leftmost peg onto the rightmost peg.
However, bigger disks cannot be put on the top of smaller ones and only one disk may be moved at a time.

The original Tower of Hanoi was invented in 1883 by the french mathematician Édouard Anatole Lucas, who was inspired by the Hindu myth which said that, after the priests completed the tiring task of finishing a tower of 64 disks, the world would vanish and everything would be turned into dust.

## Screenshots and Brief Description

- **Main Screen**

  Application's main screen menu.
  
  ![Tower of Hanoi - Main Screen](/Screenshots/main-screen.png)
  
- **Gameplay**

  Inside the game. In order to play, the player must click on the desired disk and then on the destination peg. On the bottom of the screen there's a time and movement count indicator. If it isn't disabled, the player can also press the blue arrow to undo the last movement.
  
  ![Tower of Hanoi - Gameplay](/Screenshots/game.png)
  
- **Options**

  Options screen where the player can customize the number of disks, their colors, and also disable/enable the sound and the undo button.
  
  ![Tower of Hanoi - Options](/Screenshots/options-disk-color.png)
  
- **Scores**

  Screen where the player can see the best scores for each number of disks. 
  It's worth noting that the scores are encrypted in a .dat file so players cannot simply change them.
  
  ![Tower of Hanoi - Scores](/Screenshots/scores.png)

## Contributing

Feel free to contribute with corrections, optimizations, etc. Since this is a recreational project, there's no strict guidelines on how one should contribute. 

## License

This project is licensed under the GNU GPLv3 - see the [LICENSE](LICENSE) file for details.
