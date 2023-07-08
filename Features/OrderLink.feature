Feature: OrderLink

Given I am a user on rahulshettyacademy website

@tag1
Scenario: verify user can order carrot
	Given I navigate to rahulshettyacademy website
	When I click on the add to cart button on the carrot item
	And I clicked on the cart icon
	And I clicked on proceed to checkout
	And I clicked on the place order button
	And I select country 'Nigeria'
	And I click on the agree to terms and condition
	And I click on place order button
	Then a successful message is displayed
	And I am redirected to the home page
