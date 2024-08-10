Feature: Monster

A short summary of the feature

@tag1
Scenario Outline: Create a monster succesfuly
	Given the user is on the url "http://localhost:3000/"
	When the user selects a monster option "<monster>"
	And the user fills the monster name with "<name>"
	And the user fills the monster hp with "<hp>"
	And the user fills the monster attack with "<attack>"
	And the user fills the monster defense with "<defense>"
	And the user fills the monster speed with "<speed>"
	And the user clicks the create monster button
	Then the monster should be created with the name "<name>"

Examples:

	| monster | name    | hp | attack | defense | speed |
	| 1       | dante   | 4  | 5      | 36      | 3     |
	| 2       | Olafo   | 39 | 54     | 36      | 36    |
	| 3       | kratos  | 37 | 54     | 36      | 26    |
	| 4       | caraxez | 45 | 56     | 36      | 36    |
	| 5       | mile    | 35 | 5      | 34      | 39    |

Scenario Outline: Try to create a monster with invalid data or rage
	Given the user is on the url "http://localhost:3000/"
	When the user selects a monster option "<monster>"
	And the user fills the monster name with "<name>"
	And the user fills the monster hp with "<hp>"
	And the user fills the monster attack with "<attack>"
	And the user fills the monster defense with "<defense>"
	And the user fills the monster speed with "<speed>"
	Then alert with the text "Please enter a valid number" should be displayed

Examples:

	| monster | name  | hp | attack | defense | speed |
	| 2       | dante | 3  | 5      | 3       | 355   |
	| 4       | Olafo | 35 | 54     | 36      | /     |

Scenario Outline: Try to create a monster with no data
	Given the user is on the url "http://localhost:3000/"
	When the user selects a monster option "<monster>"
	And the user clicks the create monster button
	Then alert with the text "All fields are required" should be displayed

Examples:

	| monster | name  | hp | attack | defense | speed |
	| 2       | dante | 3  | 5      | 3       | 355   |
	| 4       | Olafo | 35 | 54     | 36      | /     |

Scenario Outline: Mark a monster as a favorite
	Given the user is on the url "http://localhost:3000/"
	When the user selects a monster option "<monster>"
	And the user fills the monster name with "<name>"
	And the user fills the monster hp with "<hp>"
	And the user fills the monster attack with "<attack>"
	And the user fills the monster defense with "<defense>"
	And the user fills the monster speed with "<speed>"
	And the user clicks the create monster button
	Then the monster should be created with the name "<name>"
	When the user selects the icon favorite
	Then the icon must have the color "rgb(255, 0, 0)"

Examples:

	| monster | name  | hp | attack | defense | speed |
	| 2       | dante | 3  | 5      | 3       | 3     |
	| 4       | Olafo | 35 | 54     | 36      | 36    |

Scenario Outline: Unmark a monster as a favorite
	Given the user is on the url "http://localhost:3000/"
	When the user selects a monster option "<monster>"
	And the user fills the monster name with "<name>"
	And the user fills the monster hp with "<hp>"
	And the user fills the monster attack with "<attack>"
	And the user fills the monster defense with "<defense>"
	And the user fills the monster speed with "<speed>"
	And the user clicks the create monster button
	Then the monster should be created with the name "<name>"
	When the user selects the icon favorite
	Then the icon must have the color "rgb(255, 0, 0)"
	When the user selects the icon favorite
	Then the icon must have the color "rgba(0, 0, 0, 0.6)"

Examples:

	| monster | name  | hp | attack | defense | speed |
	| 2       | dante | 3  | 5      | 3       | 3     |
	| 4       | Olafo | 35 | 54     | 36      | 36    |

Scenario Outline: Delete a monster succesfully
	Given the user is on the url "http://localhost:3000/"
	When the user selects a monster option "<monster>"
	And the user fills the monster name with "<name>"
	And the user fills the monster hp with "<hp>"
	And the user fills the monster attack with "<attack>"
	And the user fills the monster defense with "<defense>"
	And the user fills the monster speed with "<speed>"
	And the user clicks the create monster button
	Then the monster should be created with the name "<name>"
	When the user deletes the monster "<name>"
	When the text "There are no monsters" should be displayed

Examples:

	| monster | name  | hp | attack | defense | speed |
	| 2       | dante | 3  | 5      | 3       | 3     |
	| 4       | Olafo | 35 | 54     | 36      | 36    |

