Feature: Play interactive tic-tac-toe

 As I player
 I want to train my brain
 So that I can play tic-tak-toe game

@EmptyBoard
Scenario: Should not be able to replace tic with tak
	Given gamer puts 'x' at {0, 1}
	When gamer tries to put '0' at {0, 1}
	Then the board should be:
	| column1 | column2 | column3 |
	|         | x       |         |
	|         |         |         |
	|         |         |         |
		And rule violated should be 'Can not make move at {0, 1} as this move already made'

@EmptyBoard
Scenario: Should allow tac after tic
	Given gamer puts 'x' at {0, 1}
	When gamer tries to put '0' at {1, 1}
	Then the board should be:
	| column1 | column2 | column3 |
	|         | x       |         |
	|         | 0       |         |
	|         |         |         |

@EmptyBoard
Scenario: Should track move order
	Given gamer puts 'x' at {0, 1}
	When gamer tries to put 'x' at {1, 1}
	Then the board should be:
	| column1 | column2 | column3 |
	|         | x       |         |
	|         |         |         |
	|         |         |         |

@EmptyBoard
Scenario: Should decide what move is next
	Given gamer makes a move at {0, 1}
	When gamer makes a move at {1, 1}
	Then the board should be:
	| column1 | column2 | column3 |
	|         | x       |         |
	|         | 0       |         |
	|         |         |         |

@EmptyBoard
Scenario: Filled in center horizontal line should complete the game
Given board is:
| column1 | column2 | column3 |
| x       |         | x       |
|         |         |         |
|         |         |         |
	When gamer puts 'x' at {0, 1}
	Then the game completed

@EmptyBoard
Scenario: Filled in horizontal line should complete the game
Given board is:
| column1 | column2 | column3 |
| x       | x       |         |
|         |         |         |
|         |         |         |
	When gamer puts 'x' at {0, 2}
	Then the game completed

@EmptyBoard
Scenario: Filled diagonal line should complete the game
	Given board is:
	| column1 | column2 | column3 |
	| x       |         |         |
	|         | x       |         |
	|         |         |         |
	When gamer puts 'x' at {2, 2}
	Then the game completed

@EmptyBoard
Scenario: Filled in center diagonal line should complete the game
	Given board is:
	| column1 | column2 | column3 |
	| x       |         |         |
	|         |         |         |
	|         |         | x       |
	When gamer puts 'x' at {1, 1}
	Then the game completed

@EmptyBoard
Scenario: Filled in center vertical line should complete the game
Given board is:
| column1 | column2 | column3 |
|         | x       |         |
|         |         |         |
|         | x       |         |
	When gamer puts 'x' at {1, 1}
Then the game completed


@EmptyBoard
Scenario: Filled vertical line should complete the game
	Given board is:
	| column1 | column2 | column3 |
	| x       |         |         |
	| x       |         |         |
	|         |         |         |
	When gamer puts 'x' at {2, 0}
	Then the game completed

@EmptyBoard
Scenario: Filled all cells will mean that whole game completed
	Given board is:
	| column1 | column2 | column3 |
	| x       |0        |0        |
	| 0       |x        |x        |
	|         |0        |0        |
	When gamer puts 'x' at {2, 0}
	Then the game completed

@EmptyBoard
Scenario: Completed game should no allow new movies
	Given board is:
	| column1 | column2 | column3 |
	| x       |         |         |
	| x       |         |         |
	| x       |         |         |
	When gamer tries to put '0' at {0, 1}
	Then the board should be:
	| column1 | column2 | column3 |
	| x       |         |         |
	| x       |         |         |
	| x       |         |         |
		And rule violated should be 'Can not make move at {0, 1} as the game already completed'
