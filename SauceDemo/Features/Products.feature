Feature: Products

Background:
  Given I am on the login page
  When I enter valid credentials
  And I click the login button

Scenario: Add a product to the cart
  Given I am on the products page
  When I select a product
  And I click the add to cart button
  Then the product should be added to the cart

Scenario: Remove a product from the cart
  Given I am on the products page
  And I have added a product to the cart
  When I click the remove button
  Then the product should be removed from the cart
  And I should be able to continue shopping