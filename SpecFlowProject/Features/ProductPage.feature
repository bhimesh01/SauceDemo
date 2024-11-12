Feature: Products Page

Background: 
Given User is on the login page
When User enters username as "standard_user" and password as "secret_sauce"
And User clicks on login button
Then User should be redirected to the products page

Scenario: Add a product to the cart
Given User is on the products page
When User selects a product "product_1"
And User clicks on the add to cart button for "product_1"
Then "product_1" should be added to the cart

Scenario: Remove a product from the cart
Given User is on the products page
When User selects a product "product_2"
And User clicks on the add to cart button for "product_2"
And User clicks on the cart button
And User clicks on the remove button for "product_2"
Then "product_2" should be removed from the cart
And User clicks on the back to products button
Then User should be redirected to the products page