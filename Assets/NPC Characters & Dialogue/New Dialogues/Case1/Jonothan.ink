-> main 

=== main ===

Hi there, you must be the Detective, Hi I'm Jonathan. #name: Jonothan

   +[Nice to meet you, what do you know about the murder?]
   ->reply
   +[Nice to meet you, have a good day]
   ->Finish

=== reply === 
My wife Sally, is best friends with Peter's wife.

   +[Do you know anything about his death?]
   ->reply1

=== reply1 === 

I kinda knew him, we got along but we weren't great friends.

Try talking to Sally. She may know more than I do.
->Finish

=== Finish === 
Bye.
->END
   
