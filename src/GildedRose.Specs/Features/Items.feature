Feature: Items
	As a system owner
	In order to manage invenrtory
	I need to be able to keep track of item behaviour

Scenario: Once the sell by date has passed, Quality degrades twice as fast
Given I have an item
And the sell date has passed
When the sell in value decreases by 1
Then the quality should increase by 2

Scenario: The Quality of an item is never negative
Given I have an item 
Then the quality should be positive

Scenario: "Aged Brie" actually increases in Quality the older it gets
Given I have an item with the name of "Aged Brie"
When the sell in value decreases by 1
Then the quality should increase by 1

Scenario: The Quality of an item is never more than 50
Given I have an item
And it is not a Sulfuras
When I get the item Quality
Then it should be less than 50

Scenario: "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
Given I have an item with the name of "Sulfuras"
Then the sell in date should be 0
And the quality should be 80
And the quality should not change

Scenario: "Backstage passes" increases in Quality as it's SellIn  value approaches; 

Scenario: "Backstage passes" acts like brie
Given I have an item with the name of "Backstage passes" 
When the sell in value decreases by 1
Then the quality should increase by 1


Scenario: "Backstage passes" quality 1
Given I have an item with the name of "Backstage passes" 
And the sell in date is 10 days or less
Then the quality should increase by 2

Scenario: "Backstage passes" quality 2
Given I have an item with the name of "Backstage passes" 
And the sell in date is 5 days or less
Then the quality should increase by 3

Scenario: "Backstage passes" after the concert
Given I have an item with the name of "Backstage passes" 
And the concert has happened
Then the quality should be 0



Scenario: "Conjured" items degrade in Quality twice as fast as normal items
