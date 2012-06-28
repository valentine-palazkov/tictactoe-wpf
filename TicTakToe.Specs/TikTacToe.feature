Feature: TicTacToe
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Should not be able to replace tic with tak
	Given field:
    | _0_ |
    | ___ |
    | ___ |
	When try to update field with:
    | _x_ |
    | ___ |
    | ___ |
	Then the result should be:
    | _0_ |
    | ___ |
    | ___ |

