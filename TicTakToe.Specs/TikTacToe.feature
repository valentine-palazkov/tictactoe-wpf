Feature: Play interactive tic-tac-toe

Scenario: Should not be able to replace tic with tak
	Given board:
	|column1|column2|column3|
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to put '0' at {0, 1}
	Then the board should be:
    |   | x |   |
    |   |   |   |
    |   |   |   |

Scenario: Should allow tac after tic
	Given board:
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to put a '0' at {1, 1}
	Then the board should be:
    |   | x |   |
    |   | 0 |   |
    |   |   |   |

Scenario: Should track move order
	Given board:
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to put a 'x' at {1, 1}
	Then the board should be:
    |   | x |   |
    |   |   |   |
    |   |   |   |

