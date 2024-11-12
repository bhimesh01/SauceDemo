Feature: Product
  As a user
  I want to be able to add and remove products from the cart

  Background:
    Given I am on the login page
    When I enter valid credentials
    Then I should be redirected to the products page

  Scenario: Add a product to the cart
    Given I am on the products page
    When I select a product
    And I click on the add to cart button
    Then the product should be added to the cart

  Scenario: Remove a product from the cart
    Given I have added a product to the cart
    When I click on the remove button
    Then the product should be removed from the cart
    And I should be redirected to the products page