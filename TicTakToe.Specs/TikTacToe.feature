Feature: TicTacToe
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Should not be able to replace tic with tak
	Given board:
    | 1 | 2 | 3 |
    |   | x |   |
    |   |   |   |
    |   |   |   |
        And the last move is at [1, 2]
	When try to update board with:
    | 1 | 2 | 3 |
    |   | 0 |   |
    |   |   |   |
    |   |   |   |
	Then the board should be:
    | 1 | 2 | 3 |
    |   | x |   |
    |   |   |   |
    |   |   |   |

Scenario: Should allow tac after tic
	Given board:
    | 1 | 2 | 3 |
    |   | x |   |
    |   |   |   |
    |   |   |   |
        And the last move is at [1, 2]
	When try to update board with:
    | 1 | 2 | 3 |
    |   | x |   |
    |   | 0 |   |
    |   |   |   |
	Then the board should be:
    | 1 | 2 | 3 |
    |   | x |   |
    |   | 0 |   |
    |   |   |   |


Scenario: Should track move order
	Given board:
    | 1 | 2 | 3 |
    |   | x |   |
    |   |   |   |
    |   |   |   |
        And the last move is at [1, 2]
	When try to update board with:
    | 1 | 2 | 3 |
    |   | x |   |
    |   | x |   |
    |   |   |   |
	Then the board should be:
    | 1 | 2 | 3 |
    |   | x |   |
    |   |   |   |
    |   |   |   |

