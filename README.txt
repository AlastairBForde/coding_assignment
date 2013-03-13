Let's write code!

The task, if you choose to accept it (too late for that):

Yadda yadda REST yadda yadda OAuth yadda yadda grab stuff and put it somewhere and look at it and stuff. Also yadda yadda.

Or, in actual words... Use a programming language of your choice to write an app that consumes a REST API with Oauth (e.g. Twitter, Facebook, Google), saves the results in a database of your choice, and presents the content from the database in a Web page.

-=-=-=-=-=-=-

[1] Pick a programming language!
- it should preferably be one you know (duh), and one that handles both console work and web development.

Most likely candidate is C#, with Java as a back-up (get on learning php & python already!).


[2] Consume a REST API with OAuth
- The idea is to use OAuth (the same stuff that provides Twitter, Facebook, and Google-based apps with the functionality to access your stuff) to do things in a RESTful manner.

--> REST: Uses common HTTP methods to manipulate information

--> OAuth: the "security standard" by which your app gains access to the data involved, via a token system (signing people in @ school)
====> you request a request token (i want to be signed in)
====> pass the request token to a webpage as a query param (who's signing you in?)
====> webpage then asks user for access (do you want to sign him in?)
====> user agrees or disagrees (yes / no, he owes me money)
====> if yes, the response page appears with request credentials (here, fill out the form)
====> use the request credentials to get an access token & secret (turn in the form for a temporary pass)
====> app uses access token & secret (temp pass) with consumer key and secret (my own id) to access resources (i'll visit the caf / a lab)


[3] Save the results in a database
- After you grab user data, it ought to go into some sort of database (duh); ideally, you should grab some pretty simple pieces of info (like usernames or something, just to show you can get data) and store them in some sort of file; the file type will depend on the data being gathered.


[4] Present the database content in a web page
- Read in the information from the file, format it correctly, and allow it to be seen in a web page. You can figure out how to make it pretty later; for now, you should probably just worry about having the page access the data.