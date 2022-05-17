# minesweeper

MVP

* Recreate a simplified version of the game Minesweeper to be played in a C# console application
* The game should be able to randomly generate 10 mines in a 10x10 grid
* The user will be able to enter a command that represents a coordinate to check a location for a mine
* The application will display a number from 0-8 depending on how many mines surround that location
* If the user selects a mine, the game will respond "boom!" and the game will be lost
* If every non-mine square has been revealed, the game is won


Bonuses
* Render a grid of 10x10 mines with numbers indicating checked spaces
* Allow for the user to configure number of mines and grid size via a configuration.json file
* (Difficult) Discovering an empty square should reveal all squares around it, and cascade into other nearby empty squares
