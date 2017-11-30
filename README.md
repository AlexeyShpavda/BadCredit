# BadCredit
Console App
***
Odds are you have a credit card in your wallet. That card has a number, both printed on its face and embedded (perhaps
with some other data) in the magnetic stripe on back. That number is also stored in a database somewhere, so that when
your card is used to buy something, the creditor knows whom to bill.
There are a lot of people with credit cards in this world, so those numbers are pretty long: American Express uses 15-digit
numbers, MasterCard uses 16-digit numbers, and Visa uses 13- and 16-digit numbers. And those are decimal numbers (0
through 9), not binary, which means, for instance, that American Express could print as many as 10^(15) =
1,000,000,000,000,000 unique cards! (That’s, ahem, a quadrillion.) Now that’s a bit of an exaggeration, because credit
card numbers actually have some structure to them.
- [x] Multiply every other digit by 2, starting with the number’s second-to-last digit, and then add those products'digits together.
- [x] Add the sum to the sum of the digits that weren’t multiplied by 2.
- [x] If the total’s last digit is 0 (or, put more formally, if the total modulo 10 is congruent to 0), the number is valid!

+ Let’s try an example with American Express: 378282246310005.
1. For the sake of discussion, let’s first underline every other digit, starting with the number’s second-to-last digit:
378282246310005
Okay, let’s multiply each of the underlined digits by 2:
7•2 + 2•2 + 2•2 + 4•2 + 3•2 + 0•2 + 0•2
That gives us:
14 + 4 + 4 + 8 + 6 + 0 + 0
Now let’s add those products' digits (i.e., not the products themselves) together:
1 + 4 + 4 + 4 + 8 + 6 + 0 + 0 = 27
2. Now let’s add that sum (27) to the sum of the digits that weren’t multiplied by 2:
27 + 3 + 8 + 8 + 2 + 6 + 1 + 0 + 5 = 60
3. Yup, the last digit in that sum (60) is a 0, so the card is legit!

So, validating credit card numbers isn’t hard, but it does get a bit tedious by hand. Let’s write a program.
Write a program that prompts the user for a credit card number and then reports whether it is a valid American Express, MasterCard, or Visa card number, per the definitions of each’s format herein.
***