Feature: Play interactive tic-tac-toe

@EmptyBoard
Scenario: Should not be able to replace tic with tak
	Given gamer puts 'x' at {0, 1}
	When gamer tries to put '0' at {0, 1}
	Then the board should be:
	|column1|column2|column3|
    |   | x |   |
    |   |   |   |
    |   |   |   |

Scenario: Should allow tac after tic
	Given board:
	|column1|column2|column3|
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to put a '0' at {1, 1}
	Then the board should be:
	|column1|column2|column3|
    |   | x |   |
    |   | 0 |   |
    |   |   |   |

Scenario: Should track move order
	Given board:
	|column1|column2|column3|
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to put a 'x' at {1, 1}
	Then the board should be:
	|column1|column2|column3|
    |   | x |   |
    |   |   |   |
    |   |   |   |

