Feature: ExemplarItemEndOfDayUpdates
	As a system owner
	In order to manage inventory
	I need to be confident that changes to the implementation haven't introduced changes to expected behaviour


Scenario: Exemplar items produce expected results when updated
	Given I have these items:
		| Name                                      | Sell in | Quality |
		| +5 Dexterity Vest                         | 10      | 20      |
		| Aged Brie                                 | 2       | 0       |
		| Elixir of the Mongoose                    | 5       | 7       |
		| Sulfuras, Hand of Ragnaros                | 0       | 80      |
		| Backstage passes to a TAFKAL80ETC concert | 15      | 20      |
	When the items are updated 1 time
	Then the updated items are:
		| Name                                      | Sell in | Quality |
		| +5 Dexterity Vest                         | 9       | 19      |
		| Aged Brie                                 | 1       | 1       |
		| Elixir of the Mongoose                    | 4       | 6       |
		| Sulfuras, Hand of Ragnaros                | 0       | 80      |
		| Backstage passes to a TAFKAL80ETC concert | 14      | 21      |


		
Scenario: Exemplar items produce expected results when updated 15 times
	Given I have these items:
		| Name                                      | Sell in | Quality |
		| +5 Dexterity Vest                         | 10      | 20      |
		| Aged Brie                                 | 2       | 0       |
		| Elixir of the Mongoose                    | 5       | 7       |
		| Sulfuras, Hand of Ragnaros                | 0       | 80      |
		| Backstage passes to a TAFKAL80ETC concert | 15      | 20      |
	When the items are updated 15 times
	Then the updated items are:
		| Name                                      | Sell in | Quality |
		| +5 Dexterity Vest                         | -5      | 0       |
		| Aged Brie                                 | -13     | 28      |
		| Elixir of the Mongoose                    | -10     | 0       |
		| Sulfuras, Hand of Ragnaros                | 0       | 80      |
		| Backstage passes to a TAFKAL80ETC concert | 0       | 50      |


Scenario: Exemplar items produce expected results when updated 16 times
	Given I have these items:
		| Name                                      | Sell in | Quality |
		| +5 Dexterity Vest                         | 10      | 20      |
		| Aged Brie                                 | 2       | 0       |
		| Elixir of the Mongoose                    | 5       | 7       |
		| Sulfuras, Hand of Ragnaros                | 0       | 80      |
		| Backstage passes to a TAFKAL80ETC concert | 15      | 20      |
	When the items are updated 16 times
	Then the updated items are:
		| Name                                      | Sell in | Quality |
		| +5 Dexterity Vest                         | -6      | 0       |
		| Aged Brie                                 | -14     | 30      |
		| Elixir of the Mongoose                    | -11     | 0       |
		| Sulfuras, Hand of Ragnaros                | 0       | 80      |
		| Backstage passes to a TAFKAL80ETC concert | -1      | 0       |

