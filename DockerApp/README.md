Given i have a <url> and <keywords>
When i Get result
Then I should get a string of numbers <"10,2,38">

Given i have a <url> and <keywords>
When there is no result
Then I should get a string of numbers "0">

url: https://www.google.co.uk/search?num=100&q=land+registry+search