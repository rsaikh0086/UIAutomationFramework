Feature: AddElements

Scenario Outline: Add New Elements and validate
When I add <number> elements
Then <number> elements should be created
Examples: 
| number |
| 5      |

