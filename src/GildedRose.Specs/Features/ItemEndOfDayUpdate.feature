Feature: ItemEndOfDayUpdate
	As a system owner
	In order to manage inventory
	I need to update quality and sell-in values each day

Scenario: Once the sell by date has passed, Quality degrades twice as fast
	Given I have an item
		| Name              | Sell in | Quality |
		| +5 Dexterity Vest | 1       | 20      |
	And the sell in date has passed
	When I update quality
	Then the quality should decrease by 2

Scenario: The Quality of an item is never negative
	Given I have an item
		| Name              | Sell in | Quality |
		| +5 Dexterity Vest | 10      | 20      |
	When I update quality
	Then the quality should be positive

Scenario: "Aged Brie" actually increases in Quality the older it gets
	Given I have an item
		| Name      | Sell in | Quality |
		| Aged Brie | 10      | 20      |
	When I update quality
	Then the sell in value should decrease by 1
	Then the quality should increase by 1

Scenario Outline: The Quality of an item is never more than 50
	Given I have an item
		| Name   | SellIn   | Quality   |
		| <Name> | <SellIn> | <Quality> |
	And it is not a Sulfuras
	When I update quality
	Then the quality should be less than 50

Examples:
	| Name                   | SellIn | Quality |
	| +5 Dexterity Vest      | 1      | 2       |
	| Aged Brie              | 10     | 3       |
	| Elixir of the Mongoose | 5      | 12      |
	| Conjured Mana Cake     | 13     | 23      |

Scenario: "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
	Given I have an item with the name of Sulfuras
		| Name                       | SellIn | Quality |
		| Sulfuras, Hand of Ragnaros | 0      | 80      |
	When I update quality
	Then the sell in date should be 0
	And the quality should be 80

Scenario: "Backstage passes" increases in Quality as it's SellIn  value approaches;

Scenario: "Backstage passes" acts like brie
	Given I have an item with the name of Backstage passes
		| Name                                      | SellIn | Quality |
		| Backstage passes to a TAFKAL80ETC concert | 12     | 2       |
	When I update quality
	Then the sell in value should decrease by 1
	Then the quality should increase by 1

Scenario: "Backstage passes" quality 1
	Given I have an item with the name of Backstage passes
		| Name                                      | SellIn | Quality |
		| Backstage passes to a TAFKAL80ETC concert | 9      | 2       |
	And the sell in date is 10 days or less
	When I update quality
	Then the quality should increase by 2

Scenario: "Backstage passes" quality 2
	Given I have an item with the name of Backstage passes
		| Name                                      | SellIn | Quality |
		| Backstage passes to a TAFKAL80ETC concert | 4      | 2       |
	And the sell in date is 5 days or less
	When I update quality
	Then the quality should increase by 3

Scenario: "Backstage passes" after the concert
	Given I have an item with the name of Backstage passes
		| Name                                      | Quality |
		| Backstage passes to a TAFKAL80ETC concert | 2       |
	And the concert has happened
	When I update quality
	Then the quality should be 0

# TODO

Scenario: "Conjured" items degrade in Quality twice as fast as normal items
	Given I have an item
		| Name               | Sell in | Quality |
		| Conjured Mana Cake | 10      | 20      |
	When I update quality
	Then the sell in value should decrease by 1
	Then the quality should decrease by 2