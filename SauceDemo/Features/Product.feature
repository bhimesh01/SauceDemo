Feature: Product

Background:
Given I am on the login page
When I enter 'standard_user' as username
And I enter 'secret_sauce' as password
And I click on the login button
Then I should be on the products page

Scenario: Add a product to the cart
Given I am on the products page
When I select a product
And I click on the add to cart button
Then the product should be added to the cart

Scenario: Remove a product from the cart
Given I am on the products page
And I have added a product to the cart
When I click on the cart button
And I click on the remove button
Then the product should be removed from the cart
And I should be back on the products page