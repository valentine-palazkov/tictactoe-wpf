Feature: Play interactive tic-tac-toe

Scenario: Should not be able to replace tic with tak
	Given board:
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to put a tac at {0, 1}
	Then the board should be:
    |   | x |   |
    |   |   |   |
    |   |   |   |

Scenario: Should allow tac after tic
	Given board:
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to put a tac at {1, 1}
	Then the board should be:
    |   | x |   |
    |   | 0 |   |
    |   |   |   |

Scenario: Should track move order
	Given board:
    |   | x |   |
    |   |   |   |
    |   |   |   |
	When try to put a tic at {1, 1}
	Then the board should be:
    |   | x |   |
    |   |   |   |
    |   |   |   |

