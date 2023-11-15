-> main

=== main ===

Hi there Detective #name : LIST_MAX

How's it going?

    +[Going good]
    -> feeling ("That's good to hear.")
    
    +[Been better]
    -> feeling ("Oh that's not good.")
    
=== feeling(choice) ===
{choice} I heard some of my information helped you solve the last case.

    +[Yes it did.]
    -> information ("You're welcome, maybe I should consider changing careers.")
    
    +[Yes but it was mostly my detective skills if I'm honest]
    -> information ("Ouch, you hurt my ego.")
    
=== information(choice) ===
{choice} Unfortunately, I don't have any information to help you this time. 

    +[Think hard, something might come to mind]
    -> final ("I've got nothing Detective. Good luck")
    
=== final(choice) ===
{choice}

->END