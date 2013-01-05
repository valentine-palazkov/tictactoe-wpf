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

@EmptyBoard
Scenario: Should allow tac after tic
	Given gamer puts 'x' at {0, 1}
	When gamer tries to put '0' at {1, 1}
	Then the board should be:
	|column1|column2|column3|
	|   | x |   |
	|   | 0 |   |
	|   |   |   |

@EmptyBoard
Scenario: Should track move order
	Given gamer puts 'x' at {0, 1}
	When gamer tries to put 'x' at {1, 1}
	Then the board should be:
	|column1|column2|column3|
	|   | x |   |
	|   |   |   |
	|   |   |   |

@EmptyBoard
Scenario: Should decide what move is next
	Given gamer makes a move at {0, 1}
	When gamer makes a move at {1, 1}
	Then the board should be:
	| column1 | column2 | column3 |
	|   | x |   |
	|   | 0 |   |
	|   |   |   |
