Feature: Products Page

Scenario: Check product title
Given I am on the products page
When I look at a product
Then I should see the product title

Scenario: Check product price
Given I am on the products page
When I look at a product
Then I should see the product price

Scenario: Add product to cart
Given I am on the products page
When I click on 'Add to Cart' button of a product
Then the product should be added to the cart