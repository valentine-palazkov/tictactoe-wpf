Feature: Play interactive tic-tac-toe

Scenario: Should not be able to replace tic with tak
	Given board:
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to update board with:
    |   | 0 |   |
    |   |   |   |
    |   |   |   |
	Then the board should be:
    |   | x |   |
    |   |   |   |
    |   |   |   |

Scenario: Should allow tac after tic
	Given board:
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to update board with:
    |   | x |   |
    |   | 0 |   |
    |   |   |   |
	Then the board should be:
    |   | x |   |
    |   | 0 |   |
    |   |   |   |

Scenario: Should track move order
	Given board:
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to update board with:
    |   | x |   |
    |   | x |   |
    |   |   |   |
	Then the board should be:
    |   | x |   |
    |   |   |   |
    |   |   |   |

